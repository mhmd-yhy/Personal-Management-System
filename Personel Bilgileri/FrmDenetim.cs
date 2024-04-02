﻿using System;
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
    public partial class FrmDenetim : Form
    {
        static string Sql = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        SqlConnection Conn = new SqlConnection(Sql);
        public FrmDenetim()
        {
            InitializeComponent();
        }
        private void FrmDenetim_Load(object sender, EventArgs e)
        {
            Data();
        }
        private DataSet ds;
        void Data()
        {
            string basvur = "Select Isim + ' ' +Soyad As IsimSoayd From Person ORDER BY Isim ASC; Select KullaniciAdi From Giris";
            SqlDataAdapter da = new SqlDataAdapter(basvur, Conn);
            ds = new DataSet();
            da.Fill(ds);
            CmbPersoneller.DataSource = ds.Tables[0];
            CmbPersoneller.DisplayMember = "IsimSoayd";
            ds.Tables[0].Rows.Add("Tüm");
            CmbPersoneller.SelectedIndex = CmbPersoneller.Items.Count - 1;

            CmbAdmin.DataSource = ds.Tables[1];
            CmbAdmin.DisplayMember = "KullaniciAdi";
        }
        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            this.Hide();
            anaSayfa.Show();
        }

        private string Zammi_Kesinti = "Zamm";
        private void UcretModu_Click(object sender, EventArgs e)
        {
            if (UcretModu.Checked) Zammi_Kesinti = "Zamm";
            else Zammi_Kesinti = "Kesinti";
            lblucret();
        }

        private void BtnArttir_Click(object sender, EventArgs e)
        {
            try
            {
                string basvur;

                if (Oran.Value == 0)
                {
                    FrmMessageBox.Show("Oranı giriniz.", "Denetim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int Isimindex = CmbPersoneller.Text.IndexOf(" ");
                    DialogResult dr = FrmMessageBox.Show("Ucret değiştirmek istiyor musun?", "Denetim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        
                        string oran;
                        if (Zammi_Kesinti == "Zamm") oran = ((Oran.Value + 100) / 100).ToString().Replace(",", ".");
                        else oran = ((100 - Oran.Value) / 100).ToString().Replace(",", ".");

                        if (CmbPersoneller.Text == "Tüm") basvur = "Update Person Set Ucret = Ucret * (" + oran + ")";
                        else
                        {
                            string Isim = CmbPersoneller.Text.Substring(0, Isimindex);
                            string Soyad = CmbPersoneller.Text.Substring(Isimindex + 1);
                            basvur = "Update Person Set Ucret = Ucret * (" + oran + ") Where Isim = '" + Isim + "'";
                        }

                        SqlCommand Cmd = new SqlCommand(basvur, Conn);
                        Conn.Open();
                        Cmd.ExecuteNonQuery();
                        Conn.Close();
                        FrmMessageBox.Show("Ucret değiştirildi.", "Denetim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else return;
                }
                UcretlerGoster();
                Oran.Value = new decimal();
                LblYeniUcret.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void CmbPersoneller_SelectedValueChanged(object sender, EventArgs e)
        {
            UcretlerGoster();
        }

        void UcretlerGoster()
        {
            string basvurSelect;
            if (CmbPersoneller.Text != "Tüm")
            {
                int Isimindex = CmbPersoneller.Text.IndexOf(" ");
                string Isim = "";
                for (int i = 0; i < CmbPersoneller.Text.Length; i++)
                {
                    if (CmbPersoneller.Text[i].ToString() == " ") break;
                    Isim += CmbPersoneller.Text[i];
                }
                string Soyad = CmbPersoneller.Text.Substring(Isimindex + 1);
                basvurSelect = "Select Ucret From Person Where Isim = '" + Isim + "'";
            }
            else
            {
                basvurSelect = "Select Sum(Ucret) From Person";
            }
            SqlCommand Cmd = new SqlCommand(basvurSelect, Conn);
            SqlDataReader Reader;
            Conn.Open();
            Reader = Cmd.ExecuteReader();
            if (Reader.Read())
            {
                LblUcret.Text = Reader.GetValue(0).ToString();
            }
            Conn.Close();
        }

        private void Oran_ValueChanged(object sender, EventArgs e)
        {
            lblucret();
        }

        private void Oran_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblucret();
        }
        void lblucret()
        {
            string oran;
            if (Zammi_Kesinti == "Zamm") oran = ((Oran.Value + 100)).ToString().Replace(",", ".");
            else oran = ((100 - Oran.Value)).ToString().Replace(",", ".");

            if (Oran.Value == 0) LblYeniUcret.Text = "";
            else LblYeniUcret.Text = (((float.Parse(LblUcret.Text)) * (float.Parse(oran))) / 100).ToString();
        }

        private void BtnAdminSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = FrmMessageBox.Show("Kullanıcı silmek istiyor musunuz?", "Denetim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string basvur = "Delete From Giris Where KullaniciAdi = '" + CmbAdmin.Text + "'";
                SqlCommand Cmd = new SqlCommand(basvur, Conn);
                Conn.Open();
                Cmd.ExecuteNonQuery();
                Conn.Close();
                Data();
                FrmMessageBox.Show("Kullanıcı silindi.", "Denetim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;
        }

        

        private void BtnAdminEkle_Click(object sender, EventArgs e)
        {
            if(TxtKullanici.Text.Length < 3)
            {
                FrmMessageBox.Show("Kullanıcı Adi Kısadır.", "Denetim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtKullanici.Focus();
                return;
            }
            if (TxtDogumYeri.Text == "")
            {
                FrmMessageBox.Show("Doğum yeri boş olmasın.", "Denetim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtDogumYeri.Focus();
                return;
            }
            Boolean mevcut = false;
            string basvur1 = "Select KullaniciAdi From Giris Where KullaniciAdi = '" + TxtKullanici.Text + "'";
            SqlCommand Cmd = new SqlCommand(basvur1, Conn);
            SqlDataReader Reader;
            Conn.Open();
            Reader = Cmd.ExecuteReader();
            if (Reader.Read())
            {
                    FrmMessageBox.Show("Kullanici mevuttur.", "Denetim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtKullanici.Focus();
                    mevcut = true;
            }
            Conn.Close();
            if (!mevcut)
            {
                string basvur = "Insert Into Giris Values(@KullaniciAdi, @Sifre, @DogumYeri)";
                Cmd = new SqlCommand(basvur, Conn);
                Cmd.Parameters.AddWithValue("@KullaniciAdi", TxtKullanici.Text);
                Cmd.Parameters.AddWithValue("@Sifre", TxtSifre.Text);
                Cmd.Parameters.AddWithValue("@DogumYeri", TxtDogumYeri.Text);
                Conn.Open();
                Cmd.ExecuteNonQuery();
                Conn.Close();
                FrmMessageBox.Show("Kullanici Eklendi.", "Denetim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            temizle(groupBox3);
            Data();
        }
        void temizle(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox) c.Text = "";
                if (c is Button) c.Enabled = false;
            }
        }
        private void TxtKullanici_MouseDown(object sender, MouseEventArgs e)
        {
            TxtKullanici.Text = "";
        }

        private void TxtDogumYeri_MouseDown(object sender, MouseEventArgs e)
        {
            TxtDogumYeri.Text = "";
        }

        private void TxtSifre_MouseDown(object sender, MouseEventArgs e)
        {
            TxtSifre.Text = "";
        }
        private void TxtKullanici_TextChanged(object sender, EventArgs e)
        {
            //if (TxtKullanici.TextLength > 3) AdminKontrol();
        }
        private void TxtDogumYeri_TextChanged(object sender, EventArgs e)
        {
            //if (TxtDogumYeri.TextLength > 0) AdminKontrol();
        }
        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {
            if (TxtSifre.Text.Length == 4) BtnAdminEkle.Enabled = true;
            else BtnAdminEkle.Enabled = false;
        }
        
    }
}