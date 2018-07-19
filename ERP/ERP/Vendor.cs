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
    public partial class Vendor : Form
    {
        My_Conn f2 = new My_Conn();
        //int count = 0;
        public Vendor()
        {
            InitializeComponent();
        }

        private void Vendor_Load(object sender, EventArgs e)
        {
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = Color.Wheat;
            this.ControlBox = false;
            VNameTB.ReadOnly = true;
            VCodeTB.ReadOnly = true;
            VCityTB.ReadOnly = true;
            VCPNameTB.ReadOnly = true;
            VCPphTB.ReadOnly = true;
            VDeptTB.ReadOnly = true;
            VPh1TB.ReadOnly = true;
            VPh2TB.ReadOnly = true;
            VFaxTB.ReadOnly = true;
            VMailTB.ReadOnly = true;
            VAddressTB.ReadOnly = true; 
            VStatusTB.ReadOnly = true;
            button2.Enabled = false;
            DisapproveBtn.Visible = false;
            ApproveBtn.Visible = false;
            VIDCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ApproveBtn.BackColor = Color.SaddleBrown;
            DisapproveBtn.BackColor = Color.SaddleBrown;
            button2.BackColor = Color.SaddleBrown;
            ApproveBtn.ForeColor = Color.White;
            DisapproveBtn.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            ApproveBtn.Cursor = Cursors.Hand;
            DisapproveBtn.Cursor = Cursors.Hand;
            button2.Cursor = Cursors.Hand;
            ApproveBtn.FlatStyle = FlatStyle.Popup;
            DisapproveBtn.FlatStyle = FlatStyle.Popup;
            button2.FlatStyle = FlatStyle.Popup;

            AddPB1.BackColor = Color.SaddleBrown;
            AddPB2.BackColor = Color.SaddleBrown;


            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select VID from Vendor", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                VIDCombo.Items.Add(dr["VID"]).ToString();
            }
            f2.oleDbConnection1.Close();
        }

        private void VIDCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from Vendor where VID = @VID",f2.oleDbConnection1);
            cmd.Parameters.AddWithValue("@VName", VIDCombo.Text);
            cmd.Parameters.AddWithValue("@VCode", VIDCombo.Text);
            cmd.Parameters.AddWithValue("@VCity", VIDCombo.Text);
            cmd.Parameters.AddWithValue("@VGroup", VIDCombo.Text);
            cmd.Parameters.AddWithValue("@PH1", VIDCombo.Text);
            cmd.Parameters.AddWithValue("@PH2", VIDCombo.Text);
            cmd.Parameters.AddWithValue("@VFax", VIDCombo.Text);
            cmd.Parameters.AddWithValue("@VEmail", VIDCombo.Text);
            cmd.Parameters.AddWithValue("@VAddress", VIDCombo.Text);
            cmd.Parameters.AddWithValue("@CPPH", VIDCombo.Text);
            cmd.Parameters.AddWithValue("@CPName", VIDCombo.Text);
            cmd.Parameters.AddWithValue("@VStatus",VIDCombo.Text);

            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                VNameTB.Text = dr["VName"].ToString();
                VCodeTB.Text = dr["VCode"].ToString();
                VCityTB.Text = dr["VCity"].ToString();
                VDeptTB.Text = dr["VGroup"].ToString();
                VPh1TB.Text = dr["PH1"].ToString();
                VPh2TB.Text = dr["PH2"].ToString();
                VAddressTB.Text = dr["VAddress"].ToString();
                VFaxTB.Text = dr["VFax"].ToString();
                VMailTB.Text = dr["VEmail"].ToString();
                VCPNameTB.Text = dr["CPName"].ToString();
                VCPphTB.Text = dr["CPPH"].ToString();
                VStatusTB.Text = dr["VStatus"].ToString();
            }
            f2.oleDbConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VStatusTB.Text = "SFA";
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Update Vendor set VStatus = '" + VStatusTB.Text + "' where VID = @VID",f2.oleDbConnection1);
            cmd.Parameters.AddWithValue("@VID", VIDCombo.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully sent for approval !", "SFA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            f2.oleDbConnection1.Close();

            ApproveBtn.Visible = true;
            DisapproveBtn.Visible = true;
            button2.Visible = false;
        }

      
        private void ApproveBtn_Click(object sender, EventArgs e)
        {
            VStatusTB.Text = "ACTIVE";
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Update Vendor set VStatus = '" + VStatusTB.Text + "' where VID = @VID", f2.oleDbConnection1);
            cmd.Parameters.AddWithValue("@VID", VIDCombo.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Vendor Approved !","Approval",MessageBoxButtons.OK,MessageBoxIcon.Information);
            f2.oleDbConnection1.Close();
        }

        private void DisapproveBtn_Click(object sender, EventArgs e)
        {
            VStatusTB.Text = "INACTIVE";
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Update Vendor set VStatus = '" + VStatusTB.Text + "' where VID = @VID", f2.oleDbConnection1);
            cmd.Parameters.AddWithValue("@VID", VIDCombo.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Vendor Disapproved !", "Approval", MessageBoxButtons.OK, MessageBoxIcon.Information);
            f2.oleDbConnection1.Close();
        }

    }
}
