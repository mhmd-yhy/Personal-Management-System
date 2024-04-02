using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Personel_Bilgileri
{
    public partial class Ucretler : Form
    {
        static string strConn = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        SqlConnection Conn = new SqlConnection(strConn);
        public Ucretler()
        {
            InitializeComponent();
        }
        private void Ucretler_Load(object sender, EventArgs e)
        {
            Data();
            DataGridViewBTN();
            StyleDataGridView();

        }
        void Data()
        {
            string basvur = "Select P.ID, P.TC, P.Isim + ' ' + P.Soyad As Isim, P.Tel, G.Gorev, P.Ucret From Person P INNER JOIN Gorev G ON P.GorevID = G.GorevID;";
            SqlDataAdapter da = new SqlDataAdapter(basvur, Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersWidth = (4 * dataGridView1.Width) / 100;
            dataGridView1.Columns[0].Width = (5 * dataGridView1.Width) / 100;
            dataGridView1.Columns[1].Width = (9 * dataGridView1.Width) / 100;
            dataGridView1.Columns[2].Width = (25 * dataGridView1.Width) / 100;
            dataGridView1.Columns[3].Width = (20 * dataGridView1.Width) / 100;
            dataGridView1.Columns[4].Width = (15 * dataGridView1.Width) / 100;
            dataGridView1.Columns[5].Width = (10 * dataGridView1.Width) / 100;
        }
        void DataGridViewBTN()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Button";
            btn.Name = "BtnOde";
            btn.Text = "Öde";
            btn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btn.UseColumnTextForButtonValue = true;
            //btn.Visible = false;
            dataGridView1.Columns.Add(btn);
        }
        void StyleDataGridView()
        {
            //Column Header
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 46, 61);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 224, 200);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);
            dataGridView1.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 5, 0, 5);
            //Row Header
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 46, 61);
            dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(13, 31, 45);
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            //Column
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(13, 31, 45);
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(29, 46, 61);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.Padding = new Padding(0, 10, 0, 10);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(53, 70, 86);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 224, 200);
            dataGridView1.EnableHeadersVisualStyles = false;
            //dataGridView1.ScrollBars = ScrollBars.Both;

        }
        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            this.Hide();
            anasayfa.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnUcretYonet_Click(object sender, EventArgs e)
        {
            FrmDenetim denetim = new FrmDenetim();
            this.Hide();
            denetim.Show();
        }

        private void TxtAra_MouseDown(object sender, MouseEventArgs e)
        {
            TxtAra.SelectAll();
        }

        private void TxtAra_TextChanged(object sender, EventArgs e)
        {
            if (TxtAra.Text != "")
            {
                string basvur = "Select P.ID, P.TC, P.Isim + ' ' + P.Soyad As Isim, P.Tel, G.Gorev, P.Ucret From Person P INNER JOIN Gorev G ON P.GorevID = G.GorevID Where Isim LIKE '%" + TxtAra.Text + "%' OR Soyad LIKE '%" + TxtAra.Text + "%';";
                SqlDataAdapter da = new SqlDataAdapter(basvur, Conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                Data();
            }
        }

        private void BtnGörüntüle_Click(object sender, EventArgs e)
        {
            string TC = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            FormKisiGoruntule Goruntule = new FormKisiGoruntule(TC);
            this.Close();
            Goruntule.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SaatTarih.Text = DateTime.Now.ToString("");
        }

        private void CmbAylar_SelectedValueChanged(object sender, EventArgs e)
        {
            UcretlerGoster();
        }
        void UcretlerGoster()
        {
            string basvur;
            basvur = "Select SUM(Ucret) from Person Where ID Not IN (Select PersonID From Ucretler Where Ay = '" + CmbAylar.Text + "')";
            SqlCommand Cmd = new SqlCommand(basvur, Conn);
            SqlDataReader Reader;
            Conn.Open();
            Reader = Cmd.ExecuteReader();
            if (Reader.Read())
            {
                if (Reader.GetValue(0) == System.DBNull.Value) UcretlerTop.Text = 0.ToString();
                else UcretlerTop.Text = Reader.GetValue(0).ToString();
            }
            Conn.Close();
        }

        private void BtnTumOde_Click(object sender, EventArgs e)
        {
            if (CmbAylar.Text == "") return;
            List<int> ides = new List<int>();
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                ides.Add(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value));

            string basvur = "";
            SqlCommand Cmd;
            SqlDataReader Reader;
            foreach (int id in ides)
            {
                string basvurKontrol = "Select Ay From Ucretler Where PersonID = " + id + " AND Ay = '" + CmbAylar.Text + "'";
                Cmd = new SqlCommand(basvurKontrol, Conn);
                Conn.Open();
                Reader = Cmd.ExecuteReader();
                if (!Reader.Read())
                    basvur += "insert into Ucretler values((Select Ucret From Person Where ID = " + id + "),'" + CmbAylar.Text + "'," + id + ")";
                Conn.Close();
            }
            if(basvur != "")
            {
                Cmd = new SqlCommand(basvur, Conn);
                Conn.Open();
                Cmd.ExecuteNonQuery();
                Conn.Close();
                FrmMessageBox.Show("Tüm personellerin ucretleri ödenmiş", "Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UcretlerGoster();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 6) MessageBox.Show(e.RowIndex.ToString());
            
            if (CmbAylar.Text != "")
            {
                //string basvur2 = "IF NOT EXISTS (Select UcretID From Ucretler Where Ay = '" + CmbAylar.Text + "' AND PersonID = " + ID + ")" +
                //            "BEGIN Insert Into Ucretler values(" + Ucret + ", '" + CmbAylar.Text + "', " + ID + ") END";
                if (e.ColumnIndex == 6)
                {
                    //MessageBox.Show(e.RowIndex.ToString());
                    int ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    double Ucret = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                    string basvur2 = "Insert Into Ucretler values(" + Ucret + ", '" + CmbAylar.Text + "', " + ID + ")";
                    SqlCommand Cmd;
                    string basvur = "Select UcretID From Ucretler Where Ay = '" + CmbAylar.Text + "' AND PersonID = " + ID;
                    Cmd = new SqlCommand(basvur, Conn);
                    SqlDataReader Reader;
                    Conn.Open();
                    Reader = Cmd.ExecuteReader();
                    if (!Reader.Read())
                    {
                        Conn.Close();
                        Cmd = new SqlCommand(basvur2, Conn);
                        Conn.Open();
                        Cmd.ExecuteNonQuery();
                        Conn.Close();
                        FrmMessageBox.Show("personel ucreti ödenmiş", "Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else FrmMessageBox.Show("personel ucreti önceden ödenmiş", "Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Conn.Close();

                    UcretlerGoster();
                }
            }
        }
    }
}
