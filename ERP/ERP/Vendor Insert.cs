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
    public partial class Vendor_Insert : Form
    {
        My_Conn f2 = new My_Conn();
        int count = 0;
        public Vendor_Insert()
        {
            InitializeComponent();
        }

        private void Vendor_Insert_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = Color.Wheat;
            this.ControlBox = false;
            this.ShowIcon = false;
            
            NewPB1.BackColor = Color.SaddleBrown;
            NewPB2.BackColor = Color.SaddleBrown;
            button1.BackColor = Color.SaddleBrown;
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Cursor = Cursors.Hand;
            VIDTB.ReadOnly = true;

            f2.oleDbConnection1.Open();

            OleDbCommand cmd = new OleDbCommand("Select count (VID) from Vendor", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            { 
                count = Convert.ToInt32(dr[0]);
                count++;
            }
            VIDTB.Text = "0" + count.ToString();

            f2.oleDbConnection1.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();

            OleDbCommand cmd = new OleDbCommand("Insert into Vendor (VID,VName,VCode,VGroup,PH1,PH2,VEmail,VFax,VAddress,CPPH,CPName,VStatus) values (@VID,@VName,@VCode,@VCity,@VGroup,@PH1,@PH2,@VFax,@VEmail,@VAddress,@CPPH,@CPName,@VStatus)",f2.oleDbConnection1);
            cmd.Parameters.AddWithValue("@VID",VIDTB.Text);
            cmd.Parameters.AddWithValue("@VName", VNameTB.Text);
            cmd.Parameters.AddWithValue("@VCode", VCodeTB.Text);
            cmd.Parameters.AddWithValue("@VCity", VCityTB.Text);
            cmd.Parameters.AddWithValue("@VGroup", VDeptTB.Text);
            cmd.Parameters.AddWithValue("@PH1", VPh1TB.Text);
            cmd.Parameters.AddWithValue("@PH2", VPh2TB.Text);
            cmd.Parameters.AddWithValue("@VFax", VFaxTB.Text);
            cmd.Parameters.AddWithValue("@VEmail", VMailTB.Text);
            cmd.Parameters.AddWithValue("@VAddress", VAddressTB.Text);
            cmd.Parameters.AddWithValue("@CPPH", VCPphTB.Text);
            cmd.Parameters.AddWithValue("@CPName", VCPNameTB.Text);
            cmd.Parameters.AddWithValue("@VStatus", VStatusTB.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Record has been inserted","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            f2.oleDbConnection1.Close();
        }

        private void VPh1TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void VPh2TB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void VCPphTB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
