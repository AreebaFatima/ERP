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
    public partial class New_Customer : Form
    {
        My_Conn f2 = new My_Conn();
        int count = 0;
        public New_Customer()
        {
            InitializeComponent();
        }

        private void New_Customer_Load(object sender, EventArgs e)
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
            CIDTB.ReadOnly = true;

            f2.oleDbConnection1.Open();

            OleDbCommand cmd = new OleDbCommand("Select count (CID) from Customer", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                count = Convert.ToInt32(dr[0]);
                count++;
            }
            CIDTB.Text = "0" + count.ToString();

            f2.oleDbConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            f2.oleDbConnection1.Open();

            OleDbCommand cmd = new OleDbCommand("Insert into Customer (CID,CName,CGroup,PH1,PH2,CEmail,CreditLimit,City,CAddress,CPPH,CCPName,CStatus) values (@CID,@CName,@CGroup,@PH1,@PH2,@CreditLimit,@CEmail,@CAddress,@CPPH,@CCPName,@CStatus)", f2.oleDbConnection1);
            cmd.Parameters.AddWithValue("@CID", CIDTB.Text);
            cmd.Parameters.AddWithValue("@CStatus", CStatusTB.Text);
            cmd.Parameters.AddWithValue("@CName", CNameTB.Text);
            cmd.Parameters.AddWithValue("@CGroup", CDeptTB.Text);
            cmd.Parameters.AddWithValue("@City", CCityTB.Text);
            cmd.Parameters.AddWithValue("@CAddress", CAddressTB.Text);
            cmd.Parameters.AddWithValue("@PH1", CustomerPh1TB.Text);
            cmd.Parameters.AddWithValue("@PH2", CustomerPh2TB.Text);
            cmd.Parameters.AddWithValue("@CreditLimit", CLimitTB.Text);
            cmd.Parameters.AddWithValue("@CEmail", CMailTB.Text);
            cmd.Parameters.AddWithValue("@CCPName", CCPNameTB.Text);
            cmd.Parameters.AddWithValue("@CPPH", CCPphTB.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Record has been inserted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            f2.oleDbConnection1.Close();
        }

        private void CustomerPh1TB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void CustomerPh2TB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void CCPphTB_KeyPress(object sender, KeyPressEventArgs e)
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
