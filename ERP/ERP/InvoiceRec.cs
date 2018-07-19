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
    public partial class InvoiceRec : Form
    {
        My_Conn f2 = new My_Conn();
        int count = 0;
        public InvoiceRec()
        {
            InitializeComponent();
        }

        private void InvoiceRec_Load(object sender, EventArgs e)
        {
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = Color.Wheat;
            this.ControlBox = false;
            CreateBTN.BackColor = Color.SaddleBrown;
            CreateBTN.ForeColor = Color.White;
            CreateBTN.Cursor = Cursors.Hand;
            CreateBTN.FlatStyle = FlatStyle.Popup;
            DCCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            InvoicePB1.BackColor = Color.SaddleBrown;
            InvoicePB2.BackColor = Color.SaddleBrown;
            CUID.Visible = false;
            CPph.Visible = false;
            CIDTB.Visible = false;
            CPphTB.Visible = false;
            InvoiceNoTB.ReadOnly = true;
            DCDateTB.ReadOnly = true;
            CNameTB.ReadOnly = true;
            AmountTB.ReadOnly = true;
            DetailTB.ReadOnly = true;
            CPphTB.ReadOnly = true;
            CPNameTB.ReadOnly = true;
            CreateBTN.Enabled = false;

            f2.oleDbConnection1.Open();

            OleDbCommand cmd = new OleDbCommand("Select  DCID from DChalan", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DCCombo.Items.Add(dr["DCID"]).ToString();
            }

            OleDbCommand cmd1 = new OleDbCommand("Select count (IRID) from InvoiceSO", f2.oleDbConnection1);

            OleDbDataReader dr1 = cmd1.ExecuteReader();

            if (dr1.Read())
            {
                count = Convert.ToInt32(dr1[0]);
                count++;
            }

            InvoiceNoTB.Text = count.ToString();

            f2.oleDbConnection1.Close();
        }

        private void DCCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();

            OleDbCommand cmd = new OleDbCommand("Select * from DChalan where DCID = @DCID", f2.oleDbConnection1);
            cmd.Parameters.AddWithValue("@DDate", DCCombo.Text);
            cmd.Parameters.AddWithValue("@CName", DCCombo.Text);
            cmd.Parameters.AddWithValue("@TotalAmount", DCCombo.Text);
            cmd.Parameters.AddWithValue("@DCDate", DCCombo.Text);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                CNameTB.Text = dr["CName"].ToString();
                SODateTB.Text = dr["DDate"].ToString();
                AmountTB.Text = dr["TotalAmount"].ToString();
                DCDateTB.Text = dr["DCDate"].ToString();
            }

            OleDbCommand cmd2 = new OleDbCommand("Select * from Customer where CName = @CName", f2.oleDbConnection1);
            cmd2.Parameters.AddWithValue("@CPPH", CNameTB.Text);
            cmd2.Parameters.AddWithValue("@CCPName", CNameTB.Text);
            cmd2.Parameters.AddWithValue("@CID", CNameTB.Text);
            OleDbDataReader dr2 = cmd2.ExecuteReader();

            if (dr2.Read())
            {
                CIDTB.Text = dr2["CID"].ToString();
                CPphTB.Text = dr2["CPPH"].ToString();
                CPNameTB.Text = dr2["CCPName"].ToString();
            }

            OleDbCommand cmd3 = new OleDbCommand("Select * from SO where DDate = @DDate", f2.oleDbConnection1);
            cmd3.Parameters.AddWithValue("@TotalAmount", SODateTB.Text);

            OleDbDataReader dr3 = cmd3.ExecuteReader();

            if (dr3.Read())
            {
                AmountTB.Text = dr3["TotalAmount"].ToString();
            }

            OleDbCommand cmmd = new OleDbCommand("Select * from DCProduct where DCID = @DCID ", f2.oleDbConnection1);
            cmmd.Parameters.AddWithValue("@PModel", DCCombo.Text);
            cmmd.Parameters.AddWithValue("@PQty", DCCombo.Text);
            OleDbDataReader drr = cmmd.ExecuteReader();

            if (drr.Read())
            {
                PModelTB.Text = drr["PModel"].ToString();
                PQuantityTB.Text = drr["PQty"].ToString();
            }
            DetailTB.Text += InvoiceNo.Text + InvoiceNoTB.Text + Environment.NewLine;
            DetailTB.Text += DCNo.Text + DCCombo.Text + Environment.NewLine;
            DetailTB.Text += DCDate.Text + DCDateTB.Text + Environment.NewLine;
            DetailTB.Text += InvoiceDate.Text + dateTimePicker2.Text + Environment.NewLine;
            DetailTB.Text += CName.Text + CNameTB.Text + Environment.NewLine;
            DetailTB.Text += CPName.Text + CPNameTB.Text + Environment.NewLine;
            DetailTB.Text += PModel.Text + PModelTB.Text + Environment.NewLine;
            DetailTB.Text += PQuantity.Text + PQuantityTB.Text + Environment.NewLine;
            DetailTB.Text += Amount.Text + AmountTB.Text + Environment.NewLine;

            f2.oleDbConnection1.Close();
            CreateBTN.Enabled = true;
        }

        private void CreateBTN_Click(object sender, EventArgs e)
        {

            f2.oleDbConnection1.Open();

            // Insertion in Invoice
            OleDbCommand cmd = new OleDbCommand("Insert into InvoiceSO (IRID,CID,DCID,CName,SODate,DCDate,IRDate,CPPH,CPName,AmountRecievable) values (@IRID,@CID,@DCID,@CName,@SODate,@DCDate,@IRDate,@CPPH,@CPName,@AmountRecievable)", f2.oleDbConnection1);

            cmd.Parameters.AddWithValue("@InvoiceID", InvoiceNoTB.Text);
            cmd.Parameters.AddWithValue("@CID", CIDTB.Text);
            cmd.Parameters.AddWithValue("@DCID", DCCombo.Text);
            cmd.Parameters.AddWithValue("@CName", CNameTB.Text);
            cmd.Parameters.AddWithValue("@PODate", SODateTB.Text);
            cmd.Parameters.AddWithValue("@DCDate", DCDateTB.Text);
            cmd.Parameters.AddWithValue("@IRDate", dateTimePicker2.Text);
            cmd.Parameters.AddWithValue("@CPPH", CPphTB.Text);
            cmd.Parameters.AddWithValue("@CPName", CPNameTB.Text);
            cmd.Parameters.AddWithValue("@AmountRecievable", AmountTB.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Invoice has been created");
            f2.oleDbConnection1.Close();
        }
    }
}
