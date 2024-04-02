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
    public partial class FrmSifreDegistir : Form
    {
        static string Sql = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        SqlConnection Conn = new SqlConnection(Sql);
        public FrmSifreDegistir()
        {
            InitializeComponent();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            FrmGiris g = new FrmGiris();
            this.Hide();
            g.Show();
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            string basvur = "Select * From Giris Where KullaniciAdi = '" + TxtKullanici.Text + "'";
            SqlCommand Cmd = new SqlCommand(basvur, Conn);
            SqlDataReader Reader;
            Conn.Open();
            Reader = Cmd.ExecuteReader();
            if (Reader.Read())
            {
                if (TxtDogumYeri.Text == Reader.GetValue(3).ToString())
                {
                    TxtSifre.Enabled = true;
                    FrmMessageBox.Show("Yeni şifre girebilirsiniz..", "Şifre Değiştirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else FrmMessageBox.Show("Doğum yeri yanlıştır.", "Şifre Değiştirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmMessageBox.Show("Kullanıcı mevcut değildir.", "Şifre Değiştirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtKullanici.Focus();
            }
            Conn.Close();
        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {
            if (TxtSifre.TextLength > 0) BtnUygula.Visible = true;
            else BtnUygula.Visible = false;
        }

        private void BtnUygula_Click(object sender, EventArgs e)
        {
            string basvur = "Update Giris Set Sifre = '" + TxtSifre.Text + "' Where KullaniciAdi = '" + TxtKullanici.Text + "'";
            SqlCommand Cmd = new SqlCommand(basvur, Conn);
            Conn.Open();
            Cmd.ExecuteNonQuery();
            Conn.Close();
            FrmMessageBox.Show("Şifreyi Değiştirildi.", "Şifre Değiştirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmGiris frm = new FrmGiris();
            this.Hide();
            frm.Show();
        }
    }
}
