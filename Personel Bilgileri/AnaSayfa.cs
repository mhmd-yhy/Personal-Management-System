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
using System.IO;
using System.Drawing.Imaging;

namespace Personel_Bilgileri
{
    public partial class AnaSayfa : Form
    {
        static string strConn = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        SqlConnection Conn = new SqlConnection(strConn);
        public AnaSayfa()
        {
            InitializeComponent();
        }
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
        }

        private void BtnÇıkıs_Click(object sender, EventArgs e)
        {
            try
            {
                FrmGiris g = new FrmGiris();
                this.Close();
                g.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SaatTarih.Text = DateTime.Now.ToString("");
        }

        void mood()
        {
            ///Form
            this.BackColor = Color.FromArgb(245, 239, 231);
            this.ForeColor = Color.FromArgb(103, 86, 64);
            foreach (Control C in this.Controls)
            {
                ////Buttons
                if (C is Button || C is Panel)
                {
                    C.BackColor = Color.FromArgb(199, 178, 153);
                    C.ForeColor = Color.Black;
                }
                if (C is Label) C.ForeColor = Color.FromArgb(103, 86, 64);
                if (C is TextBox || C is MaskedTextBox || C is PictureBox)
                {
                    C.BackColor = Color.FromArgb(235, 229, 221);
                }
                ///panel2
                foreach (Control x in panel2.Controls)
                {
                    x.ForeColor = Color.Black;
                }
            }
        }
        string TC;
        private void BtnAra_Click(object sender, EventArgs e)
        {
            try
            {
                Ep.Clear();
                if (TxtTC.Text == "")
                {
                    Ep.SetError(TxtTC, "bos olamaz");
                    FrmMessageBox.Show("TC giriniz.", "Aramak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtTC.Focus();
                }
                else
                {
                    string basvur = "Select * From Person Where TC =" + TxtTC.Text;
                    SqlCommand Cmd = new SqlCommand(basvur, Conn);
                    SqlDataReader Reader;
                    Conn.Open();
                    Reader = Cmd.ExecuteReader();
                    if (Reader.Read())
                    {
                        TxtIsim.Text = (string)Reader.GetValue(2);
                        TxtSoyad.Text = (string)Reader.GetValue(3);
                        TC = TxtTC.Text;

                        if (Reader.GetValue(15) != System.DBNull.Value)
                        {
                            byte[] pic = (byte[])Reader.GetValue(15);
                            MemoryStream ms = new MemoryStream(pic);
                            Image img = Image.FromStream(ms);
                            KisiFotograf.Image = img;
                        }
                        BtnAra.Enabled = false;
                        BtnGörüntüle.Visible = true;
                    }
                    else
                    {
                        DialogResult dr;
                        dr = FrmMessageBox.Show("Kişi Bulunmamaktadır!", "Arama", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Cancel)
                        {
                            TxtTC.Text = null;
                            TxtTC.Focus();
                        }
                        else
                        {
                            TxtTC.Focus();
                            TxtTC.SelectAll();
                        }
                    }
                    Conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void BtnGörüntüle_Click(object sender, EventArgs e)
        {
            try
            {
                FormKisiGoruntule Goruntule = new FormKisiGoruntule(TC);
                this.Hide();
                Goruntule.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnYeniEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Form frm = new FormYeniEkle();
                this.Hide();
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in this.panel1.Controls)
                {
                    if (c is TextBox || c is MaskedTextBox) c.Text = "";
                }
                KisiFotograf.Image = new PictureBox().Image;
                BtnGörüntüle.Visible = false;
                BtnAra.Enabled = true;
                TxtTC.Focus();
                Ep.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnPersoneller_Click(object sender, EventArgs e)
        {
            Personeller per = new Personeller();
            this.Hide();
            per.Show();
        }
        private void TxtTC_MouseDown(object sender, MouseEventArgs e)
        {
            TxtTC.SelectAll();
        }

        private void BtnDenetim_Click(object sender, EventArgs e)
        {
            FrmDenetim denetim = new FrmDenetim();
            this.Hide();
            denetim.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ucretler_Click(object sender, EventArgs e)
        {
            Ucretler ucretler = new Ucretler();
            this.Hide();
            ucretler.Show();
        }
    }
}
