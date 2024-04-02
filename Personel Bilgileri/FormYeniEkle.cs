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
using System.Drawing.Text;

namespace Personel_Bilgileri
{
    public partial class FormYeniEkle : Form
    {
        static string sqlConn = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        static SqlConnection Conn = new SqlConnection(sqlConn);
        public FormYeniEkle()
        {
            InitializeComponent();
        }
        private void FormYeniEkle_Load(object sender, EventArgs e)
        {
            comboboxData();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void comboboxData()
        {
            try
            {
                string basvur = "Select Country From Countries;Select Egitim From EgitimDurumu;Select Gorev From Gorev";
                SqlDataAdapter da = new SqlDataAdapter(basvur, Conn);
                DataSet ds = new DataSet();
                da.Fill(ds);


                CmbUyruk.DataSource = ds.Tables[0];
                CmbUyruk.DisplayMember = "Country";
                
                CmbEgitimDurumu.DataSource = ds.Tables[1];
                CmbEgitimDurumu.DisplayMember = "Egitim";
                CmbIs.DataSource = ds.Tables[2];
                CmbIs.DisplayMember = "Gorev";

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
        
        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            try
            {
                AnaSayfa anaSayfa = new AnaSayfa();
                this.Close();
                anaSayfa.Show();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        public void Temizle()
        {
            try
            {
                foreach (Control c in panel12.Controls)
                {
                    if (c is TextBox || c is MaskedTextBox || c is DateTimePicker)
                    {
                        c.Text = new TextBox().Text;
                    }
                }
                TxtTC.Focus();
                RdbKadın.Checked = false;
                RdbErkek.Checked = false;
                RdbBekar.Checked = false;
                RdbEvli.Checked = false;
                LblKadınErkek.Text = "";
                LblBekarEvli.Text = "";
                DtpDogumTarihi.Value = new DateTime(1970, 01, 01);
                KisiFotograf.Image = new PictureBox().Image;
                comboboxData();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }

        private void BtnFotgrafSec_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OFD = new OpenFileDialog();
                OFD.Title = "Fotoğraf Seç";
                OFD.Filter = "Fotoğraf|*.jpg;*.png;*.jpeg";
                OFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    FrmMessageBox.Show("Fotoğraf Eklendi.", "Yeni Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KisiFotograf.Image = Image.FromFile(OFD.FileName);
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtTC.Text == "")
                {
                    FrmMessageBox.Show("TC Giriniz!", "Yeni Ekle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtTC.Focus();
                    TxtTC.SelectAll();
                    TxtTC.BorderStyle = BorderStyle.Fixed3D;
                    return;
                }
                if (TxtIsim.Text == "")
                {
                    FrmMessageBox.Show("Isim giriniz!", "Yeni Ekle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtIsim.Focus();
                    TxtIsim.BorderStyle = BorderStyle.Fixed3D;
                    return;
                }

                if (TxtSoyad.Text == "")
                {
                    FrmMessageBox.Show("Soyad giriniz!", "Yeni Ekle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtSoyad.Focus();
                    TxtSoyad.BorderStyle = BorderStyle.Fixed3D;
                    return;
                }
                if (LblKadınErkek.Text == "")
                {
                    FrmMessageBox.Show("Cinsiyet giriniz!", "Yeni Ekle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    panel3.BorderStyle = BorderStyle.FixedSingle;
                    return;
                }
                if (LblBekarEvli.Text == "")
                {
                    FrmMessageBox.Show("Medeni Durumu giriniz!", "Yeni Ekle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    panel4.BorderStyle = BorderStyle.FixedSingle;
                    return;
                }
                if (TxtUcret.Text == "")
                {
                    FrmMessageBox.Show("Ucret giriniz!", "Yeni Ekle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUcret.BorderStyle = BorderStyle.FixedSingle;
                    return;
                }

                DialogResult dr;
                bool kontrol = false;
                string basvur;
                SqlCommand Cmd;

                basvur = "Select * From Person Where TC =" + TxtTC.Text;
                Cmd = new SqlCommand(basvur, Conn);
                SqlDataReader Reader;
                Conn.Open();
                Reader = Cmd.ExecuteReader();

                if (Reader.Read())
                {
                    FrmMessageBox.Show("TC Numarasi Mevcuttur! , Yine Deneyin.", "Yeni Ekle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtTC.SelectAll();
                    kontrol = true;
                }
                Conn.Close();
                if (kontrol == false)
                {
                    dr = FrmMessageBox.Show("Kaydetmek istiyor misiniz ?", "Yeni Ekle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        Conn.Open();
                        basvur = "INSERT INTO Person (TC, Isim, Soyad, DogumYeri, DogumTarihi, Cinsiyet, MedeniDurumu, UyruguID, EgitimID, Tel, Email, Adress, GorevID, Ucret, KayitTarihi) VALUES(@TC, @Isim, @Soyad, @DogumYeri, @DogumTarihi, @Cinsiyet, @MedeniDurumu, @UyruguID, @EgitimID, @Tel, @Email, @Adress, @GorevID, @Ucret, @KayitTarihi)";
                        if (KisiFotograf.Image != null)
                        {
                            basvur = "INSERT INTO Person (TC, Isim, Soyad, DogumYeri, DogumTarihi, Cinsiyet, MedeniDurumu, UyruguID, EgitimID, Tel, Email, Adress, GorevID, Ucret, Fotograf, KayitTarihi) VALUES(@TC, @Isim, @Soyad, @DogumYeri, @DogumTarihi, @Cinsiyet, @MedeniDurumu, @UyruguID, @EgitimID, @Tel, @Email, @Adress, @GorevID, @Ucret, @Fotograf, @KayitTarihi)";
                        }
                        
                        Cmd = new SqlCommand(basvur, Conn);
                        Cmd.Parameters.AddWithValue("@TC", TxtTC.Text);
                        Cmd.Parameters.AddWithValue("@Isim", TxtIsim.Text);
                        Cmd.Parameters.AddWithValue("@Soyad", TxtSoyad.Text);
                        Cmd.Parameters.AddWithValue("@DogumYeri", TxtDogumYeri.Text);
                        Cmd.Parameters.AddWithValue("@DogumTarihi", DtpDogumTarihi.Value);
                        Cmd.Parameters.AddWithValue("@Cinsiyet", LblKadınErkek.Text);
                        Cmd.Parameters.AddWithValue("@MedeniDurumu", LblBekarEvli.Text);
                        //int index = CmbUyruk.SelectedIndex;
                        Cmd.Parameters.AddWithValue("@UyruguID", CmbUyruk.SelectedIndex + 1);
                        Cmd.Parameters.AddWithValue("@EgitimID", CmbEgitimDurumu.SelectedIndex + 1);
                        Cmd.Parameters.AddWithValue("@Tel", TxtTel.Text);
                        Cmd.Parameters.AddWithValue("@Email", TxtEmail.Text);
                        Cmd.Parameters.AddWithValue("@Adress", TxtAdress.Text);
                        Cmd.Parameters.AddWithValue("@GorevID", CmbIs.SelectedIndex + 1);
                        Cmd.Parameters.AddWithValue("@Ucret", TxtUcret.Text);
                        Cmd.Parameters.AddWithValue("@KayitTarihi", KayitTarihi.Text);
                        if (KisiFotograf.Image != null)
                        {
                            MemoryStream ms = new MemoryStream();
                            KisiFotograf.Image.Save(ms, ImageFormat.Png);
                            var pic = ms.ToArray();
                            Cmd.Parameters.AddWithValue("@Fotograf", pic);
                        }
                        else
                        {
                            Cmd.Parameters.AddWithValue("@Fotograf", SqlDbType.Image).Value = DBNull.Value;
                        }
                        Cmd.ExecuteNonQuery();
                        Conn.Close();
                        DialogResult result = FrmMessageBox.Show("Kisi Eklendi.", "Yeni Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                    }
                }
                Conn.Close();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }

        private void TxtTC_TextChanged(object sender, EventArgs e)
        {
            textIsNotNullChecked(sender, e);
        }
        private void TxtIsim_TextChanged(object sender, EventArgs e)
        {
            textIsNotNullChecked(sender, e);
        }
        private void TxtSoyad_TextChanged(object sender, EventArgs e)
        {
            textIsNotNullChecked(sender, e);
        }

        void textIsNotNullChecked(object sender, EventArgs e)
        {
            if (TxtTC.TextLength > 0)
            {
                TxtTC.BorderStyle = BorderStyle.FixedSingle;
            }
            if (TxtIsim.TextLength > 0)
            {
                TxtIsim.BorderStyle = BorderStyle.FixedSingle;
            }
            if (TxtSoyad.TextLength > 0)
            {
                TxtSoyad.BorderStyle = BorderStyle.FixedSingle;
            }
        }
        private void TxtTC_MouseDown(object sender, MouseEventArgs e)
        {
            TxtTC.SelectAll();
        }
        private void TxtTel_MouseDown(object sender, MouseEventArgs e)
        {
            TxtTel.SelectAll();
        }
        private void TxtUcret_MouseDown(object sender, MouseEventArgs e)
        {
            TxtUcret.SelectAll();
        }
        private void RdbKadın_CheckedChanged(object sender, EventArgs e)
        {
            LblKadınErkek.Text = "Kadın";
            panel3.BorderStyle = BorderStyle.None;
        }
        private void RdbErkek_CheckedChanged(object sender, EventArgs e)
        {
            LblKadınErkek.Text = "Erkek";
            panel3.BorderStyle = BorderStyle.None;
        }
        private void RdbBekar_CheckedChanged(object sender, EventArgs e)
        {
            LblBekarEvli.Text = "Bekar";
            panel4.BorderStyle = BorderStyle.None;
        }
        private void RdbEvli_CheckedChanged(object sender, EventArgs e)
        {
            LblBekarEvli.Text = "Evli";
            panel4.BorderStyle = BorderStyle.None;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            KayitTarihi.Text = DateTime.Now.ToString("dd/MM/yyyy");
            SaatTarih.Text = DateTime.Now.ToString("");
        }
    }
}
