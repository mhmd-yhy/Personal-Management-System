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
    public partial class FrmGiris : Form
    {
        static string strConn = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        SqlConnection Conn = new SqlConnection(strConn);
        private string kullaniciAdi;
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FrmGiris_Load(object sender, EventArgs e)
        {
        }

        private void TxtKullanıcı_MouseDown(object sender, MouseEventArgs e)
        {
            TxtKullanici.SelectAll();
            TxtKullanici.Text = "";
        }

        private void TxtSifre_MouseDown(object sender, MouseEventArgs e)
        {
            TxtSifre.SelectAll();
            TxtSifre.Text = "";
            TxtSifre.PasswordChar = '*';
            TxtSifre.UseSystemPasswordChar = true;
            CbxSifreGoster.Checked = false;
        }
        private void TxtSifre_TabStopChanged(object sender, EventArgs e)
        {
            TxtSifre.SelectAll();
            TxtSifre.Text = "";
            TxtSifre.UseSystemPasswordChar = true;
            CbxSifreGoster.Checked = false;
            TxtSifre.PasswordChar = '*';
        }
        private void CbxSifreGoster_OnChange(object sender, EventArgs e)
        {
            if (CbxSifreGoster.Checked)
            {
                TxtSifre.PasswordChar = '\0';
                TxtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                TxtSifre.PasswordChar = '*';
                TxtSifre.UseSystemPasswordChar = true;
            }
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtKullanici.Text == "")
                {
                    FrmMessageBox.Show("Kullanıcı Adı Giriniz!", "Gırış Yap", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtKullanici.Focus();
                    TxtKullanici.SelectAll();
                    TxtKullanici.BorderStyle = BorderStyle.Fixed3D;
                    return;
                }
                if (TxtSifre.Text == "")
                {
                    FrmMessageBox.Show("Şifreyi giriniz!", "Gırış Yap", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtSifre.Focus();
                    TxtSifre.BorderStyle = BorderStyle.Fixed3D;
                    return;
                }

                string basvur = "Select * From Giris Where KullaniciAdi = '" + TxtKullanici.Text + "'";
                SqlCommand Cmd = new SqlCommand(basvur, Conn);
                SqlDataReader Reader;
                Conn.Open();
                Reader = Cmd.ExecuteReader();
                if (Reader.Read())
                {
                    if ((string)Reader.GetValue(2) == TxtSifre.Text)
                    {
                        kullaniciAdi = TxtKullanici.Text; //// EnCapculation
                        AnaSayfa anaSayfa = new AnaSayfa();
                        this.Hide();
                        anaSayfa.Show();
                    }
                    else FrmMessageBox.Show("Şifre Yanlıştır!", "Gırış Yap", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else FrmMessageBox.Show("Yetkili Değilsiniz!", "Gırış Yap", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Conn.Close();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
        
        private Form frm;
        private void LblSifreUnuttum_Click(object sender, EventArgs e)
        {
            FrmSifreDegistir frm = new FrmSifreDegistir();
            this.Hide();
            frm.Show();
        }

        void Btn_Click(object sender, EventArgs e)
        {
            frm.Hide();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
