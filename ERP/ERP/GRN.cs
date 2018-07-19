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
    public partial class GRN : Form
    {
        My_Conn f2 = new My_Conn();
        int count = 0;
        public GRN()
        {
            InitializeComponent();
        }

        private void GRN_Load(object sender, EventArgs e)
        {
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = Color.Wheat;
            this.ControlBox = false;
            CreateGRN.BackColor = Color.SaddleBrown;
            CreateGRN.ForeColor = Color.White;
            CreateGRN.Cursor = Cursors.Hand;
            CreateGRN.FlatStyle = FlatStyle.Popup;
            POIDCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            GRNPB1.BackColor = Color.SaddleBrown;
            GRNPB2.BackColor = Color.SaddleBrown;
            GRNnoTB.ReadOnly = true;
            DDateTB.ReadOnly = true;
            VNameTB.ReadOnly = true;
            TotalTB.ReadOnly = true;
            DetailTB.ReadOnly = true;
            CreateGRN.Enabled = false;

            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select POID from PO", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                POIDCombo.Items.Add(dr["POID"]).ToString(); ;
            }
            f2.oleDbConnection1.Close();
        }

        private void DeptCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();

            // Populate POID
            OleDbCommand cmd = new OleDbCommand("Select * from PO where POID = @POID",f2.oleDbConnection1);
            cmd.Parameters.AddWithValue("@DDate", POIDCombo.Text);
            cmd.Parameters.AddWithValue("@VName", POIDCombo.Text);
            cmd.Parameters.AddWithValue("@TotalAmount",POIDCombo.Text);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                VNameTB.Text = dr["VName"].ToString();
                DDateTB.Text = dr["DDate"].ToString();
                TotalTB.Text = dr["TotalAmount"].ToString();
            }

            // Populate GRNID
            OleDbCommand ccmd = new OleDbCommand("Select count (GRNID) from GRN where VName = @VName", f2.oleDbConnection1);
            ccmd.Parameters.AddWithValue("@VName", POIDCombo.Text);


            OleDbDataReader d = ccmd.ExecuteReader();

            if (d.Read())
            {
                count = Convert.ToInt32(d[0]);
                count += 1;
            }
            GRNnoTB.Text = VNameTB.Text + "-0" + count.ToString() + "-" + System.DateTime.Today.Year;

            //Select PModel & PQty
            OleDbCommand cmmd = new OleDbCommand("Select * from POProducts where POID = @POID ", f2.oleDbConnection1);
            cmmd.Parameters.AddWithValue("@POID", POIDCombo.Text);
            //cmmd.Parameters.AddWithValue("@POID", POIDCombo.Text);
            OleDbDataReader drr = cmmd.ExecuteReader();

            if (drr.Read())
            {
                PModelTB.Text = drr["Pid"].ToString();
                PQuantityTB.Text = drr["PQty"].ToString();
            }


            DetailTB.Text += GRNno.Text +  GRNnoTB.Text + Environment.NewLine;
            DetailTB.Text += VName.Text +  VNameTB.Text + Environment.NewLine;
            DetailTB.Text += PModel.Text +  PModelTB.Text + Environment.NewLine;
            DetailTB.Text += PQuantity.Text +  PQuantityTB.Text + Environment.NewLine;
            DetailTB.Text += Total.Text  +  TotalTB.Text + Environment.NewLine;

            f2.oleDbConnection1.Close();
            //CreateGRN.Enabled = true;
        }

        private void CreateGRN_Click(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();

            // Insertion in GRN
            OleDbCommand cmd = new OleDbCommand("Insert into GRN (POID,GRNID,DDate,GRDate,VName,TotalAmount) values (@POID,@GRNID,@DDate,@GRDate,@VName,@TotalAmount)", f2.oleDbConnection1);

            cmd.Parameters.AddWithValue("@POID", POIDCombo.Text);
            cmd.Parameters.AddWithValue("@GRNID", GRNnoTB.Text);
            cmd.Parameters.AddWithValue("@DDate",DDateTB.Text);
            cmd.Parameters.AddWithValue("@GRDate", dateTimePicker2);
            cmd.Parameters.AddWithValue("@VName",VNameTB.Text);
            cmd.Parameters.AddWithValue("@TotalAmount", TotalTB.Text);

            cmd.ExecuteNonQuery();

            // Insertion in GRNProducts
            OleDbCommand cd = new OleDbCommand("Insert into GRNProducts(GRNID,PModel,PQty) values (@GRNID,@PModel,@PQty)", f2.oleDbConnection1);
            cd.Parameters.AddWithValue("@GRNID", GRNnoTB.Text);
            cd.Parameters.AddWithValue("@PModel", PModelTB.Text);
            cd.Parameters.AddWithValue("@PQty", PQuantityTB.Text);

            cd.ExecuteNonQuery();
            MessageBox.Show("Transiction has been done !!", "GRN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            f2.oleDbConnection1.Close();
        }

        private void DetailTB_TextChanged(object sender, EventArgs e)
        {
            CreateGRN.Enabled = true;
        }

    }
}
