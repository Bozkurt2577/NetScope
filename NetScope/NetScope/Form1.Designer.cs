namespace NetScope
{
    partial class NetScope
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetScope));
            this.panelContent = new System.Windows.Forms.Panel();
            this.PanelSubnetHesaplayıcı = new System.Windows.Forms.Panel();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.GroupSonuçlar = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbnIPAdresi = new System.Windows.Forms.Label();
            this.ComboBoxSubnet = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelHizTesti = new System.Windows.Forms.Panel();
            this.btnHizTestiBaslat = new System.Windows.Forms.Button();
            this.lblHizBaslik = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPing = new System.Windows.Forms.Label();
            this.lblUpload = new System.Windows.Forms.Label();
            this.lblDownload = new System.Windows.Forms.Label();
            this.panelAgim = new System.Windows.Forms.Panel();
            this.grpAgDurumu = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgYenile = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.Bilgi = new System.Windows.Forms.Panel();
            this.rtbBilgi = new System.Windows.Forms.Label();
            this.lblBilgiBaslik = new System.Windows.Forms.Label();
            this.Ayarlar = new System.Windows.Forms.Panel();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHizTestiMenu = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnBilgi = new System.Windows.Forms.Button();
            this.btnPing = new System.Windows.Forms.Button();
            this.btnIpHesaplayici = new System.Windows.Forms.Button();
            this.btnAğim = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelContent.SuspendLayout();
            this.PanelSubnetHesaplayıcı.SuspendLayout();
            this.panelHizTesti.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelAgim.SuspendLayout();
            this.grpAgDurumu.SuspendLayout();
            this.Bilgi.SuspendLayout();
            this.Ayarlar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.panelContent.Controls.Add(this.panelAgim);
            this.panelContent.Controls.Add(this.panelHizTesti);
            this.panelContent.Controls.Add(this.PanelSubnetHesaplayıcı);
            this.panelContent.Controls.Add(this.Bilgi);
            this.panelContent.Controls.Add(this.Ayarlar);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(600, 450);
            this.panelContent.TabIndex = 3;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // PanelSubnetHesaplayıcı
            // 
            this.PanelSubnetHesaplayıcı.Controls.Add(this.btnHesapla);
            this.PanelSubnetHesaplayıcı.Controls.Add(this.GroupSonuçlar);
            this.PanelSubnetHesaplayıcı.Controls.Add(this.label10);
            this.PanelSubnetHesaplayıcı.Controls.Add(this.lbnIPAdresi);
            this.PanelSubnetHesaplayıcı.Controls.Add(this.ComboBoxSubnet);
            this.PanelSubnetHesaplayıcı.Controls.Add(this.textBox1);
            this.PanelSubnetHesaplayıcı.Location = new System.Drawing.Point(0, 0);
            this.PanelSubnetHesaplayıcı.Name = "PanelSubnetHesaplayıcı";
            this.PanelSubnetHesaplayıcı.Size = new System.Drawing.Size(600, 500);
            this.PanelSubnetHesaplayıcı.TabIndex = 2;
            this.PanelSubnetHesaplayıcı.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSubnetHesaplayıcı_Paint);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnHesapla.ForeColor = System.Drawing.Color.White;
            this.btnHesapla.Location = new System.Drawing.Point(69, 292);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(97, 34);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            this.btnHesapla.MouseHover += new System.EventHandler(this.btnHesapla_MouseHover);
            // 
            // GroupSonuçlar
            // 
            this.GroupSonuçlar.ForeColor = System.Drawing.Color.White;
            this.GroupSonuçlar.Location = new System.Drawing.Point(247, 53);
            this.GroupSonuçlar.Name = "GroupSonuçlar";
            this.GroupSonuçlar.Size = new System.Drawing.Size(267, 354);
            this.GroupSonuçlar.TabIndex = 4;
            this.GroupSonuçlar.TabStop = false;
            this.GroupSonuçlar.Text = "Sonuçlar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(60, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Subnet Maskesi";
            // 
            // lbnIPAdresi
            // 
            this.lbnIPAdresi.AutoSize = true;
            this.lbnIPAdresi.ForeColor = System.Drawing.Color.White;
            this.lbnIPAdresi.Location = new System.Drawing.Point(61, 124);
            this.lbnIPAdresi.Name = "lbnIPAdresi";
            this.lbnIPAdresi.Size = new System.Drawing.Size(49, 13);
            this.lbnIPAdresi.TabIndex = 2;
            this.lbnIPAdresi.Text = "IP Adresi";
            this.lbnIPAdresi.Click += new System.EventHandler(this.lbnIPAdresi_Click);
            // 
            // ComboBoxSubnet
            // 
            this.ComboBoxSubnet.FormattingEnabled = true;
            this.ComboBoxSubnet.Location = new System.Drawing.Point(58, 237);
            this.ComboBoxSubnet.Name = "ComboBoxSubnet";
            this.ComboBoxSubnet.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxSubnet.TabIndex = 1;
            this.ComboBoxSubnet.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSubnet_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panelHizTesti
            // 
            this.panelHizTesti.Controls.Add(this.btnHizTestiBaslat);
            this.panelHizTesti.Controls.Add(this.lblHizBaslik);
            this.panelHizTesti.Controls.Add(this.groupBox1);
            this.panelHizTesti.Location = new System.Drawing.Point(0, 0);
            this.panelHizTesti.Name = "panelHizTesti";
            this.panelHizTesti.Size = new System.Drawing.Size(600, 500);
            this.panelHizTesti.TabIndex = 3;
            // 
            // btnHizTestiBaslat
            // 
            this.btnHizTestiBaslat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnHizTestiBaslat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHizTestiBaslat.FlatAppearance.BorderSize = 0;
            this.btnHizTestiBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHizTestiBaslat.ForeColor = System.Drawing.Color.White;
            this.btnHizTestiBaslat.Location = new System.Drawing.Point(211, 338);
            this.btnHizTestiBaslat.Name = "btnHizTestiBaslat";
            this.btnHizTestiBaslat.Size = new System.Drawing.Size(160, 45);
            this.btnHizTestiBaslat.TabIndex = 6;
            this.btnHizTestiBaslat.Text = "🚀 Hız Testini Başlat";
            this.btnHizTestiBaslat.UseVisualStyleBackColor = false;
            this.btnHizTestiBaslat.Click += new System.EventHandler(this.button2_Click_1);
            this.btnHizTestiBaslat.MouseHover += new System.EventHandler(this.btnHizTestiBaslat_MouseHover);
            // 
            // lblHizBaslik
            // 
            this.lblHizBaslik.AutoSize = true;
            this.lblHizBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHizBaslik.ForeColor = System.Drawing.Color.White;
            this.lblHizBaslik.Location = new System.Drawing.Point(20, 31);
            this.lblHizBaslik.Name = "lblHizBaslik";
            this.lblHizBaslik.Size = new System.Drawing.Size(193, 29);
            this.lblHizBaslik.TabIndex = 0;
            this.lblHizBaslik.Text = "İnternet Hız Testi";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.groupBox1.Controls.Add(this.lblPing);
            this.groupBox1.Controls.Add(this.lblUpload);
            this.groupBox1.Controls.Add(this.lblDownload);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(7, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 265);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hız Testi";
            // 
            // lblPing
            // 
            this.lblPing.AutoSize = true;
            this.lblPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPing.Location = new System.Drawing.Point(413, 66);
            this.lblPing.Name = "lblPing";
            this.lblPing.Size = new System.Drawing.Size(94, 20);
            this.lblPing.TabIndex = 3;
            this.lblPing.Text = "Ping: -- ms";
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpload.Location = new System.Drawing.Point(218, 165);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(136, 20);
            this.lblUpload.TabIndex = 2;
            this.lblUpload.Text = "Upload: -- Mbps";
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDownload.Location = new System.Drawing.Point(34, 66);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(158, 20);
            this.lblDownload.TabIndex = 1;
            this.lblDownload.Text = "Download: -- Mbps";
            // 
            // panelAgim
            // 
            this.panelAgim.Controls.Add(this.grpAgDurumu);
            this.panelAgim.Controls.Add(this.btnAgYenile);
            this.panelAgim.Controls.Add(this.lblBaslik);
            this.panelAgim.Location = new System.Drawing.Point(0, 0);
            this.panelAgim.Name = "panelAgim";
            this.panelAgim.Size = new System.Drawing.Size(600, 500);
            this.panelAgim.TabIndex = 3;
            this.panelAgim.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAgim_Paint);
            // 
            // grpAgDurumu
            // 
            this.grpAgDurumu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.grpAgDurumu.Controls.Add(this.label5);
            this.grpAgDurumu.Controls.Add(this.label6);
            this.grpAgDurumu.Controls.Add(this.label7);
            this.grpAgDurumu.Controls.Add(this.label8);
            this.grpAgDurumu.Controls.Add(this.label4);
            this.grpAgDurumu.Controls.Add(this.label3);
            this.grpAgDurumu.Controls.Add(this.label2);
            this.grpAgDurumu.Controls.Add(this.label1);
            this.grpAgDurumu.ForeColor = System.Drawing.Color.White;
            this.grpAgDurumu.Location = new System.Drawing.Point(25, 88);
            this.grpAgDurumu.Name = "grpAgDurumu";
            this.grpAgDurumu.Size = new System.Drawing.Size(563, 180);
            this.grpAgDurumu.TabIndex = 1;
            this.grpAgDurumu.TabStop = false;
            this.grpAgDurumu.Text = "Bağlantı Bilgileri";
            this.grpAgDurumu.Enter += new System.EventHandler(this.grpAgDurumu_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "0";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNS:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gateway:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IPv4:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bağlantı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAgYenile
            // 
            this.btnAgYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnAgYenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgYenile.FlatAppearance.BorderSize = 0;
            this.btnAgYenile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAgYenile.ForeColor = System.Drawing.Color.White;
            this.btnAgYenile.Location = new System.Drawing.Point(229, 292);
            this.btnAgYenile.Name = "btnAgYenile";
            this.btnAgYenile.Size = new System.Drawing.Size(120, 40);
            this.btnAgYenile.TabIndex = 2;
            this.btnAgYenile.Text = "Ağı Yenile";
            this.btnAgYenile.UseVisualStyleBackColor = false;
            this.btnAgYenile.Click += new System.EventHandler(this.btnAgYenile_Click);
            this.btnAgYenile.MouseHover += new System.EventHandler(this.btnAgYenile_MouseHover);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(20, 34);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(132, 29);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Ağ Durumu";
            this.lblBaslik.Click += new System.EventHandler(this.lblBaslik_Click);
            // 
            // Bilgi
            // 
            this.Bilgi.Controls.Add(this.rtbBilgi);
            this.Bilgi.Controls.Add(this.lblBilgiBaslik);
            this.Bilgi.Location = new System.Drawing.Point(0, 0);
            this.Bilgi.Name = "Bilgi";
            this.Bilgi.Size = new System.Drawing.Size(600, 500);
            this.Bilgi.TabIndex = 7;
            // 
            // rtbBilgi
            // 
            this.rtbBilgi.AutoSize = true;
            this.rtbBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBilgi.ForeColor = System.Drawing.Color.White;
            this.rtbBilgi.Location = new System.Drawing.Point(13, 88);
            this.rtbBilgi.Name = "rtbBilgi";
            this.rtbBilgi.Size = new System.Drawing.Size(41, 15);
            this.rtbBilgi.TabIndex = 1;
            this.rtbBilgi.Text = "label9";
            // 
            // lblBilgiBaslik
            // 
            this.lblBilgiBaslik.AutoSize = true;
            this.lblBilgiBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgiBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBilgiBaslik.Location = new System.Drawing.Point(53, 31);
            this.lblBilgiBaslik.Name = "lblBilgiBaslik";
            this.lblBilgiBaslik.Size = new System.Drawing.Size(85, 29);
            this.lblBilgiBaslik.TabIndex = 0;
            this.lblBilgiBaslik.Text = "label9";
            // 
            // Ayarlar
            // 
            this.Ayarlar.Controls.Add(this.lblLanguage);
            this.Ayarlar.Controls.Add(this.comboBox1);
            this.Ayarlar.Location = new System.Drawing.Point(0, 0);
            this.Ayarlar.Name = "Ayarlar";
            this.Ayarlar.Size = new System.Drawing.Size(598, 500);
            this.Ayarlar.TabIndex = 3;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.ForeColor = System.Drawing.Color.White;
            this.lblLanguage.Location = new System.Drawing.Point(92, 64);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(19, 13);
            this.lblLanguage.TabIndex = 1;
            this.lblLanguage.Text = "Dil";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(92, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnHizTestiMenu);
            this.panel1.Controls.Add(this.btnAyarlar);
            this.panel1.Controls.Add(this.btnBilgi);
            this.panel1.Controls.Add(this.btnPing);
            this.panel1.Controls.Add(this.btnIpHesaplayici);
            this.panel1.Controls.Add(this.btnAğim);
            this.panel1.Controls.Add(this.lblLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnHizTestiMenu
            // 
            this.btnHizTestiMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHizTestiMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHizTestiMenu.ForeColor = System.Drawing.Color.White;
            this.btnHizTestiMenu.Location = new System.Drawing.Point(61, 268);
            this.btnHizTestiMenu.Name = "btnHizTestiMenu";
            this.btnHizTestiMenu.Size = new System.Drawing.Size(75, 45);
            this.btnHizTestiMenu.TabIndex = 6;
            this.btnHizTestiMenu.Text = " Hız Testi";
            this.btnHizTestiMenu.UseVisualStyleBackColor = false;
            this.btnHizTestiMenu.Click += new System.EventHandler(this.btnHizTestiMenu_Click);
            this.btnHizTestiMenu.MouseHover += new System.EventHandler(this.btnHizTestiMenu_MouseHover);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyarlar.ForeColor = System.Drawing.Color.White;
            this.btnAyarlar.Location = new System.Drawing.Point(61, 385);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(75, 45);
            this.btnAyarlar.TabIndex = 5;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.button4_Click);
            this.btnAyarlar.MouseHover += new System.EventHandler(this.btnAyarlar_MouseHover);
            // 
            // btnBilgi
            // 
            this.btnBilgi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgi.ForeColor = System.Drawing.Color.White;
            this.btnBilgi.Location = new System.Drawing.Point(61, 329);
            this.btnBilgi.Name = "btnBilgi";
            this.btnBilgi.Size = new System.Drawing.Size(75, 45);
            this.btnBilgi.TabIndex = 4;
            this.btnBilgi.Text = "Bilgi";
            this.btnBilgi.UseVisualStyleBackColor = false;
            this.btnBilgi.Click += new System.EventHandler(this.button3_Click);
            this.btnBilgi.MouseHover += new System.EventHandler(this.btnBilgi_MouseHover);
            // 
            // btnPing
            // 
            this.btnPing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPing.ForeColor = System.Drawing.Color.White;
            this.btnPing.Location = new System.Drawing.Point(61, 207);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(75, 45);
            this.btnPing.TabIndex = 3;
            this.btnPing.Text = "📡 Ping";
            this.btnPing.UseVisualStyleBackColor = false;
            this.btnPing.Click += new System.EventHandler(this.button2_Click);
            this.btnPing.MouseHover += new System.EventHandler(this.btnPing_MouseHover);
            // 
            // btnIpHesaplayici
            // 
            this.btnIpHesaplayici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIpHesaplayici.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIpHesaplayici.ForeColor = System.Drawing.Color.White;
            this.btnIpHesaplayici.Location = new System.Drawing.Point(61, 146);
            this.btnIpHesaplayici.Name = "btnIpHesaplayici";
            this.btnIpHesaplayici.Size = new System.Drawing.Size(75, 45);
            this.btnIpHesaplayici.TabIndex = 2;
            this.btnIpHesaplayici.Text = "IP Subnet Hesaplayıcı";
            this.btnIpHesaplayici.UseVisualStyleBackColor = false;
            this.btnIpHesaplayici.Click += new System.EventHandler(this.button1_Click);
            this.btnIpHesaplayici.MouseHover += new System.EventHandler(this.btnIpHesaplayici_MouseHover);
            // 
            // btnAğim
            // 
            this.btnAğim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAğim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAğim.ForeColor = System.Drawing.Color.White;
            this.btnAğim.Location = new System.Drawing.Point(61, 88);
            this.btnAğim.Name = "btnAğim";
            this.btnAğim.Size = new System.Drawing.Size(75, 45);
            this.btnAğim.TabIndex = 1;
            this.btnAğim.Text = "Ağım";
            this.btnAğim.UseVisualStyleBackColor = false;
            this.btnAğim.Click += new System.EventHandler(this.m);
            this.btnAğim.MouseHover += new System.EventHandler(this.btnAğim_MouseHover);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(28, 22);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(149, 40);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "NetScope";
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // NetScope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NetScope";
            this.Text = "NetScope";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelContent.ResumeLayout(false);
            this.PanelSubnetHesaplayıcı.ResumeLayout(false);
            this.PanelSubnetHesaplayıcı.PerformLayout();
            this.panelHizTesti.ResumeLayout(false);
            this.panelHizTesti.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelAgim.ResumeLayout(false);
            this.panelAgim.PerformLayout();
            this.grpAgDurumu.ResumeLayout(false);
            this.grpAgDurumu.PerformLayout();
            this.Bilgi.ResumeLayout(false);
            this.Bilgi.PerformLayout();
            this.Ayarlar.ResumeLayout(false);
            this.Ayarlar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelAgim;
        private System.Windows.Forms.GroupBox grpAgDurumu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgYenile;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelHizTesti;
        private System.Windows.Forms.Button btnHizTestiBaslat;
        private System.Windows.Forms.Label lblHizBaslik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPing;
        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.Label lblDownload;
        private System.Windows.Forms.Panel Ayarlar;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHizTestiMenu;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnBilgi;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Button btnIpHesaplayici;
        private System.Windows.Forms.Button btnAğim;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel Bilgi;
        private System.Windows.Forms.Label rtbBilgi;
        private System.Windows.Forms.Label lblBilgiBaslik;
        private System.Windows.Forms.Panel PanelSubnetHesaplayıcı;
        private System.Windows.Forms.ComboBox ComboBoxSubnet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox GroupSonuçlar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbnIPAdresi;
        private System.Windows.Forms.Button btnHesapla;
    }
}

