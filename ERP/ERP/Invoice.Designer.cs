namespace ERP
{
    partial class Invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.InvoiceNoTB = new System.Windows.Forms.TextBox();
            this.GRNCombo = new System.Windows.Forms.ComboBox();
            this.InvoiceNo = new System.Windows.Forms.Label();
            this.GRNno = new System.Windows.Forms.Label();
            this.VNameTB = new System.Windows.Forms.TextBox();
            this.VName = new System.Windows.Forms.Label();
            this.VIDTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CPphTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CPNameTB = new System.Windows.Forms.TextBox();
            this.CPName = new System.Windows.Forms.Label();
            this.PODateTB = new System.Windows.Forms.TextBox();
            this.PODate = new System.Windows.Forms.Label();
            this.InvoiceDate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.AmountTB = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.Label();
            this.GRNDateTB = new System.Windows.Forms.TextBox();
            this.GRNDate = new System.Windows.Forms.Label();
            this.CreateBTN = new System.Windows.Forms.Button();
            this.DetailTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.InvoicePB1 = new System.Windows.Forms.PictureBox();
            this.InvoicePB2 = new System.Windows.Forms.PictureBox();
            this.PQuantityTB = new System.Windows.Forms.TextBox();
            this.PQuantity = new System.Windows.Forms.Label();
            this.PModelTB = new System.Windows.Forms.TextBox();
            this.PModel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicePB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicePB2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SaddleBrown;
            this.label3.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(330, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(442, 78);
            this.label3.TabIndex = 13;
            this.label3.Text = "Invoice Payable";
            // 
            // InvoiceNoTB
            // 
            this.InvoiceNoTB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceNoTB.Location = new System.Drawing.Point(253, 143);
            this.InvoiceNoTB.Name = "InvoiceNoTB";
            this.InvoiceNoTB.Size = new System.Drawing.Size(296, 31);
            this.InvoiceNoTB.TabIndex = 12;
            // 
            // GRNCombo
            // 
            this.GRNCombo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRNCombo.FormattingEnabled = true;
            this.GRNCombo.Location = new System.Drawing.Point(253, 193);
            this.GRNCombo.Name = "GRNCombo";
            this.GRNCombo.Size = new System.Drawing.Size(296, 30);
            this.GRNCombo.TabIndex = 9;
            this.GRNCombo.SelectedIndexChanged += new System.EventHandler(this.GRNCombo_SelectedIndexChanged);
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.AutoSize = true;
            this.InvoiceNo.BackColor = System.Drawing.Color.Transparent;
            this.InvoiceNo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceNo.ForeColor = System.Drawing.Color.Black;
            this.InvoiceNo.Location = new System.Drawing.Point(28, 148);
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.Size = new System.Drawing.Size(126, 26);
            this.InvoiceNo.TabIndex = 10;
            this.InvoiceNo.Text = "Invoice No :  ";
            // 
            // GRNno
            // 
            this.GRNno.AutoSize = true;
            this.GRNno.BackColor = System.Drawing.Color.Transparent;
            this.GRNno.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRNno.ForeColor = System.Drawing.Color.Black;
            this.GRNno.Location = new System.Drawing.Point(28, 193);
            this.GRNno.Name = "GRNno";
            this.GRNno.Size = new System.Drawing.Size(102, 26);
            this.GRNno.TabIndex = 11;
            this.GRNno.Text = "GRN No :  ";
            // 
            // VNameTB
            // 
            this.VNameTB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VNameTB.Location = new System.Drawing.Point(253, 392);
            this.VNameTB.Name = "VNameTB";
            this.VNameTB.Size = new System.Drawing.Size(296, 31);
            this.VNameTB.TabIndex = 17;
            // 
            // VName
            // 
            this.VName.AutoSize = true;
            this.VName.BackColor = System.Drawing.Color.Transparent;
            this.VName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VName.ForeColor = System.Drawing.Color.Black;
            this.VName.Location = new System.Drawing.Point(28, 393);
            this.VName.Name = "VName";
            this.VName.Size = new System.Drawing.Size(152, 26);
            this.VName.TabIndex = 16;
            this.VName.Text = "Vendor Name :  ";
            // 
            // VIDTB
            // 
            this.VIDTB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VIDTB.Location = new System.Drawing.Point(1036, 133);
            this.VIDTB.Name = "VIDTB";
            this.VIDTB.Size = new System.Drawing.Size(158, 31);
            this.VIDTB.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(921, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Vendor ID :";
            // 
            // CPphTB
            // 
            this.CPphTB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPphTB.Location = new System.Drawing.Point(1160, 192);
            this.CPphTB.Name = "CPphTB";
            this.CPphTB.Size = new System.Drawing.Size(156, 31);
            this.CPphTB.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(935, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 26);
            this.label4.TabIndex = 20;
            this.label4.Text = "Contact Person Ph No :";
            // 
            // CPNameTB
            // 
            this.CPNameTB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPNameTB.Location = new System.Drawing.Point(253, 442);
            this.CPNameTB.Name = "CPNameTB";
            this.CPNameTB.Size = new System.Drawing.Size(296, 31);
            this.CPNameTB.TabIndex = 19;
            // 
            // CPName
            // 
            this.CPName.AutoSize = true;
            this.CPName.BackColor = System.Drawing.Color.Transparent;
            this.CPName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPName.ForeColor = System.Drawing.Color.Black;
            this.CPName.Location = new System.Drawing.Point(28, 443);
            this.CPName.Name = "CPName";
            this.CPName.Size = new System.Drawing.Size(163, 26);
            this.CPName.TabIndex = 18;
            this.CPName.Text = "Contact Person :  ";
            // 
            // PODateTB
            // 
            this.PODateTB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PODateTB.Location = new System.Drawing.Point(253, 292);
            this.PODateTB.Name = "PODateTB";
            this.PODateTB.Size = new System.Drawing.Size(296, 31);
            this.PODateTB.TabIndex = 23;
            // 
            // PODate
            // 
            this.PODate.AutoSize = true;
            this.PODate.BackColor = System.Drawing.Color.Transparent;
            this.PODate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PODate.ForeColor = System.Drawing.Color.Black;
            this.PODate.Location = new System.Drawing.Point(28, 293);
            this.PODate.Name = "PODate";
            this.PODate.Size = new System.Drawing.Size(212, 26);
            this.PODate.TabIndex = 22;
            this.PODate.Text = "Purchase Order Date :  ";
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.AutoSize = true;
            this.InvoiceDate.BackColor = System.Drawing.Color.Transparent;
            this.InvoiceDate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceDate.ForeColor = System.Drawing.Color.Black;
            this.InvoiceDate.Location = new System.Drawing.Point(28, 347);
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.Size = new System.Drawing.Size(142, 26);
            this.InvoiceDate.TabIndex = 25;
            this.InvoiceDate.Text = "Invoice Date :  ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(253, 342);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(296, 31);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // AmountTB
            // 
            this.AmountTB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTB.Location = new System.Drawing.Point(253, 592);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(296, 31);
            this.AmountTB.TabIndex = 27;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.BackColor = System.Drawing.Color.Transparent;
            this.Amount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.ForeColor = System.Drawing.Color.Black;
            this.Amount.Location = new System.Drawing.Point(28, 593);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(176, 26);
            this.Amount.TabIndex = 26;
            this.Amount.Text = "Amount Payable :  ";
            // 
            // GRNDateTB
            // 
            this.GRNDateTB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRNDateTB.Location = new System.Drawing.Point(253, 242);
            this.GRNDateTB.Name = "GRNDateTB";
            this.GRNDateTB.Size = new System.Drawing.Size(296, 31);
            this.GRNDateTB.TabIndex = 29;
            // 
            // GRNDate
            // 
            this.GRNDate.AutoSize = true;
            this.GRNDate.BackColor = System.Drawing.Color.Transparent;
            this.GRNDate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRNDate.ForeColor = System.Drawing.Color.Black;
            this.GRNDate.Location = new System.Drawing.Point(28, 243);
            this.GRNDate.Name = "GRNDate";
            this.GRNDate.Size = new System.Drawing.Size(118, 26);
            this.GRNDate.TabIndex = 28;
            this.GRNDate.Text = "GRN Date :  ";
            // 
            // CreateBTN
            // 
            this.CreateBTN.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBTN.Location = new System.Drawing.Point(286, 638);
            this.CreateBTN.Name = "CreateBTN";
            this.CreateBTN.Size = new System.Drawing.Size(410, 53);
            this.CreateBTN.TabIndex = 30;
            this.CreateBTN.Text = "Create Invoice";
            this.CreateBTN.UseVisualStyleBackColor = true;
            this.CreateBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // DetailTB
            // 
            this.DetailTB.BackColor = System.Drawing.Color.Wheat;
            this.DetailTB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailTB.Location = new System.Drawing.Point(572, 198);
            this.DetailTB.Multiline = true;
            this.DetailTB.Name = "DetailTB";
            this.DetailTB.Size = new System.Drawing.Size(299, 375);
            this.DetailTB.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(653, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 26);
            this.label10.TabIndex = 31;
            this.label10.Text = "Product Detail";
            // 
            // InvoicePB1
            // 
            this.InvoicePB1.Location = new System.Drawing.Point(-2, 31);
            this.InvoicePB1.Name = "InvoicePB1";
            this.InvoicePB1.Size = new System.Drawing.Size(337, 78);
            this.InvoicePB1.TabIndex = 33;
            this.InvoicePB1.TabStop = false;
            // 
            // InvoicePB2
            // 
            this.InvoicePB2.Location = new System.Drawing.Point(766, 31);
            this.InvoicePB2.Name = "InvoicePB2";
            this.InvoicePB2.Size = new System.Drawing.Size(583, 78);
            this.InvoicePB2.TabIndex = 34;
            this.InvoicePB2.TabStop = false;
            // 
            // PQuantityTB
            // 
            this.PQuantityTB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PQuantityTB.Location = new System.Drawing.Point(253, 542);
            this.PQuantityTB.Name = "PQuantityTB";
            this.PQuantityTB.Size = new System.Drawing.Size(296, 31);
            this.PQuantityTB.TabIndex = 38;
            // 
            // PQuantity
            // 
            this.PQuantity.AutoSize = true;
            this.PQuantity.BackColor = System.Drawing.Color.Transparent;
            this.PQuantity.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PQuantity.ForeColor = System.Drawing.Color.Black;
            this.PQuantity.Location = new System.Drawing.Point(28, 543);
            this.PQuantity.Name = "PQuantity";
            this.PQuantity.Size = new System.Drawing.Size(180, 26);
            this.PQuantity.TabIndex = 37;
            this.PQuantity.Text = "Product Quantity :  ";
            // 
            // PModelTB
            // 
            this.PModelTB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PModelTB.Location = new System.Drawing.Point(253, 492);
            this.PModelTB.Name = "PModelTB";
            this.PModelTB.Size = new System.Drawing.Size(296, 31);
            this.PModelTB.TabIndex = 36;
            // 
            // PModel
            // 
            this.PModel.AutoSize = true;
            this.PModel.BackColor = System.Drawing.Color.Transparent;
            this.PModel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PModel.ForeColor = System.Drawing.Color.Black;
            this.PModel.Location = new System.Drawing.Point(28, 493);
            this.PModel.Name = "PModel";
            this.PModel.Size = new System.Drawing.Size(161, 26);
            this.PModel.TabIndex = 35;
            this.PModel.Text = "Product Model :  ";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 741);
            this.Controls.Add(this.PQuantityTB);
            this.Controls.Add(this.PQuantity);
            this.Controls.Add(this.PModelTB);
            this.Controls.Add(this.PModel);
            this.Controls.Add(this.InvoicePB2);
            this.Controls.Add(this.InvoicePB1);
            this.Controls.Add(this.DetailTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CreateBTN);
            this.Controls.Add(this.GRNDateTB);
            this.Controls.Add(this.GRNDate);
            this.Controls.Add(this.AmountTB);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.InvoiceDate);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.PODateTB);
            this.Controls.Add(this.PODate);
            this.Controls.Add(this.CPphTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CPNameTB);
            this.Controls.Add(this.CPName);
            this.Controls.Add(this.VNameTB);
            this.Controls.Add(this.VName);
            this.Controls.Add(this.VIDTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InvoiceNoTB);
            this.Controls.Add(this.GRNCombo);
            this.Controls.Add(this.InvoiceNo);
            this.Controls.Add(this.GRNno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(468, 0);
            this.Name = "Invoice";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvoicePB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicePB2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InvoiceNoTB;
        private System.Windows.Forms.ComboBox GRNCombo;
        private System.Windows.Forms.Label InvoiceNo;
        private System.Windows.Forms.Label GRNno;
        private System.Windows.Forms.TextBox VNameTB;
        private System.Windows.Forms.Label VName;
        private System.Windows.Forms.TextBox VIDTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CPphTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CPNameTB;
        private System.Windows.Forms.Label CPName;
        private System.Windows.Forms.TextBox PODateTB;
        private System.Windows.Forms.Label PODate;
        private System.Windows.Forms.Label InvoiceDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox AmountTB;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.TextBox GRNDateTB;
        private System.Windows.Forms.Label GRNDate;
        private System.Windows.Forms.Button CreateBTN;
        private System.Windows.Forms.TextBox DetailTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox InvoicePB1;
        private System.Windows.Forms.PictureBox InvoicePB2;
        private System.Windows.Forms.TextBox PQuantityTB;
        private System.Windows.Forms.Label PQuantity;
        private System.Windows.Forms.TextBox PModelTB;
        private System.Windows.Forms.Label PModel;
    }
}