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
    public partial class Personeller : Form
    {
        static string strConn = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        SqlConnection Conn = new SqlConnection(strConn);
        public Personeller()
        {
            InitializeComponent();
        }
        private void Personeller_Load(object sender, EventArgs e)
        {
            Data();
            StyleDataGridView();
        }
        void Data()
        {
            string basvur = "Select P.ID, P.TC, P.Isim, P.Soyad, P.Cinsiyet, P.MedeniDurumu, P.Tel, G.Gorev, P.Ucret From Person P INNER JOIN Gorev G ON P.GorevID = G.GorevID;";
            SqlDataAdapter da = new SqlDataAdapter(basvur, Conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersWidth = (2 * dataGridView1.Width) / 100;
            dataGridView1.Columns[0].Width = (5 * dataGridView1.Width) / 100;
            dataGridView1.Columns[1].Width = (9 * dataGridView1.Width) / 100;
            dataGridView1.Columns[2].Width = (13 * dataGridView1.Width) / 100;
            dataGridView1.Columns[3].Width = (13 * dataGridView1.Width) / 100;
            dataGridView1.Columns[4].Width = (8 * dataGridView1.Width) / 100;
            dataGridView1.Columns[5].Width = (15 * dataGridView1.Width) / 100;
            dataGridView1.Columns[6].Width = (15 * dataGridView1.Width) / 100;
            dataGridView1.Columns[7].Width = (10 * dataGridView1.Width) / 100;
            dataGridView1.Columns[8].Width = (10 * dataGridView1.Width) / 100;
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
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            this.Close();
            anaSayfa.Show();
        }

        private void BtnGörüntüle_Click(object sender, EventArgs e)
        {
            string TC = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            FormKisiGoruntule Goruntule = new FormKisiGoruntule(TC);
            this.Close();
            Goruntule.Show();
            
        }

        private void TxtAra_MouseDown(object sender, MouseEventArgs e)
        {
            TxtAra.SelectAll();
        }

        private void TxtAra_TextChanged(object sender, EventArgs e)
        {
            if(TxtAra.Text != "")
            {
                string basvur = "Select P.ID, P.TC, P.Isim, P.Soyad, P.Cinsiyet, P.MedeniDurumu, P.Tel, G.Gorev, p.Ucret From Person P INNER JOIN Gorev G ON P.GorevID = G.GorevID Where Isim LIKE '%" + TxtAra.Text + "%' OR Soyad LIKE '%" + TxtAra.Text + "%';";
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SaatTarih.Text = DateTime.Now.ToString("");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
