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
    public partial class Form1 : Form
    {
        My_Conn f2 = new My_Conn();
        int count, counter = 0;// price = 0,a;
        string[] PM = new string[20];
        int[] PQ = new int[20];
        int[] PPrice = new int[100];

        public Form1()
        {
            InitializeComponent();
        }
        //My_Conn f2 = new My_Conn();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.ShowIcon = false;
            this.BackColor = Color.Wheat;
            POPB1.BackColor = Color.SaddleBrown;
            POPB2.BackColor = Color.SaddleBrown;

            AddBtn.Enabled = false;
            Createbtn.Enabled = false;

            DeptName.Text = "Select Department : ";
            POID.Text = "Purchase Order No : ";
            VID.Text = "Vendor ID : ";
            VName.Text = "Vendor Name : ";
            VCPName.Text = "Contact Person : ";
            VCPPh.Text = "Contact Number : ";
            SelectVendor.Text = "Select Department";
            VendorInfo.Text = "Vendor Information";
            ProductInfo.Text = "Products Information ";
            PModel.Text = "Product ID : ";
            PQuantity.Text = "Product Quantity : ";
            PODate.Text = "Purchase Order Date : ";
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
            POIDTB.ReadOnly = true;
            VNameTB.ReadOnly = true;
            VCPNameTB.ReadOnly = true;
            VCPphTB.ReadOnly = true;
            VIDCombo.Enabled = false;
            PCombo.Enabled = false;
            TotalTB.ReadOnly = true;
            UnitPriceTB.ReadOnly = true;
            DetailTB.ReadOnly = true;
            DeptCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            PCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            VIDCombo.DropDownStyle = ComboBoxStyle.DropDownList;


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
            VIDCombo.Enabled = true;
            PCombo.Enabled = true;
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select count (POID) from PO where VDept = @VDept", f2.oleDbConnection1);
            cmd.Parameters.AddWithValue("@VDept", DeptCombo.Text);


            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                count = Convert.ToInt32(dr[0]);

            }
            count += 1;
            POIDTB.Text = DeptCombo.Text + "-00" + count.ToString() + "-" + System.DateTime.Today.Year;

            //VendorID Combo
            OleDbCommand cmmd = new OleDbCommand("Select VID from Vendor where VGroup = @VGroup and VStatus = 'ACTIVE'", f2.oleDbConnection1);
            cmmd.Parameters.AddWithValue("@VGroup", DeptCombo.Text);
            OleDbDataReader drr = cmmd.ExecuteReader();
            VIDCombo.Items.Clear();

            while (drr.Read())
            {
                VIDCombo.Items.Add(drr["VID"]).ToString();
            }

            f2.oleDbConnection1.Close();
        }

        private void VIDCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from Vendor where VID = @VID", f2.oleDbConnection1);

            cmd.Parameters.AddWithValue("@VName", VIDCombo.Text);
            cmd.Parameters.AddWithValue("@VCPName", VIDCombo.Text);
            cmd.Parameters.AddWithValue("@CPPH", VIDCombo.Text);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                VNameTB.Text = dr["VName"].ToString();
                VCPNameTB.Text = dr["CPName"].ToString();
                VCPphTB.Text = dr["CPPH"].ToString();
            }
            f2.oleDbConnection1.Close();
        }


        private void PCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from Products where Pid = @Pid", f2.oleDbConnection1);
            cmd.Parameters.AddWithValue("@Pid", PCombo.Text);
            cmd.Parameters.AddWithValue("@Pid", PCombo.Text);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                PNameTB.Text = dr["PName"].ToString();
                UnitPriceTB.Text = dr["PPrice"].ToString();
            }


            //OleDbCommand cmmd = new OleDbCommand("Select * from Products where pid = @Pid", f2.oleDbConnection1);
            //cmmd.Parameters.AddWithValue("@Pid", PCombo.Text);
            //OleDbDataReader drr = cmmd.ExecuteReader();

            //if (drr.Read())
            //{
            //    UnitPriceTB.Text = drr["PPrice"].ToString();
            //}
            f2.oleDbConnection1.Close();
          
            }
    
        private void ADDbutton_Click(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();

            int tp = 0;
            PM[counter] = PCombo.Text;
            PQ[counter] = Convert.ToInt32(PQuantityTB.Text);
            PPrice[counter] = Convert.ToInt32(PQuantityTB.Text) * Convert.ToInt32(UnitPriceTB.Text);
             tp = Convert.ToInt32(PPrice[counter]);
            counter++;
            TotalTB.Text = tp.ToString();


            //OleDbCommand cmd = new OleDbCommand("Select * from POProducts", f2.oleDbConnection1);
            //OleDbDataReader dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //dataGridView1.DataSource = dt;
            //dataGridView1.Refresh();
            //dataGridView1.Update();

            DetailTB.Text += POID.Text + POIDTB.Text + Environment.NewLine;
            DetailTB.Text += VID.Text + VIDCombo.Text + Environment.NewLine;
            DetailTB.Text += VName.Text + VNameTB.Text + Environment.NewLine;
            DetailTB.Text += PModel.Text + PCombo.Text + Environment.NewLine;
            DetailTB.Text += PName.Text + PNameTB.Text + Environment.NewLine;
            DetailTB.Text += UnitPrice.Text + UnitPriceTB.Text + Environment.NewLine;
            DetailTB.Text += PQuantity.Text + PQuantityTB.Text + Environment.NewLine;
            DetailTB.Text += Total.Text + TotalTB.Text + Environment.NewLine;


            f2.oleDbConnection1.Close();
        }

        private void CreateButton(object sender, EventArgs e)
        {

            f2.oleDbConnection1.Open();

            //foreach (int p in PPrice)
            //{
            //    price += Convert.ToInt32(p);
            //}

            OleDbCommand cmd = new OleDbCommand("Insert into PO (POID,VDept,PODate,VID,VName,VCPName,VCPPH,TotalAmount,DDate) values (@POID,@VDept,@PODate,@VID,@VName,@VCPName,@VCPPH,@TotalAmount,@DDate)", f2.oleDbConnection1);

            cmd.Parameters.AddWithValue("@POID", POIDTB.Text);
            cmd.Parameters.AddWithValue("@VDept", DeptCombo.Text);
            cmd.Parameters.AddWithValue("@PODate", dateTimePicker1);
            cmd.Parameters.AddWithValue("@VID", VIDCombo.Text);
            cmd.Parameters.AddWithValue("@VName", VNameTB.Text);
            cmd.Parameters.AddWithValue("@VCPName", VCPNameTB.Text);
            cmd.Parameters.AddWithValue("@VCPPH", VCPphTB.Text);
            cmd.Parameters.AddWithValue("@TotalAmount", TotalTB.Text);
            cmd.Parameters.AddWithValue("@DDate", dateTimePicker1);

            cmd.ExecuteNonQuery();
            try {
                for (int i = 0; i < counter; i++)
                {
                    //Insertion of Products
                    OleDbCommand cmmd = new OleDbCommand("Insert into POProducts(POID,Pid,PQty,PName,PPrice) values (@POID,@Pid,@PQty,@PName,@PPrice)", f2.oleDbConnection1);
                    cmmd.Parameters.AddWithValue("@POID", POIDTB.Text);
                    cmmd.Parameters.AddWithValue("@Pid", PM[i]);
                    cmmd.Parameters.AddWithValue("@PQty", PQ[i]);
                    cmmd.Parameters.AddWithValue("@PName", PNameTB.Text);
                    cmmd.Parameters.AddWithValue("@PPrice", PPrice[i]);

                    cmmd.ExecuteNonQuery();
                    MessageBox.Show("Transiction has been done !!", "Purchase Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } }
            catch (Exception ee)
            {
                MessageBox.Show("Error"+ee);
                f2.oleDbConnection1.Close();
                
            } }

        private void PQuantityTB_TextChanged(object sender, EventArgs e)
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

        private void PQuantityTB_KeyPress_1(object sender, KeyPressEventArgs e)
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
