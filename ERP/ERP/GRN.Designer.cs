namespace ERP
{
    partial class GRN
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
            this.CreateGRN = new System.Windows.Forms.Button();
            this.GRNDate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.GRNnoTB = new System.Windows.Forms.TextBox();
            this.POIDCombo = new System.Windows.Forms.ComboBox();
            this.GRNno = new System.Windows.Forms.Label();
            this.DeptName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DDateTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VNameTB = new System.Windows.Forms.TextBox();
            this.VName = new System.Windows.Forms.Label();
            this.TotalTB = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PModelTB = new System.Windows.Forms.TextBox();
            this.PModel = new System.Windows.Forms.Label();
            this.PQuantityTB = new System.Windows.Forms.TextBox();
            this.PQuantity = new System.Windows.Forms.Label();
            this.DetailTB = new System.Windows.Forms.TextBox();
            this.GRNPB1 = new System.Windows.Forms.PictureBox();
            this.GRNPB2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GRNPB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRNPB2)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateGRN
            // 
            this.CreateGRN.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateGRN.Location = new System.Drawing.Point(276, 606);
            this.CreateGRN.Name = "CreateGRN";
            this.CreateGRN.Size = new System.Drawing.Size(409, 63);
            this.CreateGRN.TabIndex = 6;
            this.CreateGRN.Text = "Create GRN";
            this.CreateGRN.UseVisualStyleBackColor = true;
            this.CreateGRN.Click += new System.EventHandler(this.CreateGRN_Click);
            // 
            // GRNDate
            // 
            this.GRNDate.AutoSize = true;
            this.GRNDate.BackColor = System.Drawing.Color.Transparent;
            this.GRNDate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRNDate.ForeColor = System.Drawing.Color.Black;
            this.GRNDate.Location = new System.Drawing.Point(23, 284);
            this.GRNDate.Name = "GRNDate";
            this.GRNDate.Size = new System.Drawing.Size(113, 26);
            this.GRNDate.TabIndex = 4;
            this.GRNDate.Text = "GRN Date : ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(228, 280);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(296, 31);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // GRNnoTB
            // 
            this.GRNnoTB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRNnoTB.Location = new System.Drawing.Point(228, 231);
            this.GRNnoTB.Name = "GRNnoTB";
            this.GRNnoTB.Size = new System.Drawing.Size(296, 31);
            this.GRNnoTB.TabIndex = 2;
            // 
            // POIDCombo
            // 
            this.POIDCombo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POIDCombo.FormattingEnabled = true;
            this.POIDCombo.Location = new System.Drawing.Point(228, 176);
            this.POIDCombo.Name = "POIDCombo";
            this.POIDCombo.Size = new System.Drawing.Size(296, 30);
            this.POIDCombo.TabIndex = 0;
            this.POIDCombo.SelectedIndexChanged += new System.EventHandler(this.DeptCombo_SelectedIndexChanged);
            // 
            // GRNno
            // 
            this.GRNno.AutoSize = true;
            this.GRNno.BackColor = System.Drawing.Color.Transparent;
            this.GRNno.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRNno.ForeColor = System.Drawing.Color.Black;
            this.GRNno.Location = new System.Drawing.Point(23, 232);
            this.GRNno.Name = "GRNno";
            this.GRNno.Size = new System.Drawing.Size(97, 26);
            this.GRNno.TabIndex = 1;
            this.GRNno.Text = "GRN No : ";
            // 
            // DeptName
            // 
            this.DeptName.AutoSize = true;
            this.DeptName.BackColor = System.Drawing.Color.Transparent;
            this.DeptName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptName.ForeColor = System.Drawing.Color.Black;
            this.DeptName.Location = new System.Drawing.Point(20, 176);
            this.DeptName.Name = "DeptName";
            this.DeptName.Size = new System.Drawing.Size(191, 26);
            this.DeptName.TabIndex = 1;
            this.DeptName.Text = "Purchase Order No : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SaddleBrown;
            this.label3.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(410, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 78);
            this.label3.TabIndex = 8;
            this.label3.Text = "GRN";
            // 
            // DDateTB
            // 
            this.DDateTB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DDateTB.Location = new System.Drawing.Point(228, 333);
            this.DDateTB.Name = "DDateTB";
            this.DDateTB.Size = new System.Drawing.Size(296, 31);
            this.DDateTB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Delievery Date :  ";
            // 
            // VNameTB
            // 
            this.VNameTB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VNameTB.Location = new System.Drawing.Point(228, 387);
            this.VNameTB.Name = "VNameTB";
            this.VNameTB.Size = new System.Drawing.Size(296, 31);
            this.VNameTB.TabIndex = 10;
            // 
            // VName
            // 
            this.VName.AutoSize = true;
            this.VName.BackColor = System.Drawing.Color.Transparent;
            this.VName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VName.ForeColor = System.Drawing.Color.Black;
            this.VName.Location = new System.Drawing.Point(20, 388);
            this.VName.Name = "VName";
            this.VName.Size = new System.Drawing.Size(152, 26);
            this.VName.TabIndex = 9;
            this.VName.Text = "Vendor Name :  ";
            // 
            // TotalTB
            // 
            this.TotalTB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTB.Location = new System.Drawing.Point(228, 549);
            this.TotalTB.Name = "TotalTB";
            this.TotalTB.Size = new System.Drawing.Size(296, 31);
            this.TotalTB.TabIndex = 12;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.BackColor = System.Drawing.Color.Transparent;
            this.Total.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.Black;
            this.Total.Location = new System.Drawing.Point(23, 550);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(149, 26);
            this.Total.TabIndex = 11;
            this.Total.Text = "Total Amount :  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(629, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Product Detail";
            // 
            // PModelTB
            // 
            this.PModelTB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PModelTB.Location = new System.Drawing.Point(228, 445);
            this.PModelTB.Name = "PModelTB";
            this.PModelTB.Size = new System.Drawing.Size(296, 31);
            this.PModelTB.TabIndex = 16;
            // 
            // PModel
            // 
            this.PModel.AutoSize = true;
            this.PModel.BackColor = System.Drawing.Color.Transparent;
            this.PModel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PModel.ForeColor = System.Drawing.Color.Black;
            this.PModel.Location = new System.Drawing.Point(20, 446);
            this.PModel.Name = "PModel";
            this.PModel.Size = new System.Drawing.Size(161, 26);
            this.PModel.TabIndex = 15;
            this.PModel.Text = "Product Model :  ";
            // 
            // PQuantityTB
            // 
            this.PQuantityTB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PQuantityTB.Location = new System.Drawing.Point(228, 498);
            this.PQuantityTB.Name = "PQuantityTB";
            this.PQuantityTB.Size = new System.Drawing.Size(296, 31);
            this.PQuantityTB.TabIndex = 18;
            // 
            // PQuantity
            // 
            this.PQuantity.AutoSize = true;
            this.PQuantity.BackColor = System.Drawing.Color.Transparent;
            this.PQuantity.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PQuantity.ForeColor = System.Drawing.Color.Black;
            this.PQuantity.Location = new System.Drawing.Point(20, 499);
            this.PQuantity.Name = "PQuantity";
            this.PQuantity.Size = new System.Drawing.Size(180, 26);
            this.PQuantity.TabIndex = 17;
            this.PQuantity.Text = "Product Quantity :  ";
            // 
            // DetailTB
            // 
            this.DetailTB.BackColor = System.Drawing.Color.Wheat;
            this.DetailTB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailTB.Location = new System.Drawing.Point(560, 201);
            this.DetailTB.Multiline = true;
            this.DetailTB.Name = "DetailTB";
            this.DetailTB.Size = new System.Drawing.Size(310, 375);
            this.DetailTB.TabIndex = 19;
            this.DetailTB.TextChanged += new System.EventHandler(this.DetailTB_TextChanged);
            // 
            // GRNPB1
            // 
            this.GRNPB1.Location = new System.Drawing.Point(-1, 31);
            this.GRNPB1.Name = "GRNPB1";
            this.GRNPB1.Size = new System.Drawing.Size(415, 78);
            this.GRNPB1.TabIndex = 32;
            this.GRNPB1.TabStop = false;
            // 
            // GRNPB2
            // 
            this.GRNPB2.Location = new System.Drawing.Point(560, 31);
            this.GRNPB2.Name = "GRNPB2";
            this.GRNPB2.Size = new System.Drawing.Size(781, 78);
            this.GRNPB2.TabIndex = 33;
            this.GRNPB2.TabStop = false;
            // 
            // GRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 780);
            this.Controls.Add(this.GRNPB2);
            this.Controls.Add(this.GRNPB1);
            this.Controls.Add(this.DetailTB);
            this.Controls.Add(this.PQuantityTB);
            this.Controls.Add(this.PQuantity);
            this.Controls.Add(this.PModelTB);
            this.Controls.Add(this.PModel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalTB);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.VNameTB);
            this.Controls.Add(this.VName);
            this.Controls.Add(this.DDateTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GRNDate);
            this.Controls.Add(this.CreateGRN);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.GRNnoTB);
            this.Controls.Add(this.POIDCombo);
            this.Controls.Add(this.GRNno);
            this.Controls.Add(this.DeptName);
            this.Location = new System.Drawing.Point(468, 0);
            this.Name = "GRN";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GRN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRNPB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRNPB2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateGRN;
        private System.Windows.Forms.Label GRNDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox GRNnoTB;
        private System.Windows.Forms.ComboBox POIDCombo;
        private System.Windows.Forms.Label GRNno;
        private System.Windows.Forms.Label DeptName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DDateTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox VNameTB;
        private System.Windows.Forms.Label VName;
        private System.Windows.Forms.TextBox TotalTB;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PModelTB;
        private System.Windows.Forms.Label PModel;
        private System.Windows.Forms.TextBox PQuantityTB;
        private System.Windows.Forms.Label PQuantity;
        private System.Windows.Forms.TextBox DetailTB;
        private System.Windows.Forms.PictureBox GRNPB1;
        private System.Windows.Forms.PictureBox GRNPB2;
    }
}