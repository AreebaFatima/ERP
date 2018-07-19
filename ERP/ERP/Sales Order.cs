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
    public partial class Sales_Order : Form
    {
        My_Conn f2 = new My_Conn();
        int count, counter = 0;
        string[] PM = new string[20];
        int[] PQ = new int[20];
        int[] PPrice = new int[100];
        public Sales_Order()
        {
            InitializeComponent();
        }

        private void Sales_Order_Load(object sender, EventArgs e)
        {

            this.ControlBox = false;
            this.ShowIcon = false;
            this.BackColor = Color.Wheat;
            SOPB1.BackColor = Color.SaddleBrown;
            SOPB2.BackColor = Color.SaddleBrown;

            AddBtn.Enabled = false;
            Createbtn.Enabled = false;

            DeptName.Text = "Select Department : ";
            SOID.Text = "Sales Order No : ";
            CID.Text = "Customer ID : ";
            CName.Text = "Customer Name : ";
            CCPName.Text = "Contact Person : ";
            CCPPh.Text = "Contact Number : ";
            SelectCustomer.Text = "Select Department";
            CustomerInfo.Text = "Customer Information";
            ProductInfo.Text = "Products Information ";
            PModel.Text = "Product ID : ";
            PQuantity.Text = "Product Quantity : ";
            PODate.Text = "Sales Order Date : ";
            PName.Text = "Product Name : ";
            Createbtn.Text = "Create Order";
            AddBtn.Text = "Add Products";
            Createbtn.BackColor = Color.SaddleBrown;
            Createbtn.ForeColor = Color.White;
            AddBtn.BackColor = Color.SaddleBrown;
            AddBtn.ForeColor = Color.White;
            Createbtn.Cursor = Cursors.Hand;
            AddBtn.Cursor = Cursors.Hand;
            Createbtn.FlatStyle = FlatStyle.Popup;
            AddBtn.FlatStyle = FlatStyle.Popup;
            PNameTB.ReadOnly = true;
            SOIDTB.ReadOnly = true;
            CNameTB.ReadOnly = true;
            CCPNameTB.ReadOnly = true;
            CCPphTB.ReadOnly = true;
            CIDCombo.Enabled = false;
            PCombo.Enabled = false;
            TotalTB.ReadOnly = true;
            UnitPriceTB.ReadOnly = true;
            DetailTB.ReadOnly = true;
            DeptCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            PCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            CIDCombo.DropDownStyle = ComboBoxStyle.DropDownList;


            f2.oleDbConnection1.Open();

            //Department Combo
            OleDbCommand cmd = new OleDbCommand("Select  deptname from Dept", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DeptCombo.Items.Add(dr["deptname"]).ToString();
            }


            // Items Combo
            OleDbCommand cmdd = new OleDbCommand("Select Pid from Products", f2.oleDbConnection1);
            OleDbDataReader dri = cmdd.ExecuteReader();

            while (dri.Read())
            {
                PCombo.Items.Add(dri["Pid"]);
            }

            f2.oleDbConnection1.Close();
        }
        private void DeptCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CIDCombo.Enabled = true;
            PCombo.Enabled = true;
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select count (SOID) from SO where CDept = @CDept", f2.oleDbConnection1);
            cmd.Parameters.AddWithValue("@CDept", DeptCombo.Text);


            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                count = Convert.ToInt32(dr[0]);

            }
            count += 1;
            SOIDTB.Text = DeptCombo.Text + "-00" + count.ToString() + "-" + System.DateTime.Today.Year;

            //VendorID Combo
            OleDbCommand cmmd = new OleDbCommand("Select CID from Customer where CGroup = @CGroup and CStatus = 'ACTIVE'", f2.oleDbConnection1);
            cmmd.Parameters.AddWithValue("@CGroup", DeptCombo.Text);
            OleDbDataReader drr = cmmd.ExecuteReader();
            CIDCombo.Items.Clear();

            while (drr.Read())
            {
                CIDCombo.Items.Add(drr["CID"]).ToString();
            }

            f2.oleDbConnection1.Close();
        }

        private void CIDCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from Customer where CID = @CID", f2.oleDbConnection1);

            cmd.Parameters.AddWithValue("@CName", CIDCombo.Text);
            cmd.Parameters.AddWithValue("@CCPName", CIDCombo.Text);
            cmd.Parameters.AddWithValue("@CPPH", CIDCombo.Text);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                CNameTB.Text = dr["CName"].ToString();
                CCPNameTB.Text = dr["CCPName"].ToString();
                CCPphTB.Text = dr["CPPH"].ToString();
            }
            f2.oleDbConnection1.Close();
        }
        private void PCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from Products where Pid = @Pid", f2.oleDbConnection1);
            cmd.Parameters.AddWithValue("@Pid", PCombo.Text);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                PNameTB.Text = dr["PName"].ToString();
            }


            OleDbCommand cmmd = new OleDbCommand("Select * from Products where Pid = @Pid", f2.oleDbConnection1);
            cmmd.Parameters.AddWithValue("@Pid", PCombo.Text);
            OleDbDataReader drr = cmmd.ExecuteReader();

            if (drr.Read())
            {
                UnitPriceTB.Text = drr["PPrice"].ToString();
            }
            f2.oleDbConnection1.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            f2.oleDbConnection1.Open();

            int tp = 0;
            PM[counter] = PCombo.Text;
            PQ[counter] = Convert.ToInt32(PQuantityTB.Text);
            PPrice[counter] = Convert.ToInt32(PQuantityTB.Text) * Convert.ToInt32(UnitPriceTB.Text);
            tp = Convert.ToInt32(PPrice[counter]);
            counter++;
            TotalTB.Text = tp.ToString();

            DetailTB.Text += SOID.Text + SOIDTB.Text + Environment.NewLine;
            DetailTB.Text += CID.Text + CIDCombo.Text + Environment.NewLine;
            DetailTB.Text += CName.Text + CNameTB.Text + Environment.NewLine;
            DetailTB.Text += PModel.Text + PCombo.Text + Environment.NewLine;
            DetailTB.Text += PName.Text + PNameTB.Text + Environment.NewLine;
            DetailTB.Text += UnitPrice.Text + UnitPriceTB.Text + Environment.NewLine;
            DetailTB.Text += PQuantity.Text + PQuantityTB.Text + Environment.NewLine;
            DetailTB.Text += Total.Text + TotalTB.Text + Environment.NewLine;


            f2.oleDbConnection1.Close();
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();


            OleDbCommand cmd = new OleDbCommand("Insert into SO (SOID,CDept,SODate,CID,CName,CCPName,CPPH,TotalAmount,DDate) values (@SOID,@CDept,@SODate,@CID,@CName,@CCPName,@CPPH,@TotalAmount,@DDate)", f2.oleDbConnection1);

            cmd.Parameters.AddWithValue("@SOID", SOIDTB.Text);
            cmd.Parameters.AddWithValue("@CDept", DeptCombo.Text);
            cmd.Parameters.AddWithValue("@SODate", dateTimePicker1);
            cmd.Parameters.AddWithValue("@CID", CIDCombo.Text);
            cmd.Parameters.AddWithValue("@CName", CNameTB.Text);
            cmd.Parameters.AddWithValue("@CCPName", CCPNameTB.Text);
            cmd.Parameters.AddWithValue("@CPPH", CCPphTB.Text);
            cmd.Parameters.AddWithValue("@TotalAmount", TotalTB.Text);
            cmd.Parameters.AddWithValue("@DDate", dateTimePicker1);

            cmd.ExecuteNonQuery();
            try
            {
                for (int i = 0; i < counter; i++)
                {
                    //Insertion of Products
                    OleDbCommand cmmd = new OleDbCommand("Insert into SOProduct(SOID,Pid,PQty,PName,PPrice) values (@SOID,@Pid,@PQty,@PName,@PPrice)", f2.oleDbConnection1);
                    cmmd.Parameters.AddWithValue("@SOID", SOIDTB.Text);
                    cmmd.Parameters.AddWithValue("@Pid", PM[i]);
                    cmmd.Parameters.AddWithValue("@PQty", PQ[i]);
                    cmmd.Parameters.AddWithValue("@PName", PNameTB.Text);
                    cmmd.Parameters.AddWithValue("@PPrice", PPrice[i]);

                    cmmd.ExecuteNonQuery();
                    MessageBox.Show("Transiction has been done !!", "Sales Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error" + ee);
                f2.oleDbConnection1.Close();
            }
        }

        private void DetailTB_TextChanged(object sender, EventArgs e)
        {

            if (DetailTB.Text == "")
            {
                Createbtn.Enabled = false;
            }
            else
            {
                Createbtn.Enabled = true;
            }
        }

        private void PQuantityTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
            }
            else
            {
                e.Handled = true;

            }
        }

        private void PQuantityTB_TextChanged_1(object sender, EventArgs e)
        {
            if (PQuantityTB.Text == "")
            {
                AddBtn.Enabled = false;
            }
            else
            {
                AddBtn.Enabled = true;
            }
        }

        }
    }

