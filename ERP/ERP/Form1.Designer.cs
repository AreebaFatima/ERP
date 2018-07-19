namespace ERP
{
    partial class Form1
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
            this.DeptCombo = new System.Windows.Forms.ComboBox();
            this.DeptName = new System.Windows.Forms.Label();
            this.POIDTB = new System.Windows.Forms.TextBox();
            this.POID = new System.Windows.Forms.Label();
            this.SelectVendor = new System.Windows.Forms.GroupBox();
            this.PODate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.VendorInfo = new System.Windows.Forms.GroupBox();
            this.VIDCombo = new System.Windows.Forms.ComboBox();
            this.VCPphTB = new System.Windows.Forms.TextBox();
            this.VCPPh = new System.Windows.Forms.Label();
            this.VCPNameTB = new System.Windows.Forms.TextBox();
            this.VCPName = new System.Windows.Forms.Label();
            this.VNameTB = new System.Windows.Forms.TextBox();
            this.VName = new System.Windows.Forms.Label();
            this.VID = new System.Windows.Forms.Label();
            this.ProductInfo = new System.Windows.Forms.GroupBox();
            this.PNameTB = new System.Windows.Forms.TextBox();
            this.PName = new System.Windows.Forms.Label();
            this.UnitPrice = new System.Windows.Forms.Label();
            this.PCombo = new System.Windows.Forms.ComboBox();
            this.PQuantity = new System.Windows.Forms.Label();
            this.PModel = new System.Windows.Forms.Label();
            this.PQuantityTB = new System.Windows.Forms.TextBox();
            this.UnitPriceTB = new System.Windows.Forms.TextBox();
            this.Createbtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.GroupBox();
            this.TotalTB = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.DetailTB = new System.Windows.Forms.TextBox();
            this.POPB1 = new System.Windows.Forms.PictureBox();
            this.POPB2 = new System.Windows.Forms.PictureBox();
            this.SelectVendor.SuspendLayout();
            this.VendorInfo.SuspendLayout();
            this.ProductInfo.SuspendLayout();
            this.Amount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.POPB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POPB2)).BeginInit();
            this.SuspendLayout();
            // 
            // DeptCombo
            // 
            this.DeptCombo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptCombo.FormattingEnabled = true;
            this.DeptCombo.Location = new System.Drawing.Point(165, 36);
            this.DeptCombo.Name = "DeptCombo";
            this.DeptCombo.Size = new System.Drawing.Size(200, 28);
            this.DeptCombo.TabIndex = 0;
            this.DeptCombo.SelectedIndexChanged += new System.EventHandler(this.DeptCombo_SelectedIndexChanged);
            // 
            // DeptName
            // 
            this.DeptName.AutoSize = true;
            this.DeptName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptName.Location = new System.Drawing.Point(6, 39);
            this.DeptName.Name = "DeptName";
            this.DeptName.Size = new System.Drawing.Size(42, 19);
            this.DeptName.TabIndex = 1;
            this.DeptName.Text = "label";
            // 
            // POIDTB
            // 
            this.POIDTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POIDTB.Location = new System.Drawing.Point(601, 36);
            this.POIDTB.Name = "POIDTB";
            this.POIDTB.Size = new System.Drawing.Size(216, 27);
            this.POIDTB.TabIndex = 2;
            // 
            // POID
            // 
            this.POID.AutoSize = true;
            this.POID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POID.Location = new System.Drawing.Point(387, 39);
            this.POID.Name = "POID";
            this.POID.Size = new System.Drawing.Size(50, 19);
            this.POID.TabIndex = 1;
            this.POID.Text = "label1";
            // 
            // SelectVendor
            // 
            this.SelectVendor.BackColor = System.Drawing.Color.Wheat;
            this.SelectVendor.Controls.Add(this.PODate);
            this.SelectVendor.Controls.Add(this.dateTimePicker1);
            this.SelectVendor.Controls.Add(this.POIDTB);
            this.SelectVendor.Controls.Add(this.DeptCombo);
            this.SelectVendor.Controls.Add(this.POID);
            this.SelectVendor.Controls.Add(this.DeptName);
            this.SelectVendor.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectVendor.ForeColor = System.Drawing.Color.Black;
            this.SelectVendor.Location = new System.Drawing.Point(56, 135);
            this.SelectVendor.Name = "SelectVendor";
            this.SelectVendor.Size = new System.Drawing.Size(839, 134);
            this.SelectVendor.TabIndex = 3;
            this.SelectVendor.TabStop = false;
            this.SelectVendor.Text = "groupBox1";
            // 
            // PODate
            // 
            this.PODate.AutoSize = true;
            this.PODate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PODate.Location = new System.Drawing.Point(134, 88);
            this.PODate.Name = "PODate";
            this.PODate.Size = new System.Drawing.Size(159, 19);
            this.PODate.TabIndex = 4;
            this.PODate.Text = "Purchase Order Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(328, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(254, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // VendorInfo
            // 
            this.VendorInfo.BackColor = System.Drawing.Color.Wheat;
            this.VendorInfo.Controls.Add(this.VIDCombo);
            this.VendorInfo.Controls.Add(this.VCPphTB);
            this.VendorInfo.Controls.Add(this.VCPPh);
            this.VendorInfo.Controls.Add(this.VCPNameTB);
            this.VendorInfo.Controls.Add(this.VCPName);
            this.VendorInfo.Controls.Add(this.VNameTB);
            this.VendorInfo.Controls.Add(this.VName);
            this.VendorInfo.Controls.Add(this.VID);
            this.VendorInfo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorInfo.ForeColor = System.Drawing.Color.Black;
            this.VendorInfo.Location = new System.Drawing.Point(56, 285);
            this.VendorInfo.Name = "VendorInfo";
            this.VendorInfo.Size = new System.Drawing.Size(395, 186);
            this.VendorInfo.TabIndex = 4;
            this.VendorInfo.TabStop = false;
            this.VendorInfo.Text = "groupBox2";
            // 
            // VIDCombo
            // 
            this.VIDCombo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VIDCombo.FormattingEnabled = true;
            this.VIDCombo.Location = new System.Drawing.Point(171, 37);
            this.VIDCombo.Name = "VIDCombo";
            this.VIDCombo.Size = new System.Drawing.Size(200, 28);
            this.VIDCombo.TabIndex = 2;
            this.VIDCombo.SelectedIndexChanged += new System.EventHandler(this.VIDCombo_SelectedIndexChanged);
            // 
            // VCPphTB
            // 
            this.VCPphTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VCPphTB.Location = new System.Drawing.Point(171, 139);
            this.VCPphTB.Name = "VCPphTB";
            this.VCPphTB.Size = new System.Drawing.Size(200, 27);
            this.VCPphTB.TabIndex = 0;
            // 
            // VCPPh
            // 
            this.VCPPh.AutoSize = true;
            this.VCPPh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VCPPh.Location = new System.Drawing.Point(32, 142);
            this.VCPPh.Name = "VCPPh";
            this.VCPPh.Size = new System.Drawing.Size(50, 19);
            this.VCPPh.TabIndex = 1;
            this.VCPPh.Text = "label1";
            // 
            // VCPNameTB
            // 
            this.VCPNameTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VCPNameTB.Location = new System.Drawing.Point(171, 106);
            this.VCPNameTB.Name = "VCPNameTB";
            this.VCPNameTB.Size = new System.Drawing.Size(200, 27);
            this.VCPNameTB.TabIndex = 0;
            // 
            // VCPName
            // 
            this.VCPName.AutoSize = true;
            this.VCPName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VCPName.Location = new System.Drawing.Point(32, 109);
            this.VCPName.Name = "VCPName";
            this.VCPName.Size = new System.Drawing.Size(50, 19);
            this.VCPName.TabIndex = 1;
            this.VCPName.Text = "label1";
            // 
            // VNameTB
            // 
            this.VNameTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VNameTB.Location = new System.Drawing.Point(171, 74);
            this.VNameTB.Name = "VNameTB";
            this.VNameTB.Size = new System.Drawing.Size(200, 27);
            this.VNameTB.TabIndex = 0;
            // 
            // VName
            // 
            this.VName.AutoSize = true;
            this.VName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VName.Location = new System.Drawing.Point(32, 77);
            this.VName.Name = "VName";
            this.VName.Size = new System.Drawing.Size(50, 19);
            this.VName.TabIndex = 1;
            this.VName.Text = "label1";
            // 
            // VID
            // 
            this.VID.AutoSize = true;
            this.VID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VID.Location = new System.Drawing.Point(32, 40);
            this.VID.Name = "VID";
            this.VID.Size = new System.Drawing.Size(50, 19);
            this.VID.TabIndex = 1;
            this.VID.Text = "label1";
            // 
            // ProductInfo
            // 
            this.ProductInfo.BackColor = System.Drawing.Color.Wheat;
            this.ProductInfo.Controls.Add(this.PNameTB);
            this.ProductInfo.Controls.Add(this.PName);
            this.ProductInfo.Controls.Add(this.UnitPrice);
            this.ProductInfo.Controls.Add(this.PCombo);
            this.ProductInfo.Controls.Add(this.PQuantity);
            this.ProductInfo.Controls.Add(this.PModel);
            this.ProductInfo.Controls.Add(this.PQuantityTB);
            this.ProductInfo.Controls.Add(this.UnitPriceTB);
            this.ProductInfo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductInfo.ForeColor = System.Drawing.Color.Black;
            this.ProductInfo.Location = new System.Drawing.Point(500, 285);
            this.ProductInfo.Name = "ProductInfo";
            this.ProductInfo.Size = new System.Drawing.Size(395, 186);
            this.ProductInfo.TabIndex = 5;
            this.ProductInfo.TabStop = false;
            this.ProductInfo.Text = "groupBox1";
            // 
            // PNameTB
            // 
            this.PNameTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNameTB.Location = new System.Drawing.Point(171, 74);
            this.PNameTB.Name = "PNameTB";
            this.PNameTB.Size = new System.Drawing.Size(200, 27);
            this.PNameTB.TabIndex = 4;
            // 
            // PName
            // 
            this.PName.AutoSize = true;
            this.PName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PName.Location = new System.Drawing.Point(26, 77);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(50, 19);
            this.PName.TabIndex = 3;
            this.PName.Text = "label1";
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSize = true;
            this.UnitPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPrice.Location = new System.Drawing.Point(26, 109);
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Size = new System.Drawing.Size(84, 19);
            this.UnitPrice.TabIndex = 0;
            this.UnitPrice.Text = "Unit Price :";
            // 
            // PCombo
            // 
            this.PCombo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCombo.FormattingEnabled = true;
            this.PCombo.Location = new System.Drawing.Point(171, 37);
            this.PCombo.Name = "PCombo";
            this.PCombo.Size = new System.Drawing.Size(200, 28);
            this.PCombo.TabIndex = 1;
            this.PCombo.SelectedIndexChanged += new System.EventHandler(this.PCombo_SelectedIndexChanged);
            // 
            // PQuantity
            // 
            this.PQuantity.AutoSize = true;
            this.PQuantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PQuantity.Location = new System.Drawing.Point(26, 142);
            this.PQuantity.Name = "PQuantity";
            this.PQuantity.Size = new System.Drawing.Size(50, 19);
            this.PQuantity.TabIndex = 0;
            this.PQuantity.Text = "label1";
            // 
            // PModel
            // 
            this.PModel.AutoSize = true;
            this.PModel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PModel.Location = new System.Drawing.Point(26, 41);
            this.PModel.Name = "PModel";
            this.PModel.Size = new System.Drawing.Size(50, 19);
            this.PModel.TabIndex = 0;
            this.PModel.Text = "label1";
            // 
            // PQuantityTB
            // 
            this.PQuantityTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PQuantityTB.Location = new System.Drawing.Point(171, 139);
            this.PQuantityTB.Name = "PQuantityTB";
            this.PQuantityTB.Size = new System.Drawing.Size(200, 27);
            this.PQuantityTB.TabIndex = 0;
            this.PQuantityTB.TextChanged += new System.EventHandler(this.PQuantityTB_TextChanged);
            this.PQuantityTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PQuantityTB_KeyPress_1);
            // 
            // UnitPriceTB
            // 
            this.UnitPriceTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPriceTB.Location = new System.Drawing.Point(171, 106);
            this.UnitPriceTB.Name = "UnitPriceTB";
            this.UnitPriceTB.Size = new System.Drawing.Size(200, 27);
            this.UnitPriceTB.TabIndex = 0;
            // 
            // Createbtn
            // 
            this.Createbtn.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createbtn.Location = new System.Drawing.Point(577, 648);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(294, 47);
            this.Createbtn.TabIndex = 2;
            this.Createbtn.Text = "Button1";
            this.Createbtn.UseVisualStyleBackColor = true;
            this.Createbtn.Click += new System.EventHandler(this.CreateButton);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(118, 648);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(294, 47);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "button1";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.ADDbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 78);
            this.label1.TabIndex = 7;
            this.label1.Text = "Purchase Order";
            // 
            // Amount
            // 
            this.Amount.BackColor = System.Drawing.Color.Wheat;
            this.Amount.Controls.Add(this.TotalTB);
            this.Amount.Controls.Add(this.Total);
            this.Amount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.ForeColor = System.Drawing.Color.Black;
            this.Amount.Location = new System.Drawing.Point(500, 479);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(395, 149);
            this.Amount.TabIndex = 8;
            this.Amount.TabStop = false;
            this.Amount.Text = "Amount";
            // 
            // TotalTB
            // 
            this.TotalTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTB.Location = new System.Drawing.Point(167, 62);
            this.TotalTB.Name = "TotalTB";
            this.TotalTB.Size = new System.Drawing.Size(200, 27);
            this.TotalTB.TabIndex = 0;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(26, 65);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(111, 19);
            this.Total.TabIndex = 0;
            this.Total.Text = "Total Amount :";
            // 
            // DetailTB
            // 
            this.DetailTB.BackColor = System.Drawing.Color.Wheat;
            this.DetailTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailTB.ForeColor = System.Drawing.Color.Black;
            this.DetailTB.Location = new System.Drawing.Point(56, 477);
            this.DetailTB.Multiline = true;
            this.DetailTB.Name = "DetailTB";
            this.DetailTB.Size = new System.Drawing.Size(395, 151);
            this.DetailTB.TabIndex = 9;
            this.DetailTB.TextChanged += new System.EventHandler(this.DetailTB_TextChanged);
            // 
            // POPB1
            // 
            this.POPB1.Location = new System.Drawing.Point(0, 31);
            this.POPB1.Name = "POPB1";
            this.POPB1.Size = new System.Drawing.Size(266, 78);
            this.POPB1.TabIndex = 31;
            this.POPB1.TabStop = false;
            // 
            // POPB2
            // 
            this.POPB2.Location = new System.Drawing.Point(707, 31);
            this.POPB2.Name = "POPB2";
            this.POPB2.Size = new System.Drawing.Size(694, 78);
            this.POPB2.TabIndex = 32;
            this.POPB2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.Controls.Add(this.POPB2);
            this.Controls.Add(this.POPB1);
            this.Controls.Add(this.Createbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.DetailTB);
            this.Controls.Add(this.ProductInfo);
            this.Controls.Add(this.SelectVendor);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.VendorInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(468, 0);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SelectVendor.ResumeLayout(false);
            this.SelectVendor.PerformLayout();
            this.VendorInfo.ResumeLayout(false);
            this.VendorInfo.PerformLayout();
            this.ProductInfo.ResumeLayout(false);
            this.ProductInfo.PerformLayout();
            this.Amount.ResumeLayout(false);
            this.Amount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.POPB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POPB2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DeptCombo;
        private System.Windows.Forms.Label DeptName;
        private System.Windows.Forms.TextBox POIDTB;
        private System.Windows.Forms.Label POID;
        private System.Windows.Forms.GroupBox SelectVendor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox VendorInfo;
        private System.Windows.Forms.TextBox VCPphTB;
        private System.Windows.Forms.Label VCPPh;
        private System.Windows.Forms.TextBox VCPNameTB;
        private System.Windows.Forms.Label VCPName;
        private System.Windows.Forms.TextBox VNameTB;
        private System.Windows.Forms.Label VName;
        private System.Windows.Forms.Label VID;
        private System.Windows.Forms.GroupBox ProductInfo;
        private System.Windows.Forms.ComboBox PCombo;
        private System.Windows.Forms.Label PQuantity;
        private System.Windows.Forms.Label PModel;
        private System.Windows.Forms.ComboBox VIDCombo;
        private System.Windows.Forms.TextBox PQuantityTB;
        private System.Windows.Forms.Button Createbtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox PNameTB;
        private System.Windows.Forms.Label PName;
        private System.Windows.Forms.Label PODate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UnitPrice;
        private System.Windows.Forms.TextBox UnitPriceTB;
        private System.Windows.Forms.GroupBox Amount;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox TotalTB;
        private System.Windows.Forms.TextBox DetailTB;
        private System.Windows.Forms.PictureBox POPB1;
        private System.Windows.Forms.PictureBox POPB2;
    }
}

