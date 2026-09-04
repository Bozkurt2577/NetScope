namespace NetScope
{
    partial class Form1
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
            this.btnHizTestiMenu = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnBilgi = new System.Windows.Forms.Button();
            this.btnPing = new System.Windows.Forms.Button();
            this.btnIpHesaplayici = new System.Windows.Forms.Button();
            this.btnAğim = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
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
            this.panelHizTesti = new System.Windows.Forms.Panel();
            this.lblHizBaslik = new System.Windows.Forms.Label();
            this.lblDownload = new System.Windows.Forms.Label();
            this.lblUpload = new System.Windows.Forms.Label();
            this.lblPing = new System.Windows.Forms.Label();
            this.lblJitter = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHizTestiBaslat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelAgim.SuspendLayout();
            this.grpAgDurumu.SuspendLayout();
            this.panelHizTesti.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnHizTestiMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHizTestiMenu.ForeColor = System.Drawing.Color.White;
            this.btnHizTestiMenu.Location = new System.Drawing.Point(61, 268);
            this.btnHizTestiMenu.Name = "btnHizTestiMenu";
            this.btnHizTestiMenu.Size = new System.Drawing.Size(75, 45);
            this.btnHizTestiMenu.TabIndex = 6;
            this.btnHizTestiMenu.Text = "🚀 Hız Testi";
            this.btnHizTestiMenu.UseVisualStyleBackColor = false;
            this.btnHizTestiMenu.Click += new System.EventHandler(this.btnHizTestiMenu_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyarlar.ForeColor = System.Drawing.Color.White;
            this.btnAyarlar.Location = new System.Drawing.Point(61, 385);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(75, 45);
            this.btnAyarlar.TabIndex = 5;
            this.btnAyarlar.Text = "⚙ Ayarlar";
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBilgi
            // 
            this.btnBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgi.ForeColor = System.Drawing.Color.White;
            this.btnBilgi.Location = new System.Drawing.Point(61, 329);
            this.btnBilgi.Name = "btnBilgi";
            this.btnBilgi.Size = new System.Drawing.Size(75, 45);
            this.btnBilgi.TabIndex = 4;
            this.btnBilgi.Text = "ℹ Bilgi";
            this.btnBilgi.UseVisualStyleBackColor = false;
            this.btnBilgi.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPing
            // 
            this.btnPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPing.ForeColor = System.Drawing.Color.White;
            this.btnPing.Location = new System.Drawing.Point(61, 207);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(75, 45);
            this.btnPing.TabIndex = 3;
            this.btnPing.Text = "📡 Ping";
            this.btnPing.UseVisualStyleBackColor = false;
            this.btnPing.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIpHesaplayici
            // 
            this.btnIpHesaplayici.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIpHesaplayici.ForeColor = System.Drawing.Color.White;
            this.btnIpHesaplayici.Location = new System.Drawing.Point(61, 146);
            this.btnIpHesaplayici.Name = "btnIpHesaplayici";
            this.btnIpHesaplayici.Size = new System.Drawing.Size(75, 45);
            this.btnIpHesaplayici.TabIndex = 2;
            this.btnIpHesaplayici.Text = "🧮 IP Hesaplayıcı";
            this.btnIpHesaplayici.UseVisualStyleBackColor = false;
            this.btnIpHesaplayici.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAğim
            // 
            this.btnAğim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAğim.ForeColor = System.Drawing.Color.White;
            this.btnAğim.Location = new System.Drawing.Point(61, 88);
            this.btnAğim.Name = "btnAğim";
            this.btnAğim.Size = new System.Drawing.Size(75, 45);
            this.btnAğim.TabIndex = 1;
            this.btnAğim.Text = "🌐 Ağım";
            this.btnAğim.UseVisualStyleBackColor = false;
            this.btnAğim.Click += new System.EventHandler(this.btnAğim_Click);
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
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.panelContent.Controls.Add(this.panelAgim);
            this.panelContent.Controls.Add(this.panelHizTesti);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(600, 450);
            this.panelContent.TabIndex = 3;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDownload.Location = new System.Drawing.Point(22, 97);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(158, 20);
            this.lblDownload.TabIndex = 1;
            this.lblDownload.Text = "Download: -- Mbps";
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpload.Location = new System.Drawing.Point(21, 217);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(136, 20);
            this.lblUpload.TabIndex = 2;
            this.lblUpload.Text = "Upload: -- Mbps";
            // 
            // lblPing
            // 
            this.lblPing.AutoSize = true;
            this.lblPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPing.Location = new System.Drawing.Point(288, 97);
            this.lblPing.Name = "lblPing";
            this.lblPing.Size = new System.Drawing.Size(94, 20);
            this.lblPing.TabIndex = 3;
            this.lblPing.Text = "Ping: -- ms";
            // 
            // lblJitter
            // 
            this.lblJitter.AutoSize = true;
            this.lblJitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblJitter.Location = new System.Drawing.Point(288, 217);
            this.lblJitter.Name = "lblJitter";
            this.lblJitter.Size = new System.Drawing.Size(100, 20);
            this.lblJitter.TabIndex = 4;
            this.lblJitter.Text = "Jitter: -- ms";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.groupBox1.Controls.Add(this.lblJitter);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelAgim.ResumeLayout(false);
            this.panelAgim.PerformLayout();
            this.grpAgDurumu.ResumeLayout(false);
            this.grpAgDurumu.PerformLayout();
            this.panelHizTesti.ResumeLayout(false);
            this.panelHizTesti.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.GroupBox grpAgDurumu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgYenile;
        private System.Windows.Forms.Panel panelAgim;
        private System.Windows.Forms.Button btnHizTestiMenu;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnBilgi;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Button btnIpHesaplayici;
        private System.Windows.Forms.Button btnAğim;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelHizTesti;
        private System.Windows.Forms.Label lblHizBaslik;
        private System.Windows.Forms.Label lblPing;
        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.Label lblDownload;
        private System.Windows.Forms.Button btnHizTestiBaslat;
        private System.Windows.Forms.Label lblJitter;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

