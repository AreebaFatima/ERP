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
    public partial class Login : Form
    {
        My_Conn f2 = new My_Conn();

        bool Action = false;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SignInBTN.Enabled = false;
            this.ShowIcon = false;
            this.BackColor = Color.Wheat;
            this.MaximizeBox= false;
            this.MinimizeBox = false;
            this.AcceptButton = SignInBTN;
            PasswordTB.Enabled = false;
            UsernameTB.Text = " Enter username ......";
            //PasswordTB.Text = " Enter password.....";
            UsernameTB.ForeColor = Color.Gray;
            PasswordTB.ForeColor = Color.Gray;
            SignInBTN.BackColor = Color.SaddleBrown;
            SignInBTN.ForeColor = Color.White;
            SignInBTN.FlatStyle = FlatStyle.Popup;
            SignInBTN.Cursor = Cursors.Hand;
            Exit.Cursor = Cursors.Hand;
            LogonPB1.BackColor = Color.SaddleBrown;
            LoginPB2.BackColor = Color.SaddleBrown;
        }

        private void UsernameTB_TextChanged(object sender, EventArgs e)
        {
            UsernameTB.ForeColor = Color.Black;
            PasswordTB.Enabled= true;
        }

        private void UsernameTB_Click(object sender, EventArgs e)
        {
            UsernameTB.Clear();
        }

        private void PasswordTB_Click(object sender, EventArgs e)
        {
            SignInBTN.Enabled = true;
            PasswordTB.Clear();
            PasswordTB.PasswordChar = '*';
            PasswordTB.MaxLength = 6;
        }

        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {
            PasswordTB.ForeColor = Color.Black;
            //SignInBTN.Enabled = true;
        }


        private bool uservalidation()
        {
            try
            {
                f2.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("Select * from Login where UserName = '" + UsernameTB.Text + "' and Password = '" + PasswordTB.Text + "'", f2.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    f2.oleDbConnection1.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Username and password is incorrect . Please Re-Enter..", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            f2.oleDbConnection1.Close();
            return false;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Action == false)
            {
                Application.Exit();
            }
        }
        private void SignInBTN_Click(object sender, EventArgs e)
        {
            if (uservalidation() == true)
            {
                Action = true;
                Startup start = new Startup();
                start.Show();
                this.Hide();
            }
            else
            {
                Action = false;
            }

            }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
   
