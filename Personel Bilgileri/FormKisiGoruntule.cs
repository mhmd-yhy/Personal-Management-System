using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
    public partial class FormKisiGoruntule : Form
    {
        static string strConn = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        SqlConnection Conn = new SqlConnection(strConn);
        public FormKisiGoruntule()
        {
            InitializeComponent();
        }
        private string TC;
        public FormKisiGoruntule(string TC)
        {
            InitializeComponent();
            this.TC = TC;
            Data();
            comboboxData();
        }
        void Data()
        {
            string where = "From Person Where TC =" + TC + "";
            string basvur = "Select * From Person Where TC =" + TC + "; Select Country From Countries Where ID = (Select UyruguID " + where + "); Select Egitim From EgitimDurumu Where EgitimID = (Select EgitimID " + where + "); Select Gorev From Gorev Where GorevID = (Select GorevID " + where + ");Select SUM(Ucret) From Ucretler Where PersonID = (Select ID " + where + ")";
            SqlDataAdapter da = new SqlDataAdapter(basvur, Conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable Person = ds.Tables[0];
            DataRow Uyruk = ds.Tables[1].Rows[0];
            DataRow Egitim = ds.Tables[2].Rows[0];
            DataRow Gorev = ds.Tables[3].Rows[0];
            DataRow UcretTop = ds.Tables[4].Rows[0];

            int index1 = Convert.ToInt32(Person.Rows[0][8]);

            TxtID.Text = Person.Rows[0][0].ToString();
            TxtTC.Text = Person.Rows[0][1].ToString();
            TxtIsim.Text = Person.Rows[0][2].ToString();
            TxtSoyad.Text = Person.Rows[0][3].ToString();
            TxtDoğumYeri.Text = Person.Rows[0][4].ToString();
            DtpDogumTarihi.Text = Person.Rows[0][5].ToString();
            TxtCinsiyet.Text = Person.Rows[0][6].ToString();
            LblKadınErkek.Text = Person.Rows[0][6].ToString();
            TxtMedeniDurumu.Text = Person.Rows[0][7].ToString();
            LblBekarEvli.Text = Person.Rows[0][7].ToString();
            TxtUyruk.Text = Uyruk[0].ToString();
            TxtEgitimDurumu.Text = Egitim[0].ToString();
            TxtTel.Text = Person.Rows[0][10].ToString();
            TxtEmail.Text = Person.Rows[0][11].ToString();
            TxtAdress.Text = Person.Rows[0][12].ToString();
            TxtGorev.Text = Gorev[0].ToString();
            TxtUcret.Text = Person.Rows[0][14].ToString();
            TxtUcretTop.Text = UcretTop[0].ToString();
            KaitTarihi.Text = Person.Rows[0][16].ToString();
            if (Person.Rows[0][15] != System.DBNull.Value)
            {
                byte[] pic = (byte[])Person.Rows[0][15];
                MemoryStream ms = new MemoryStream(pic);
                Image img = Image.FromStream(ms);
                KisiFotograf.Image = img;
            }
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
                CmbGorev.DataSource = ds.Tables[2];
                CmbGorev.DisplayMember = "Gorev";
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
        private void FormKisiGoruntule_Load(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Form", this.Width, this.Height);
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int w = this.Width + 60;
            int h = this.Height;
            Bitmap bmp = new Bitmap(w, h);
            Rectangle rec = new Rectangle(0, 0, w, h);
            this.DrawToBitmap(bmp, rec);
            e.Graphics.DrawImage(bmp, rec);
        }
        private void BtnYazdır_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    if (c is Button)
                    {
                        c.Visible = false;
                    }
                }
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
                foreach (Control c in this.Controls)
                {
                    if (c is Button)
                    {
                        c.Visible = true;
                    }
                }
                BtnIptal.Visible = false;

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
                AnaSayfa frm = new AnaSayfa();
                this.Hide();
                frm.Show();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr;
                dr = FrmMessageBox.Show("Silmek istediğinize emin misiniz ?", "Silmek", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    string basvur = "Delete From Ucretler Where PersonID =" + TxtID.Text;
                    SqlCommand Com = new SqlCommand(basvur, Conn);
                    Conn.Open();
                    Com.ExecuteNonQuery();
                    Conn.Close();
                    basvur = "Delete From Person Where ID =" + TxtID.Text;
                    Com = new SqlCommand(basvur, Conn);
                    Conn.Open();
                    Com.ExecuteNonQuery();
                    Conn.Close();
                    FrmMessageBox.Show("Bilgileri Silindi", "Silmek", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    AnaSayfa anaSayfa = new AnaSayfa();
                    anaSayfa.Show();
                }
                else
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
        private void BtnPersonelleriGöster_Click(object sender, EventArgs e)
        {
            Personeller per = new Personeller();
            this.Close();
            per.Show();
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in this.PnlArticle.Controls)
                    if (c is TextBox || c is MaskedTextBox || c is ComboBox || c is Button || c is DateTimePicker)
                    {
                        c.Visible = true;
                        c.Enabled = true;
                    }
                TxtID.Enabled = false;
                TxtTC.Enabled = false;
                TxtUyruk.Visible = false;
                TxtCinsiyet.Visible = false;
                TxtMedeniDurumu.Visible = false;
                TxtEgitimDurumu.Visible = false;
                TxtGorev.Visible = false;
                foreach (Control c in this.panel4.Controls)
                {
                    if (c is RadioButton) c.Visible = true;
                    else c.Visible = false;
                }
                foreach (Control c in this.panel5.Controls)
                {
                    if (c is RadioButton) c.Visible = true;
                    else c.Visible = false;
                }
                foreach (Control c in this.panel1.Controls)
                    foreach (Control p in c.Controls)
                        if (p is Button)
                        {
                            p.Enabled = false;
                            p.Visible = true;
                        }
                    
                BtnIptal.Enabled = true;
                BtnKaydet.Enabled = true;
                BtnGuncelle.Visible = false;
                BtnSil.Visible = false;
                TxtUcret.Focus();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void BtnIptal_Click(object sender, EventArgs e)
        {
            GuncellemeDurumuKapat();
        }
        void GuncellemeDurumuKapat()
        {
            try
            {
                foreach (Control c in this.PnlArticle.Controls)
                {
                    if (c is TextBox || c is MaskedTextBox || c is ComboBox || c is Button || c is DateTimePicker)
                    {
                        c.Enabled = false;
                        c.Visible = true;
                    }
                    if (c is Button || c is ComboBox) c.Visible = false;
                }
                foreach (Control c in this.panel4.Controls)
                {
                    if (c is RadioButton) c.Visible = false;
                    else c.Visible = true;
                }
                foreach (Control c in this.panel5.Controls)
                {
                    if (c is RadioButton) c.Visible = false;
                    else c.Visible = true;
                }
                LblKadınErkek.Text = "";
                LblBekarEvli.Text = "";
                foreach (Control c in this.PnlArticle.Controls)
                    foreach (Control p in panel1.Controls)
                    {
                        foreach (Control pB in p.Controls)
                        {
                            if (pB is Button)
                            {
                                pB.Enabled = true;
                                pB.Visible = true;
                            }
                        }
                    }
                    
                Header.Visible = true;
                BtnIptal.Enabled = false;
                BtnIptal.Visible = false;
                BtnSil.Enabled = true;
                KisiFotograf.Image = new PictureBox().Image;
                Data();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
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
                    return;
                }
                DialogResult dr;
                dr = FrmMessageBox.Show("Kaydetmek istiyor musunuz ?", "Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    string basvur = "Update Person Set Isim = @Isim, Soyad = @Soyad, DogumYeri = @DogumYeri, DogumTarihi = @DogumTarihi, Cinsiyet = @Cinsiyet, MedeniDurumu = @MedeniDurumu, UyruguID = @UyruguID, EgitimID = @EgitimID, Tel = @Tel, Email = @Email, Adress = @Adress, GorevID = @GorevID, Ucret = @Ucret Where TC = " + TC;
                    if (KisiFotograf.Image != null)
                    {
                        basvur = "Update Person Set Isim = @Isim, Soyad = @Soyad, DogumYeri = @DogumYeri, DogumTarihi = @DogumTarihi, Cinsiyet = @Cinsiyet, MedeniDurumu = @MedeniDurumu, UyruguID = @UyruguID, EgitimID = @EgitimID, Tel = @Tel, Email = @Email, Adress = @Adress, GorevID = @GorevID, Ucret = @Ucret, Fotograf = @Fotograf Where TC = " + TC;
                    }
                    SqlCommand Cmd = new SqlCommand(basvur, Conn);
                    Cmd.Parameters.AddWithValue("@Isim", TxtIsim.Text);
                    Cmd.Parameters.AddWithValue("@Soyad", TxtSoyad.Text);
                    Cmd.Parameters.AddWithValue("@DogumYeri", TxtDoğumYeri.Text);
                    Cmd.Parameters.AddWithValue("@DogumTarihi", DtpDogumTarihi.Value);
                    Cmd.Parameters.AddWithValue("@Cinsiyet", LblKadınErkek.Text);
                    Cmd.Parameters.AddWithValue("@MedeniDurumu", LblBekarEvli.Text);
                    Cmd.Parameters.AddWithValue("@UyruguID", CmbUyruk.SelectedIndex + 1);
                    Cmd.Parameters.AddWithValue("@EgitimID", CmbEgitimDurumu.SelectedIndex + 1);
                    Cmd.Parameters.AddWithValue("@Tel", TxtTel.Text);
                    Cmd.Parameters.AddWithValue("@Email", TxtEmail.Text);
                    Cmd.Parameters.AddWithValue("@Adress", TxtAdress.Text);
                    Cmd.Parameters.AddWithValue("@GorevID", CmbGorev.SelectedIndex + 1);
                    Cmd.Parameters.AddWithValue("@Ucret", TxtUcret.Text);

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
                    Conn.Open();
                    Cmd.ExecuteNonQuery();
                    Conn.Close();
                    FrmMessageBox.Show("Bilgileri Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GuncellemeDurumuKapat();
                    Data();
                }
                else return;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
        private void RdbKadın_CheckedChanged(object sender, EventArgs e)
        {
            LblKadınErkek.Text = "Kadın";
        }
        private void RdbErkek_CheckedChanged(object sender, EventArgs e)
        {
            LblKadınErkek.Text = "Erkek";
        }
        private void RdbBekar_CheckedChanged(object sender, EventArgs e)
        {
            LblBekarEvli.Text = "Bekar";
        }
        private void RdbEvli_CheckedChanged(object sender, EventArgs e)
        {
            LblBekarEvli.Text = "Evli";
        }
        private void TxtTel_MouseDown(object sender, MouseEventArgs e)
        {
            TxtTel.SelectAll();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SaatTarih.Text = DateTime.Now.ToString("");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
