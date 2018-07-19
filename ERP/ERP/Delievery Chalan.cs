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
    public partial class Delievery_Chalan : Form
    {
        My_Conn f2 = new My_Conn();
        int count = 0;
        public Delievery_Chalan()
        {
            InitializeComponent();
        }

        private void Delievery_Chalan_Load(object sender, EventArgs e)
        {

            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = Color.Wheat;
            this.ControlBox = false;
            CreateDC.BackColor = Color.SaddleBrown;
            CreateDC.ForeColor = Color.White;
            CreateDC.Cursor = Cursors.Hand;
            CreateDC.FlatStyle = FlatStyle.Popup;
            SOIDCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            DCPB1.BackColor = Color.SaddleBrown;
            DCPB2.BackColor = Color.SaddleBrown;
            DCnoTB.ReadOnly = true;
            DDateTB.ReadOnly = true;
            CNameTB.ReadOnly = true;
            TotalTB.ReadOnly = true;
            DetailTB.ReadOnly = true;
            CreateDC.Enabled = false;

            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select SOID from SO", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SOIDCombo.Items.Add(dr["SOID"]).ToString(); ;
            }
            f2.oleDbConnection1.Close();
        }

        private void SOIDCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();

            // Populate SOID
            OleDbCommand cmd = new OleDbCommand("Select * from SO where SOID = @SOID", f2.oleDbConnection1);
            cmd.Parameters.AddWithValue("@DDate", SOIDCombo.Text);
            cmd.Parameters.AddWithValue("@CName", SOIDCombo.Text);
            cmd.Parameters.AddWithValue("@TotalAmount", SOIDCombo.Text);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                CNameTB.Text = dr["CName"].ToString();
                DDateTB.Text = dr["DDate"].ToString();
                TotalTB.Text = dr["TotalAmount"].ToString();
            }

            // Populate DCID
            OleDbCommand ccmd = new OleDbCommand("Select count (DCID) from DChalan where CName = @CName", f2.oleDbConnection1);
            ccmd.Parameters.AddWithValue("@CName", SOIDCombo.Text);


            OleDbDataReader d = ccmd.ExecuteReader();

            if (d.Read())
            {
                count = Convert.ToInt32(d[0]);
                count += 1;
            }
            DCnoTB.Text = CNameTB.Text + "-0" + count.ToString() + "-" + System.DateTime.Today.Year;

            //Select PModel & PQty
            OleDbCommand cmmd = new OleDbCommand("Select * from SOProduct where SOID = @SOID ", f2.oleDbConnection1);
            cmmd.Parameters.AddWithValue("@SOID", SOIDCombo.Text);
            //cmmd.Parameters.AddWithValue("@PQty", SOIDCombo.Text);
            OleDbDataReader drr = cmmd.ExecuteReader();

            if (drr.Read())
            {
                PModelTB.Text = drr["Pid"].ToString();
                PQuantityTB.Text = drr["PQty"].ToString();
            }


            DetailTB.Text += DCNo.Text + DCnoTB.Text + Environment.NewLine;
            DetailTB.Text += CName.Text + CNameTB.Text + Environment.NewLine;
            DetailTB.Text += PModel.Text + PModelTB.Text + Environment.NewLine;
            DetailTB.Text += PQuantity.Text + PQuantityTB.Text + Environment.NewLine;
            DetailTB.Text += Total.Text + TotalTB.Text + Environment.NewLine;

            f2.oleDbConnection1.Close();
        }

        private void DetailTB_TextChanged(object sender, EventArgs e)
        {
            CreateDC.Enabled = true;
        }

        private void CreateDC_Click(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();

            // Insertion in DChalan
            OleDbCommand cmd = new OleDbCommand("Insert into DChalan (SOID,DCID,DDate,DCDate,CName,TotalAmount) values (@SOID,@DCID,@DDate,@DCDate,@CName,@TotalAmount)", f2.oleDbConnection1);

            cmd.Parameters.AddWithValue("@SOID", SOIDCombo.Text);
            cmd.Parameters.AddWithValue("@DCID", DCnoTB.Text);
            cmd.Parameters.AddWithValue("@DDate", DDateTB.Text);
            cmd.Parameters.AddWithValue("@DCDate", dateTimePicker2);
            cmd.Parameters.AddWithValue("@CName", CNameTB.Text);
            cmd.Parameters.AddWithValue("@TotalAmount", TotalTB.Text);

            cmd.ExecuteNonQuery();

            // Insertion in GRNProducts
            OleDbCommand cd = new OleDbCommand("Insert into DCProduct (DCID,PModel,PQty) values (@DCID,@PModel,@PQty)", f2.oleDbConnection1);
            cd.Parameters.AddWithValue("@DCID", DCnoTB.Text);
            cd.Parameters.AddWithValue("@PModel", PModelTB.Text);
            cd.Parameters.AddWithValue("@PQty", PQuantityTB.Text);

            cd.ExecuteNonQuery();
            MessageBox.Show("Transiction has been done !!", "Delievery Chalan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            f2.oleDbConnection1.Close();
        }
    }
}
