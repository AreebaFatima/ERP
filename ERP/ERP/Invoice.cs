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
    public partial class Invoice : Form
    {
        My_Conn f2 = new My_Conn();
        int count = 0;
        public Invoice()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = Color.Wheat;
            this.ControlBox = false;
            CreateBTN.BackColor = Color.SaddleBrown;
            CreateBTN.ForeColor = Color.White;
            CreateBTN.Cursor = Cursors.Hand;
            CreateBTN.FlatStyle = FlatStyle.Popup;
            GRNCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            InvoicePB1.BackColor = Color.SaddleBrown;
            InvoicePB2.BackColor = Color.SaddleBrown;
            VIDTB.Visible = false;
            CPphTB.Visible = false;
            InvoiceNoTB.ReadOnly = true;
            GRNDateTB.ReadOnly = true;
            VNameTB.ReadOnly = true;
            AmountTB.ReadOnly = true;
            DetailTB.ReadOnly = true;
            CPphTB.ReadOnly = true;
            CPNameTB.ReadOnly = true;
            CreateBTN.Enabled = false;

            f2.oleDbConnection1.Open();
              
            OleDbCommand cmd = new OleDbCommand("Select  GRNID from GRN", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                GRNCombo.Items.Add(dr["GRNID"]).ToString();
            }

            OleDbCommand cmd1 = new OleDbCommand("Select count (InvoiceID) from Invoice", f2.oleDbConnection1);

            OleDbDataReader dr1 = cmd1.ExecuteReader();

            if (dr1.Read())
            {
                count = Convert.ToInt32(dr1[0]);
                count ++;
            }

            InvoiceNoTB.Text = count.ToString();

            f2.oleDbConnection1.Close();
        }

        private void GRNCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();

            OleDbCommand cmd = new OleDbCommand("Select * from GRN where GRNID = @GRNID", f2.oleDbConnection1);
            cmd.Parameters.AddWithValue("@DDate", GRNCombo.Text);
            cmd.Parameters.AddWithValue("@VName", GRNCombo.Text);
            cmd.Parameters.AddWithValue("@TotalAmount", GRNCombo.Text);
            cmd.Parameters.AddWithValue("@GRDate",GRNCombo.Text);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                VNameTB.Text = dr["VName"].ToString();
                PODateTB.Text = dr["DDate"].ToString();
                AmountTB.Text = dr["TotalAmount"].ToString();
                GRNDateTB.Text = dr["GRDate"].ToString();
            }

            OleDbCommand cmd2 = new OleDbCommand("Select * from Vendor where VName = @VName", f2.oleDbConnection1);
            cmd2.Parameters.AddWithValue("@CPPH", VNameTB.Text);
            cmd2.Parameters.AddWithValue("@CPName", VNameTB.Text);
            cmd2.Parameters.AddWithValue("@VID", VNameTB.Text);
            OleDbDataReader dr2 = cmd2.ExecuteReader();

            if (dr2.Read())
            {
                VIDTB.Text = dr2["VID"].ToString();
               CPphTB.Text = dr2["CPPH"].ToString();
               CPNameTB.Text = dr2["CPName"].ToString();
            }

            OleDbCommand cmd3 = new OleDbCommand("Select * from PO where DDate = @DDate", f2.oleDbConnection1);
            cmd3.Parameters.AddWithValue("@TotalAmount", PODateTB.Text);
       
            OleDbDataReader dr3 = cmd3.ExecuteReader();

            if (dr3.Read())
            {
                AmountTB.Text = dr3["TotalAmount"].ToString();
            }

            OleDbCommand cmmd = new OleDbCommand("Select * from GRNProducts where GRNID = @GRNID ", f2.oleDbConnection1);
            cmmd.Parameters.AddWithValue("@PModel", GRNCombo.Text);
            cmmd.Parameters.AddWithValue("@PQty", GRNCombo.Text);
            OleDbDataReader drr = cmmd.ExecuteReader();

            if (drr.Read())
            {
               PModelTB .Text = drr["PModel"].ToString();
               PQuantityTB.Text = drr["PQty"].ToString();
            }
            DetailTB.Text += InvoiceNo.Text + InvoiceNoTB.Text + Environment.NewLine;
            DetailTB.Text += GRNno.Text + GRNCombo.Text + Environment.NewLine;
            DetailTB.Text += GRNDate.Text + GRNDateTB.Text + Environment.NewLine;
            DetailTB.Text += InvoiceDate.Text + dateTimePicker2.Text + Environment.NewLine;
            DetailTB.Text += VName.Text + VNameTB.Text + Environment.NewLine;
            DetailTB.Text += CPName.Text + CPNameTB.Text + Environment.NewLine;
            DetailTB.Text += PModel.Text + PModelTB.Text + Environment.NewLine;
            DetailTB.Text += PQuantity.Text + PQuantityTB.Text + Environment.NewLine;
            DetailTB.Text += Amount.Text + AmountTB.Text + Environment.NewLine;

            f2.oleDbConnection1.Close();
            CreateBTN.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();

            // Insertion in Invoice
            OleDbCommand cmd = new OleDbCommand("Insert into Invoice (InvoiceID,VendorID,GRNID,VendorName,DCDate,GRNDate,CDate,CPPH,ContactPerson,AmountPayable) values (@InvoiceID,@VendorID,@GRNID,@VendorName,@DCDate,@GRNDate,@CDate,@CPPH,@ContactPerson,@AmountPayable)", f2.oleDbConnection1);

            cmd.Parameters.AddWithValue("@InvoiceID", InvoiceNoTB.Text);
            cmd.Parameters.AddWithValue("@VendorID", VIDTB.Text);
            cmd.Parameters.AddWithValue("@GRNID", GRNCombo.Text);
            cmd.Parameters.AddWithValue("@VendorName", VNameTB.Text);
            cmd.Parameters.AddWithValue("@DCDate", PODateTB.Text);
            cmd.Parameters.AddWithValue("@GRNDate", GRNDateTB.Text );
            cmd.Parameters.AddWithValue("@CDate", dateTimePicker2.Text);
            cmd.Parameters.AddWithValue("@CPPH", CPphTB.Text);
            cmd.Parameters.AddWithValue("@ContactPerson", CPNameTB.Text);
            cmd.Parameters.AddWithValue("@AmountPayable", AmountTB.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Invoice has been created");
            f2.oleDbConnection1.Close();
        }
    }
}
