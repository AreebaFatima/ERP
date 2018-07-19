namespace ERP
{
    partial class Sales_Order
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
            this.SOPB2 = new System.Windows.Forms.PictureBox();
            this.SOPB1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectCustomer = new System.Windows.Forms.GroupBox();
            this.PODate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SOIDTB = new System.Windows.Forms.TextBox();
            this.DeptCombo = new System.Windows.Forms.ComboBox();
            this.SOID = new System.Windows.Forms.Label();
            this.DeptName = new System.Windows.Forms.Label();
            this.CustomerInfo = new System.Windows.Forms.GroupBox();
            this.CIDCombo = new System.Windows.Forms.ComboBox();
            this.CCPphTB = new System.Windows.Forms.TextBox();
            this.CCPPh = new System.Windows.Forms.Label();
            this.CCPNameTB = new System.Windows.Forms.TextBox();
            this.CCPName = new System.Windows.Forms.Label();
            this.CNameTB = new System.Windows.Forms.TextBox();
            this.CName = new System.Windows.Forms.Label();
            this.CID = new System.Windows.Forms.Label();
            this.ProductInfo = new System.Windows.Forms.GroupBox();
            this.PNameTB = new System.Windows.Forms.TextBox();
            this.PName = new System.Windows.Forms.Label();
            this.UnitPrice = new System.Windows.Forms.Label();
            this.PCombo = new System.Windows.Forms.ComboBox();
            this.PQuantity = new System.Windows.Forms.Label();
            this.PModel = new System.Windows.Forms.Label();
            this.PQuantityTB = new System.Windows.Forms.TextBox();
            this.UnitPriceTB = new System.Windows.Forms.TextBox();
            this.DetailTB = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.GroupBox();
            this.TotalTB = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.Createbtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SOPB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SOPB1)).BeginInit();
            this.SelectCustomer.SuspendLayout();
            this.CustomerInfo.SuspendLayout();
            this.ProductInfo.SuspendLayout();
            this.Amount.SuspendLayout();
            this.SuspendLayout();
            // 
            // SOPB2
            // 
            this.SOPB2.Location = new System.Drawing.Point(634, 31);
            this.SOPB2.Name = "SOPB2";
            this.SOPB2.Size = new System.Drawing.Size(757, 78);
            this.SOPB2.TabIndex = 35;
            this.SOPB2.TabStop = false;
            // 
            // SOPB1
            // 
            this.SOPB1.Location = new System.Drawing.Point(-1, 31);
            this.SOPB1.Name = "SOPB1";
            this.SOPB1.Size = new System.Drawing.Size(307, 78);
            this.SOPB1.TabIndex = 34;
            this.SOPB1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(304, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 78);
            this.label1.TabIndex = 33;
            this.label1.Text = "Sales Order";
            // 
            // SelectCustomer
            // 
            this.SelectCustomer.BackColor = System.Drawing.Color.Wheat;
            this.SelectCustomer.Controls.Add(this.PODate);
            this.SelectCustomer.Controls.Add(this.dateTimePicker1);
            this.SelectCustomer.Controls.Add(this.SOIDTB);
            this.SelectCustomer.Controls.Add(this.DeptCombo);
            this.SelectCustomer.Controls.Add(this.SOID);
            this.SelectCustomer.Controls.Add(this.DeptName);
            this.SelectCustomer.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCustomer.ForeColor = System.Drawing.Color.Black;
            this.SelectCustomer.Location = new System.Drawing.Point(56, 135);
            this.SelectCustomer.Name = "SelectCustomer";
            this.SelectCustomer.Size = new System.Drawing.Size(839, 134);
            this.SelectCustomer.TabIndex = 36;
            this.SelectCustomer.TabStop = false;
            this.SelectCustomer.Text = "groupBox1";
            // 
            // PODate
            // 
            this.PODate.AutoSize = true;
            this.PODate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PODate.Location = new System.Drawing.Point(134, 88);
            this.PODate.Name = "PODate";
            this.PODate.Size = new System.Drawing.Size(131, 19);
            this.PODate.TabIndex = 4;
            this.PODate.Text = "Sales Order Date :";
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
            // SOIDTB
            // 
            this.SOIDTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOIDTB.Location = new System.Drawing.Point(601, 36);
            this.SOIDTB.Name = "SOIDTB";
            this.SOIDTB.Size = new System.Drawing.Size(216, 27);
            this.SOIDTB.TabIndex = 2;
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
            // SOID
            // 
            this.SOID.AutoSize = true;
            this.SOID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOID.Location = new System.Drawing.Point(387, 39);
            this.SOID.Name = "SOID";
            this.SOID.Size = new System.Drawing.Size(50, 19);
            this.SOID.TabIndex = 1;
            this.SOID.Text = "label1";
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
            // CustomerInfo
            // 
            this.CustomerInfo.BackColor = System.Drawing.Color.Wheat;
            this.CustomerInfo.Controls.Add(this.CIDCombo);
            this.CustomerInfo.Controls.Add(this.CCPphTB);
            this.CustomerInfo.Controls.Add(this.CCPPh);
            this.CustomerInfo.Controls.Add(this.CCPNameTB);
            this.CustomerInfo.Controls.Add(this.CCPName);
            this.CustomerInfo.Controls.Add(this.CNameTB);
            this.CustomerInfo.Controls.Add(this.CName);
            this.CustomerInfo.Controls.Add(this.CID);
            this.CustomerInfo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerInfo.ForeColor = System.Drawing.Color.Black;
            this.CustomerInfo.Location = new System.Drawing.Point(56, 285);
            this.CustomerInfo.Name = "CustomerInfo";
            this.CustomerInfo.Size = new System.Drawing.Size(395, 186);
            this.CustomerInfo.TabIndex = 37;
            this.CustomerInfo.TabStop = false;
            this.CustomerInfo.Text = "groupBox2";
            // 
            // CIDCombo
            // 
            this.CIDCombo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CIDCombo.FormattingEnabled = true;
            this.CIDCombo.Location = new System.Drawing.Point(171, 37);
            this.CIDCombo.Name = "CIDCombo";
            this.CIDCombo.Size = new System.Drawing.Size(200, 28);
            this.CIDCombo.TabIndex = 2;
            this.CIDCombo.SelectedIndexChanged += new System.EventHandler(this.CIDCombo_SelectedIndexChanged);
            // 
            // CCPphTB
            // 
            this.CCPphTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCPphTB.Location = new System.Drawing.Point(171, 139);
            this.CCPphTB.Name = "CCPphTB";
            this.CCPphTB.Size = new System.Drawing.Size(200, 27);
            this.CCPphTB.TabIndex = 0;
            // 
            // CCPPh
            // 
            this.CCPPh.AutoSize = true;
            this.CCPPh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCPPh.Location = new System.Drawing.Point(32, 142);
            this.CCPPh.Name = "CCPPh";
            this.CCPPh.Size = new System.Drawing.Size(50, 19);
            this.CCPPh.TabIndex = 1;
            this.CCPPh.Text = "label1";
            // 
            // CCPNameTB
            // 
            this.CCPNameTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCPNameTB.Location = new System.Drawing.Point(171, 106);
            this.CCPNameTB.Name = "CCPNameTB";
            this.CCPNameTB.Size = new System.Drawing.Size(200, 27);
            this.CCPNameTB.TabIndex = 0;
            // 
            // CCPName
            // 
            this.CCPName.AutoSize = true;
            this.CCPName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCPName.Location = new System.Drawing.Point(32, 109);
            this.CCPName.Name = "CCPName";
            this.CCPName.Size = new System.Drawing.Size(50, 19);
            this.CCPName.TabIndex = 1;
            this.CCPName.Text = "label1";
            // 
            // CNameTB
            // 
            this.CNameTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNameTB.Location = new System.Drawing.Point(171, 74);
            this.CNameTB.Name = "CNameTB";
            this.CNameTB.Size = new System.Drawing.Size(200, 27);
            this.CNameTB.TabIndex = 0;
            // 
            // CName
            // 
            this.CName.AutoSize = true;
            this.CName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CName.Location = new System.Drawing.Point(32, 77);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(50, 19);
            this.CName.TabIndex = 1;
            this.CName.Text = "label1";
            // 
            // CID
            // 
            this.CID.AutoSize = true;
            this.CID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CID.Location = new System.Drawing.Point(32, 40);
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(50, 19);
            this.CID.TabIndex = 1;
            this.CID.Text = "label1";
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
            this.ProductInfo.TabIndex = 38;
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
            this.PQuantityTB.TextChanged += new System.EventHandler(this.PQuantityTB_TextChanged_1);
            this.PQuantityTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PQuantityTB_KeyPress);
            // 
            // UnitPriceTB
            // 
            this.UnitPriceTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPriceTB.Location = new System.Drawing.Point(171, 106);
            this.UnitPriceTB.Name = "UnitPriceTB";
            this.UnitPriceTB.Size = new System.Drawing.Size(200, 27);
            this.UnitPriceTB.TabIndex = 0;
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
            this.DetailTB.TabIndex = 39;
            this.DetailTB.TextChanged += new System.EventHandler(this.DetailTB_TextChanged);
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
            this.Amount.TabIndex = 40;
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
            // Createbtn
            // 
            this.Createbtn.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createbtn.Location = new System.Drawing.Point(577, 648);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(294, 47);
            this.Createbtn.TabIndex = 41;
            this.Createbtn.Text = "Button1";
            this.Createbtn.UseVisualStyleBackColor = true;
            this.Createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(118, 648);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(294, 47);
            this.AddBtn.TabIndex = 42;
            this.AddBtn.Text = "button1";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Sales_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 780);
            this.Controls.Add(this.Createbtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.DetailTB);
            this.Controls.Add(this.ProductInfo);
            this.Controls.Add(this.CustomerInfo);
            this.Controls.Add(this.SelectCustomer);
            this.Controls.Add(this.SOPB2);
            this.Controls.Add(this.SOPB1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(468, 0);
            this.Name = "Sales_Order";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sales_Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sales_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SOPB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SOPB1)).EndInit();
            this.SelectCustomer.ResumeLayout(false);
            this.SelectCustomer.PerformLayout();
            this.CustomerInfo.ResumeLayout(false);
            this.CustomerInfo.PerformLayout();
            this.ProductInfo.ResumeLayout(false);
            this.ProductInfo.PerformLayout();
            this.Amount.ResumeLayout(false);
            this.Amount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SOPB2;
        private System.Windows.Forms.PictureBox SOPB1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox SelectCustomer;
        private System.Windows.Forms.Label PODate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox SOIDTB;
        private System.Windows.Forms.ComboBox DeptCombo;
        private System.Windows.Forms.Label SOID;
        private System.Windows.Forms.Label DeptName;
        private System.Windows.Forms.GroupBox CustomerInfo;
        private System.Windows.Forms.ComboBox CIDCombo;
        private System.Windows.Forms.TextBox CCPphTB;
        private System.Windows.Forms.Label CCPPh;
        private System.Windows.Forms.TextBox CCPNameTB;
        private System.Windows.Forms.Label CCPName;
        private System.Windows.Forms.TextBox CNameTB;
        private System.Windows.Forms.Label CName;
        private System.Windows.Forms.Label CID;
        private System.Windows.Forms.GroupBox ProductInfo;
        private System.Windows.Forms.TextBox PNameTB;
        private System.Windows.Forms.Label PName;
        private System.Windows.Forms.Label UnitPrice;
        private System.Windows.Forms.ComboBox PCombo;
        private System.Windows.Forms.Label PQuantity;
        private System.Windows.Forms.Label PModel;
        private System.Windows.Forms.TextBox PQuantityTB;
        private System.Windows.Forms.TextBox UnitPriceTB;
        private System.Windows.Forms.TextBox DetailTB;
        private System.Windows.Forms.GroupBox Amount;
        private System.Windows.Forms.TextBox TotalTB;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Button Createbtn;
        private System.Windows.Forms.Button AddBtn;
    }
}