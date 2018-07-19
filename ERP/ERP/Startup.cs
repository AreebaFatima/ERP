using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class Startup : Form
    {
        Vendor_Search search = new Vendor_Search();
        Vendor add = new Vendor();
        Vendor_Insert insert = new Vendor_Insert();
        Form1 PO = new Form1();
        GRN grn = new GRN();
        Invoice invoice = new Invoice();
        Customer cr = new Customer();
        Add_Customer cdd = new Add_Customer();
        New_Customer newc = new New_Customer();
        Sales_Order so = new Sales_Order();
        Delievery_Chalan dc = new Delievery_Chalan();
        InvoiceRec ir = new InvoiceRec();
        public Startup()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = "Enterprice Resource Planing";
            //Login Login = new Login();
            //this.Hide();
            //Login.ShowDialog();
            //this.Show();

            this.BackColor = Color.Wheat;
            this.WindowState = FormWindowState.Maximized;
            pictureBox1.BackColor = Color.SaddleBrown;
            HomePanel.BackColor = Color.Wheat;
            WelcomePanel.BackColor = Color.Wheat;
            VMasterBTN.BackColor = Color.SaddleBrown;
            VMasterBTN.ForeColor = Color.White;
            VMasterBTN.FlatStyle = FlatStyle.Popup;
            VMasterBTN.Cursor = Cursors.Hand;
            CMasterBTN.BackColor = Color.SaddleBrown;
            CMasterBTN.ForeColor = Color.White;
            CMasterBTN.FlatStyle = FlatStyle.Popup;
            CMasterBTN.Cursor = Cursors.Hand;
            VendorBTN.BackColor = Color.SaddleBrown;
            VendorBTN.ForeColor = Color.White;
            VendorBTN.FlatStyle = FlatStyle.Popup;
            VendorBTN.Cursor = Cursors.Hand;
            PurchaseBTN.BackColor = Color.SaddleBrown;
            PurchaseBTN.ForeColor = Color.White;
            PurchaseBTN.FlatStyle = FlatStyle.Popup;
            PurchaseBTN.Cursor = Cursors.Hand;
            SearchBTN.BackColor = Color.SaddleBrown;
            SearchBTN.ForeColor = Color.White;
            SearchBTN.FlatStyle = FlatStyle.Popup;
            SearchBTN.Cursor = Cursors.Hand;
            AddBTN.BackColor = Color.SaddleBrown;
            AddBTN.ForeColor = Color.White;
            AddBTN.FlatStyle = FlatStyle.Popup;
            AddBTN.Cursor = Cursors.Hand;
            NewBTN.BackColor = Color.SaddleBrown;
            NewBTN.ForeColor = Color.White;
            NewBTN.FlatStyle = FlatStyle.Popup;
            NewBTN.Cursor = Cursors.Hand;
            POBTN.BackColor = Color.SaddleBrown;
            POBTN.ForeColor = Color.White;
            POBTN.FlatStyle = FlatStyle.Popup;
            POBTN.Cursor = Cursors.Hand;
            GRNBTN.BackColor = Color.SaddleBrown;
            GRNBTN.ForeColor = Color.White;
            GRNBTN.FlatStyle = FlatStyle.Popup;
            GRNBTN.Cursor = Cursors.Hand;
            InvoiceBTN.BackColor = Color.SaddleBrown;
            InvoiceBTN.ForeColor = Color.White;
            InvoiceBTN.FlatStyle = FlatStyle.Popup;
            InvoiceBTN.Cursor = Cursors.Hand;
            CustomersBTN.BackColor = Color.SaddleBrown;
            CustomersBTN.ForeColor = Color.White;
            CustomersBTN.FlatStyle = FlatStyle.Popup;
            CustomersBTN.Cursor = Cursors.Hand;
            SalesBTN.BackColor = Color.SaddleBrown;
            SalesBTN.ForeColor = Color.White;
            SalesBTN.FlatStyle = FlatStyle.Popup;
            SalesBTN.Cursor = Cursors.Hand;
            SearchCBTN.BackColor = Color.SaddleBrown;
            SearchCBTN.ForeColor = Color.White;
            SearchCBTN.FlatStyle = FlatStyle.Popup;
            SearchCBTN.Cursor = Cursors.Hand;
            AddCBTN.BackColor = Color.SaddleBrown;
            AddCBTN.ForeColor = Color.White;
            AddCBTN.FlatStyle = FlatStyle.Popup;
            AddCBTN.Cursor = Cursors.Hand;
            NewCBTN.BackColor = Color.SaddleBrown;
            NewCBTN.ForeColor = Color.White;
            NewCBTN.FlatStyle = FlatStyle.Popup;
            NewCBTN.Cursor = Cursors.Hand;
            SOBTN.BackColor = Color.SaddleBrown;
            SOBTN.ForeColor = Color.White;
            SOBTN.FlatStyle = FlatStyle.Popup;
            SOBTN.Cursor = Cursors.Hand;
            DCBTN.BackColor = Color.SaddleBrown;
            DCBTN.ForeColor = Color.White;
            DCBTN.FlatStyle = FlatStyle.Popup;
            DCBTN.Cursor = Cursors.Hand;
            IDCBTN.BackColor = Color.SaddleBrown;
            IDCBTN.ForeColor = Color.White;
            IDCBTN.FlatStyle = FlatStyle.Popup;
            IDCBTN.Cursor = Cursors.Hand;

            HomePB1.BackColor = Color.SaddleBrown;
            HomePB2.BackColor = Color.SaddleBrown;
            VMasterPB.BackColor = Color.SaddleBrown;

            VendorBTN.Visible = false;
            PurchaseBTN.Visible = false;
            CustomersBTN.Visible = false;
            SalesBTN.Visible = false;
            SearchBTN.Visible = false;
            AddBTN.Visible = false;
            NewBTN.Visible = false;
            POBTN.Visible = false;
            GRNBTN.Visible = false;
            InvoiceBTN.Visible = false;
            SearchCBTN.Visible = false;
            AddCBTN.Visible = false;
            NewCBTN.Visible = false;
            SOBTN.Visible = false;
            DCBTN.Visible = false;
            IDCBTN.Visible = false;

            VMasterPB.Visible = false;
            CMasterPB.Visible = false;
            VendorsPB.Visible = false;
            PurchasePB.Visible = false;
            SearchVPB.Visible = false;
            AddVPB.Visible = false;
            NewVPB.Visible = false;
            POPB.Visible = false;
            GRNPB.Visible = false;
            InvoicePB.Visible = false;
            CustomersPB.Visible = false;
            SearchCPB.Visible = false;
            AddCPB.Visible = false;
            NewCPB.Visible = false;
            SalesPB.Visible = false;
            SOPB.Visible = false;
            DCPB.Visible = false;
            IDCPB.Visible = false;

            //this.Hide();
            //Login lg = new Login();
            //lg.Show();
            //this.Show();

        }

        private void VMasterBTN_Click(object sender, EventArgs e)
        {
            VMasterPB.Visible = true;
            CMasterBTN.Visible = false;
            VendorBTN.Visible = true;
            PurchaseBTN.Visible = true;
        }

        private void VendorBTN_Click(object sender, EventArgs e)
        {
            VendorsPB.Visible = true;
            PurchaseBTN.Visible = false;
            POBTN.Visible = false;
            GRNBTN.Visible = false;
            InvoiceBTN.Visible = false;
            SearchBTN.Visible = true;
            AddBTN.Visible = true;
            NewBTN.Visible = true;
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            SearchVPB.Visible = true;
            AddVPB.Visible = false;
            NewVPB.Visible = false;
            insert.Hide();
            add.Hide();
            search.MdiParent = this;
            search.Text = "";
            search.Show();
            WelcomePanel.Hide();
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            SearchVPB.Visible = false;
            NewVPB.Visible = false;
            AddVPB.Visible = true;
            insert.Hide();
            search.Hide();
            add.MdiParent = this;
            add.Text = "";
            add.Show();
            WelcomePanel.Hide();
        }

        private void NewBTN_Click(object sender, EventArgs e)
        {
            NewVPB.Visible = true;
            SearchVPB.Visible = false;
            AddVPB.Visible = false;
            search.Hide();
            insert.Hide();
            insert.MdiParent = this;
            insert.Text = "";
            insert.Show();
            WelcomePanel.Hide();
        }
        private void PurchaseBTN_Click(object sender, EventArgs e)
        {
            PurchasePB.Visible = true;
            CMasterBTN.Visible = false;
            VendorBTN.Visible = false;
            AddBTN.Visible = false;
            NewBTN.Visible = false;
            SearchBTN.Visible = false;
            POBTN.Visible = true;
            GRNBTN.Visible = true;
            InvoiceBTN.Visible = true;
        }

        private void POBTN_Click(object sender, EventArgs e)
        {
            POPB.Visible = true;
            GRNPB.Visible = false;
            InvoicePB.Visible = false;

            PO.MdiParent = this;
            PO.Text = "";
            PO.Show();
            WelcomePanel.Hide();
        }

        private void GRNBTN_Click(object sender, EventArgs e)
        {
            GRNPB.Visible = true;
            POPB.Visible = false;
            InvoicePB.Visible = false;

            PO.Hide();
            invoice.Hide();
            grn.MdiParent = this;
            grn.Text = "";
            grn.Show();
            WelcomePanel.Hide();
        }

        private void InvoiceBTN_Click(object sender, EventArgs e)
        {
            InvoicePB.Visible = true;
            POPB.Visible = false;
            GRNPB.Visible = false;

            PO.Hide();
            grn.Hide();
            invoice.MdiParent = this;
            invoice.Text = "";
            invoice.Show();
            WelcomePanel.Hide();
        }

        private void CMasterBTN_Click(object sender, EventArgs e)
        {
            CMasterPB.Visible = true;
            VMasterBTN.Visible = false;
            VendorBTN.Visible = false;
            CustomersBTN.Visible = true;
            SalesBTN.Visible = true;
       }


        private void CustomersBTN_Click(object sender, EventArgs e)
        {
            CustomersPB.Visible = true;
            SalesBTN.Visible = false;
            SearchCBTN.Visible = true;
            AddCBTN.Visible = true;
            NewCBTN.Visible = true;
        }
        private void SearchCBTN_Click(object sender, EventArgs e)
        {
            SearchCPB.Visible = true;
            AddCPB.Visible = false;
            NewCPB.Visible = false;

            cdd.Hide();
            newc.Hide();
            cr.MdiParent = this;
            cr.Text = "";
            cr.Show();
            WelcomePanel.Hide();
        }

        private void AddCBTN_Click(object sender, EventArgs e)
        {
            AddCPB.Visible = true;
            SearchCPB.Visible = false;
            NewCPB.Visible = false;

            cr.Hide();
            newc.Hide();
            cdd.MdiParent = this;
            cdd.Text = "";
            cdd.Show();
            WelcomePanel.Hide();
        }

        private void NewCBTN_Click(object sender, EventArgs e)
        {
            NewCPB.Visible = true;
            AddCPB.Visible = false;
            SearchCPB.Visible = false;

            cr.Hide();
            cdd.Hide();
            newc.MdiParent = this;
            newc.Text = "";
            newc.Show();
            WelcomePanel.Hide();
        }

        private void SalesBTN_Click(object sender, EventArgs e)
        {
            SalesPB.Visible = true;
            CustomersBTN.Visible = false;
            SOBTN.Visible = true;
            DCBTN.Visible = true;
            IDCBTN.Visible = true;
        }

        private void SOBTN_Click(object sender, EventArgs e)
        {
            SOPB.Visible = true;

            ir.Hide();
            dc.Hide();
            so.MdiParent = this;
            so.Text = "";
            so.Show();
            WelcomePanel.Hide();
        }

        private void DCBTN_Click(object sender, EventArgs e)
        {
            DCPB.Visible = true;
            ir.Hide();
            so.Hide();
            dc.MdiParent = this;
            dc.Text = "";
            dc.Show();
            WelcomePanel.Hide();
        }

        private void IDCBTN_Click(object sender, EventArgs e)
        {
            IDCPB.Visible = true;
            dc.Hide();
            so.Hide();
            ir.MdiParent = this;
            ir.Text = "";
            ir.Show();
            WelcomePanel.Hide();
        }

    }
}
