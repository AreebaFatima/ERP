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
    public partial class Customer : Form
    {
        My_Conn f2 = new My_Conn();
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.BackColor = Color.Wheat;
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.Manual;
            CSPB1.BackColor = Color.SaddleBrown;
            CSPB2.BackColor = Color.SaddleBrown;
            CIDCombo.DropDownStyle = ComboBoxStyle.DropDownList;
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
            f2.oleDbConnection1.Close();
        }
    }
}
