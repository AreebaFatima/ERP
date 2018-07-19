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
    public partial class Vendor_Search : Form
    {
        My_Conn f2 = new My_Conn();
        public Vendor_Search()
        {
            InitializeComponent();
        }

        private void Vendor_Search_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.BackColor = Color.Wheat;
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.Manual;
            SearchPB1.BackColor = Color.SaddleBrown;
            SearchPB2.BackColor = Color.SaddleBrown;
            VIDCombo.DropDownStyle = ComboBoxStyle.DropDownList;
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
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from Vendor where VID = @VID", f2.oleDbConnection1);
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
            cmd.Parameters.AddWithValue("@VStatus", VIDCombo.Text);

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

    }
}
