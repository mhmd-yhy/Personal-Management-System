
namespace Personel_Bilgileri
{
    partial class FrmDenetim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtKullanici = new System.Windows.Forms.TextBox();
            this.BtnAdminEkle = new System.Windows.Forms.Button();
            this.TxtDogumYeri = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CmbAdmin = new System.Windows.Forms.ComboBox();
            this.BtnAdminSil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblBelirlenmisAvans = new System.Windows.Forms.Label();
            this.LblMiktar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OranAvansi = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnAvans = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbAylar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbPersonellerAvansi = new System.Windows.Forms.ComboBox();
            this.LblMaas = new System.Windows.Forms.Label();
            this.BtnAnaSayfa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbPersoneller = new System.Windows.Forms.ComboBox();
            this.LblYeniUcret = new System.Windows.Forms.Label();
            this.LblUcret = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UcretModu = new System.Windows.Forms.CheckBox();
            this.BtnArttir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Oran = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OranAvansi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Oran)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.BtnAnaSayfa);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 599);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TxtSifre);
            this.groupBox4.Controls.Add(this.TxtKullanici);
            this.groupBox4.Controls.Add(this.BtnAdminEkle);
            this.groupBox4.Controls.Add(this.TxtDogumYeri);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.groupBox4.Location = new System.Drawing.Point(0, 427);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(625, 104);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Admin Ekle";
            // 
            // TxtSifre
            // 
            this.TxtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.TxtSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.TxtSifre.Location = new System.Drawing.Point(337, 50);
            this.TxtSifre.MaxLength = 4;
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(148, 30);
            this.TxtSifre.TabIndex = 27;
            this.TxtSifre.Text = "Şifre";
            // 
            // TxtKullanici
            // 
            this.TxtKullanici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.TxtKullanici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtKullanici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.TxtKullanici.Location = new System.Drawing.Point(9, 50);
            this.TxtKullanici.MaxLength = 10;
            this.TxtKullanici.Name = "TxtKullanici";
            this.TxtKullanici.Size = new System.Drawing.Size(145, 30);
            this.TxtKullanici.TabIndex = 25;
            this.TxtKullanici.Text = "Kullanıcı Adı";
            // 
            // BtnAdminEkle
            // 
            this.BtnAdminEkle.AutoSize = true;
            this.BtnAdminEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(71)))));
            this.BtnAdminEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdminEkle.Enabled = false;
            this.BtnAdminEkle.FlatAppearance.BorderSize = 0;
            this.BtnAdminEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdminEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BtnAdminEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.BtnAdminEkle.Location = new System.Drawing.Point(509, 50);
            this.BtnAdminEkle.Name = "BtnAdminEkle";
            this.BtnAdminEkle.Size = new System.Drawing.Size(99, 30);
            this.BtnAdminEkle.TabIndex = 24;
            this.BtnAdminEkle.Text = "Uygula";
            this.BtnAdminEkle.UseVisualStyleBackColor = false;
            // 
            // TxtDogumYeri
            // 
            this.TxtDogumYeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.TxtDogumYeri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDogumYeri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.TxtDogumYeri.Location = new System.Drawing.Point(170, 50);
            this.TxtDogumYeri.MaxLength = 50;
            this.TxtDogumYeri.Name = "TxtDogumYeri";
            this.TxtDogumYeri.Size = new System.Drawing.Size(148, 30);
            this.TxtDogumYeri.TabIndex = 26;
            this.TxtDogumYeri.Text = "Doğum Yeri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CmbAdmin);
            this.groupBox3.Controls.Add(this.BtnAdminSil);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.groupBox3.Location = new System.Drawing.Point(0, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(625, 83);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Admin Sil";
            // 
            // CmbAdmin
            // 
            this.CmbAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.CmbAdmin.DropDownHeight = 170;
            this.CmbAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAdmin.DropDownWidth = 75;
            this.CmbAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.CmbAdmin.FormattingEnabled = true;
            this.CmbAdmin.IntegralHeight = false;
            this.CmbAdmin.Items.AddRange(new object[] {
            "AAAAA"});
            this.CmbAdmin.Location = new System.Drawing.Point(9, 29);
            this.CmbAdmin.Name = "CmbAdmin";
            this.CmbAdmin.Size = new System.Drawing.Size(145, 31);
            this.CmbAdmin.TabIndex = 21;
            // 
            // BtnAdminSil
            // 
            this.BtnAdminSil.AutoSize = true;
            this.BtnAdminSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(71)))));
            this.BtnAdminSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdminSil.FlatAppearance.BorderSize = 0;
            this.BtnAdminSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdminSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BtnAdminSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.BtnAdminSil.Location = new System.Drawing.Point(183, 29);
            this.BtnAdminSil.Name = "BtnAdminSil";
            this.BtnAdminSil.Size = new System.Drawing.Size(99, 30);
            this.BtnAdminSil.TabIndex = 24;
            this.BtnAdminSil.Text = "Uygula";
            this.BtnAdminSil.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblBelirlenmisAvans);
            this.groupBox2.Controls.Add(this.LblMiktar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.OranAvansi);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.BtnAvans);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.CmbAylar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CmbPersonellerAvansi);
            this.groupBox2.Controls.Add(this.LblMaas);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(0, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 216);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Maaş Avansı";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // LblBelirlenmisAvans
            // 
            this.LblBelirlenmisAvans.AutoSize = true;
            this.LblBelirlenmisAvans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.LblBelirlenmisAvans.Location = new System.Drawing.Point(318, 131);
            this.LblBelirlenmisAvans.Name = "LblBelirlenmisAvans";
            this.LblBelirlenmisAvans.Size = new System.Drawing.Size(0, 23);
            this.LblBelirlenmisAvans.TabIndex = 834;
            // 
            // LblMiktar
            // 
            this.LblMiktar.AutoSize = true;
            this.LblMiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.LblMiktar.Location = new System.Drawing.Point(510, 85);
            this.LblMiktar.Name = "LblMiktar";
            this.LblMiktar.Size = new System.Drawing.Size(0, 23);
            this.LblMiktar.TabIndex = 832;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.label8.Location = new System.Drawing.Point(85, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 23);
            this.label8.TabIndex = 831;
            this.label8.Text = "%";
            // 
            // OranAvansi
            // 
            this.OranAvansi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.OranAvansi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OranAvansi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.OranAvansi.Location = new System.Drawing.Point(10, 173);
            this.OranAvansi.Name = "OranAvansi";
            this.OranAvansi.Size = new System.Drawing.Size(59, 26);
            this.OranAvansi.TabIndex = 830;
            this.OranAvansi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OranAvansi.ValueChanged += new System.EventHandler(this.OranAvansi_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.label11.Location = new System.Drawing.Point(183, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 23);
            this.label11.TabIndex = 829;
            this.label11.Text = "Belirlenmiş Avans:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.label9.Location = new System.Drawing.Point(10, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(430, 23);
            this.label9.TabIndex = 827;
            this.label9.Text = "Not: bir maaş`tan kullanabilmek miktarı 50%`dir.";
            // 
            // BtnAvans
            // 
            this.BtnAvans.AutoSize = true;
            this.BtnAvans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(71)))));
            this.BtnAvans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAvans.FlatAppearance.BorderSize = 0;
            this.BtnAvans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAvans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BtnAvans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.BtnAvans.Location = new System.Drawing.Point(187, 170);
            this.BtnAvans.Name = "BtnAvans";
            this.BtnAvans.Size = new System.Drawing.Size(99, 30);
            this.BtnAvans.TabIndex = 20;
            this.BtnAvans.Text = "Uygula";
            this.BtnAvans.UseVisualStyleBackColor = false;
            this.BtnAvans.Click += new System.EventHandler(this.BtnAvans_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.label7.Location = new System.Drawing.Point(183, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 23);
            this.label7.TabIndex = 822;
            this.label7.Text = "Maaş:";
            // 
            // CmbAylar
            // 
            this.CmbAylar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.CmbAylar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAylar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbAylar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.CmbAylar.FormattingEnabled = true;
            this.CmbAylar.Location = new System.Drawing.Point(9, 126);
            this.CmbAylar.Name = "CmbAylar";
            this.CmbAylar.Size = new System.Drawing.Size(145, 31);
            this.CmbAylar.TabIndex = 826;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.label6.Location = new System.Drawing.Point(345, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 23);
            this.label6.TabIndex = 823;
            this.label6.Text = "Kullanılabilmek miktarı:";
            // 
            // CmbPersonellerAvansi
            // 
            this.CmbPersonellerAvansi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.CmbPersonellerAvansi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPersonellerAvansi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbPersonellerAvansi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.CmbPersonellerAvansi.FormattingEnabled = true;
            this.CmbPersonellerAvansi.Location = new System.Drawing.Point(9, 84);
            this.CmbPersonellerAvansi.Name = "CmbPersonellerAvansi";
            this.CmbPersonellerAvansi.Size = new System.Drawing.Size(145, 31);
            this.CmbPersonellerAvansi.TabIndex = 25;
            this.CmbPersonellerAvansi.SelectedValueChanged += new System.EventHandler(this.CmbPersonellerAvansi_SelectedValueChanged);
            // 
            // LblMaas
            // 
            this.LblMaas.AutoSize = true;
            this.LblMaas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.LblMaas.Location = new System.Drawing.Point(240, 85);
            this.LblMaas.Name = "LblMaas";
            this.LblMaas.Size = new System.Drawing.Size(0, 23);
            this.LblMaas.TabIndex = 824;
            // 
            // BtnAnaSayfa
            // 
            this.BtnAnaSayfa.AutoSize = true;
            this.BtnAnaSayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(71)))));
            this.BtnAnaSayfa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAnaSayfa.FlatAppearance.BorderSize = 0;
            this.BtnAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BtnAnaSayfa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.BtnAnaSayfa.Location = new System.Drawing.Point(509, 547);
            this.BtnAnaSayfa.Name = "BtnAnaSayfa";
            this.BtnAnaSayfa.Size = new System.Drawing.Size(99, 32);
            this.BtnAnaSayfa.TabIndex = 19;
            this.BtnAnaSayfa.Text = "AnaSayfa";
            this.BtnAnaSayfa.UseVisualStyleBackColor = false;
            this.BtnAnaSayfa.Click += new System.EventHandler(this.BtnAnaSayfa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbPersoneller);
            this.groupBox1.Controls.Add(this.LblYeniUcret);
            this.groupBox1.Controls.Add(this.LblUcret);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.UcretModu);
            this.groupBox1.Controls.Add(this.BtnArttir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Oran);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ucret Yönetim";
            // 
            // CmbPersoneller
            // 
            this.CmbPersoneller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.CmbPersoneller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPersoneller.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbPersoneller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.CmbPersoneller.FormattingEnabled = true;
            this.CmbPersoneller.Location = new System.Drawing.Point(13, 31);
            this.CmbPersoneller.Name = "CmbPersoneller";
            this.CmbPersoneller.Size = new System.Drawing.Size(145, 31);
            this.CmbPersoneller.TabIndex = 25;
            this.CmbPersoneller.SelectedValueChanged += new System.EventHandler(this.CmbPersoneller_SelectedValueChanged);
            // 
            // LblYeniUcret
            // 
            this.LblYeniUcret.AutoSize = true;
            this.LblYeniUcret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.LblYeniUcret.Location = new System.Drawing.Point(471, 81);
            this.LblYeniUcret.Name = "LblYeniUcret";
            this.LblYeniUcret.Size = new System.Drawing.Size(0, 23);
            this.LblYeniUcret.TabIndex = 825;
            // 
            // LblUcret
            // 
            this.LblUcret.AutoSize = true;
            this.LblUcret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.LblUcret.Location = new System.Drawing.Point(471, 31);
            this.LblUcret.Name = "LblUcret";
            this.LblUcret.Size = new System.Drawing.Size(0, 23);
            this.LblUcret.TabIndex = 824;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(334, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 823;
            this.label2.Text = "Yeni Ucret:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(334, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 822;
            this.label1.Text = "Ucret:";
            // 
            // UcretModu
            // 
            this.UcretModu.AutoSize = true;
            this.UcretModu.Checked = true;
            this.UcretModu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UcretModu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UcretModu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UcretModu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.UcretModu.Location = new System.Drawing.Point(187, 34);
            this.UcretModu.Name = "UcretModu";
            this.UcretModu.Size = new System.Drawing.Size(80, 23);
            this.UcretModu.TabIndex = 821;
            this.UcretModu.Text = "Zammı";
            this.UcretModu.UseVisualStyleBackColor = true;
            this.UcretModu.Click += new System.EventHandler(this.UcretModu_Click);
            // 
            // BtnArttir
            // 
            this.BtnArttir.AutoSize = true;
            this.BtnArttir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(71)))));
            this.BtnArttir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnArttir.FlatAppearance.BorderSize = 0;
            this.BtnArttir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnArttir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BtnArttir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.BtnArttir.Location = new System.Drawing.Point(184, 79);
            this.BtnArttir.Name = "BtnArttir";
            this.BtnArttir.Size = new System.Drawing.Size(99, 30);
            this.BtnArttir.TabIndex = 20;
            this.BtnArttir.Text = "Uygula";
            this.BtnArttir.UseVisualStyleBackColor = false;
            this.BtnArttir.Click += new System.EventHandler(this.BtnArttir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.label3.Location = new System.Drawing.Point(85, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "%";
            // 
            // Oran
            // 
            this.Oran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.Oran.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Oran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));
            this.Oran.Location = new System.Drawing.Point(10, 78);
            this.Oran.Name = "Oran";
            this.Oran.Size = new System.Drawing.Size(59, 26);
            this.Oran.TabIndex = 10;
            this.Oran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Oran.ValueChanged += new System.EventHandler(this.Oran_ValueChanged);
            this.Oran.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Oran_KeyPress);
            // 
            // FrmDenetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(645, 619);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDenetim";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Denetim";
            this.Load += new System.EventHandler(this.FrmDenetim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OranAvansi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Oran)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAnaSayfa;
        private System.Windows.Forms.Button BtnArttir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Oran;
        private System.Windows.Forms.CheckBox UcretModu;
        private System.Windows.Forms.Label LblYeniUcret;
        private System.Windows.Forms.Label LblUcret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbPersoneller;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox TxtKullanici;
        private System.Windows.Forms.Button BtnAdminEkle;
        private System.Windows.Forms.TextBox TxtDogumYeri;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CmbAdmin;
        private System.Windows.Forms.Button BtnAdminSil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnAvans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbAylar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbPersonellerAvansi;
        private System.Windows.Forms.Label LblMaas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown OranAvansi;
        private System.Windows.Forms.Label LblBelirlenmisAvans;
        private System.Windows.Forms.Label LblMiktar;
    }
}