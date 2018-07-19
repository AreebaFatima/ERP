using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ERP
{
    public partial class Add_Customer : Form
    {
        My_Conn f2 = new My_Conn();
        public Add_Customer()
        {
            InitializeComponent();
        }

        private void Add_Customer_Load(object sender, EventArgs e)
        {
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = Color.Wheat;
            this.ControlBox = false;
            CNameTB.ReadOnly = true;
            CCityTB.ReadOnly = true;
            CCPNameTB.ReadOnly = true;
            CCPphTB.ReadOnly = true;
            CDeptTB.ReadOnly = true;
            CustomerPh1TB.ReadOnly = true;
            CustomerPh2TB.ReadOnly = true;
            CLimitTB.ReadOnly = true;
            CMailTB.ReadOnly = true;
            CAddressTB.ReadOnly = true;
            CStatusTB.ReadOnly = true;
            SFABTN.Enabled = false;
            DisapproveBtn.Visible = false;
            ApproveBtn.Visible = false;
            CIDCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ApproveBtn.BackColor = Color.SaddleBrown;
            DisapproveBtn.BackColor = Color.SaddleBrown;
            SFABTN.BackColor = Color.SaddleBrown;
            ApproveBtn.ForeColor = Color.White;
            DisapproveBtn.ForeColor = Color.White;
            SFABTN.ForeColor = Color.White;
            ApproveBtn.Cursor = Cursors.Hand;
            DisapproveBtn.Cursor = Cursors.Hand;
            SFABTN.Cursor = Cursors.Hand;
            ApproveBtn.FlatStyle = FlatStyle.Popup;
            DisapproveBtn.FlatStyle = FlatStyle.Popup;
            SFABTN.FlatStyle = FlatStyle.Popup;

            AddPB1.BackColor = Color.SaddleBrown;
            AddPB2.BackColor = Color.SaddleBrown;


            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select CID from Customer", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CIDCombo.Items.Add(dr["CID"]).ToString();
            }
            f2.oleDbConnection1.Close();
        }

        private void CIDCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from Customer where CID = @CID", f2.oleDbConnection1);
            cmd.Parameters.AddWithValue("@CStatus", CIDCombo.Text);
            cmd.Parameters.AddWithValue("@CName", CIDCombo.Text);
            cmd.Parameters.AddWithValue("@CGroup", CIDCombo.Text);
            cmd.Parameters.AddWithValue("@City", CIDCombo.Text);
            cmd.Parameters.AddWithValue("@CAddress", CIDCombo.Text);
            cmd.Parameters.AddWithValue("@PH1", CIDCombo.Text);
            cmd.Parameters.AddWithValue("@PH2", CIDCombo.Text);
            cmd.Parameters.AddWithValue("@CreditLimit", CIDCombo.Text);
            cmd.Parameters.AddWithValue("@CEmail", CIDCombo.Text);
            cmd.Parameters.AddWithValue("@CCPName", CIDCombo.Text);
            cmd.Parameters.AddWithValue("@CPPH", CIDCombo.Text);

            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                CStatusTB.Text = dr["CStatus"].ToString();
                CNameTB.Text = dr["CName"].ToString();
                CDeptTB.Text = dr["CGroup"].ToString();
                CCityTB.Text = dr["City"].ToString();
                CAddressTB.Text = dr["CAddress"].ToString();
                CustomerPh1TB.Text = dr["PH1"].ToString();
                CustomerPh2TB.Text = dr["PH2"].ToString();
                CLimitTB.Text = dr["CreditLimit"].ToString();
                CMailTB.Text = dr["CEmail"].ToString();
                CCPNameTB.Text = dr["CCPName"].ToString();
                CCPphTB.Text = dr["CPPH"].ToString();
            }
            SFABTN.Enabled = true;
            f2.oleDbConnection1.Close();
        }

        private void SFABTN_Click(object sender, EventArgs e)
        {
            CStatusTB.Text = "SFA";
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Update Customer set CStatus = '" + CStatusTB.Text + "' where CID = @CID", f2.oleDbConnection1);
            cmd.Parameters.AddWithValue("@CID", CIDCombo.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully sent for approval !", "SFA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            f2.oleDbConnection1.Close();

            ApproveBtn.Visible = true;
            DisapproveBtn.Visible = true;
            SFABTN.Visible = false;
        }

        private void ApproveBtn_Click(object sender, EventArgs e)
        {

            CStatusTB.Text = "ACTIVE";
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Update Customer set CStatus = '" + CStatusTB.Text + "' where CID = @CID", f2.oleDbConnection1);
            cmd.Parameters.AddWithValue("@CID", CIDCombo.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Customer Approved !", "Approval", MessageBoxButtons.OK, MessageBoxIcon.Information);
            f2.oleDbConnection1.Close();
        }

        private void DisapproveBtn_Click(object sender, EventArgs e)
        {
            CStatusTB.Text = "INACTIVE";
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Update Customer set CStatus = '" + CStatusTB.Text + "' where CID = @CID", f2.oleDbConnection1);
            cmd.Parameters.AddWithValue("@CID", CIDCombo.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Customer Disapproved !", "Approval", MessageBoxButtons.OK, MessageBoxIcon.Information);
            f2.oleDbConnection1.Close();
        }
    }
}
