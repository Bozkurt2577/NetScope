using NetScope.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace NetScope
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

            ButonYuvarla(btnHizTestiBaslat, 15);
            ButonYuvarla(btnAğim, 15);
            ButonYuvarla(btnIpHesaplayici, 15);
            ButonYuvarla(btnPing, 15);
            ButonYuvarla(btnHizTestiMenu, 15);
            ButonYuvarla(btnBilgi, 15);
            ButonYuvarla(btnAyarlar, 15);
            ButonYuvarla(btnAgYenile, 15);

            btnAğim.MouseEnter += Buton_MouseEnter;
            btnAğim.MouseLeave += Buton_MouseLeave;

            btnIpHesaplayici.MouseEnter += Buton_MouseEnter;
            btnIpHesaplayici.MouseLeave += Buton_MouseLeave;

            btnPing.MouseEnter += Buton_MouseEnter;
            btnPing.MouseLeave += Buton_MouseLeave;

            btnHizTestiMenu.MouseEnter += Buton_MouseEnter;
            btnHizTestiMenu.MouseLeave += Buton_MouseLeave;

            btnBilgi.MouseEnter += Buton_MouseEnter;
            btnBilgi.MouseLeave += Buton_MouseLeave;

            btnAyarlar.MouseEnter += Buton_MouseEnter;
            btnAyarlar.MouseLeave += Buton_MouseLeave;

            btnHizTestiBaslat.MouseEnter += Buton_MouseEnter;
            btnHizTestiBaslat.MouseLeave += Buton_MouseLeave;

            btnAgYenile.MouseEnter += Buton_MouseEnter;
            btnAgYenile.MouseLeave += Buton_MouseLeave;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnAğim_Click(object sender, EventArgs e)
        {
            SayfaGöster(panelAgim);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SayfaGöster(Ayarlar);
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            comboBox1.Items.Add("Türkçe");
            comboBox1.Items.Add("English");


            if(Properties.Settings.Default.Language == "tr-TR")
            {
                comboBox1.SelectedIndex = 0;
            }

            else
            {
                comboBox1.SelectedIndex = 1;
            }

            UygulamaDiliniUygula();
            AgBilgileriniGetir();

        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grpAgDurumu_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Buton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button buton)
            {
                buton.BackColor = Color.FromArgb(30, 136, 229);
            }
        }

        private void Buton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button buton)
            {
                buton.BackColor = Color.FromArgb(32, 38, 51);
            }
        }

        private void ButonYuvarla(Button buton, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(buton.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(buton.Width - radius, buton.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, buton.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            buton.Region = new Region(path);
        }

        private void SayfaGöster(Panel panel)
        {
            panelAgim.Visible = false;
            panelHizTesti.Visible = false;
            Ayarlar.Visible = false;

            panel.Visible = true;
            panel.BringToFront();
        }

        private void panelAgim_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgYenile_Click(object sender, EventArgs e)
        {
            AgBilgileriniGetir();
        }

        private void btnHizTestiMenu_Click(object sender, EventArgs e)
        {
            SayfaGöster(panelHizTesti);
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                DilDegistir("tr-TR");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                DilDegistir("en");
            }
        }

        private void UygulamaDiliniUygula()
        {
            string dil = Properties.Settings.Default.Language;

            if (dil == "tr-TR")
            {
                btnAğim.Text = "Ağım";
                btnIpHesaplayici.Text = "IP Subnet Hesaplayıcı";
                btnBilgi.Text = "Bilgi";
                btnAyarlar.Text = "Ayarlar";
                lblLanguage.Text = "Dil";
                btnHizTestiMenu.Text = "Hız Testi";
                btnHizTestiBaslat.Text = "Hız Testini Başlat";
                groupBox1.Text = "Hız Testi";
                lblBaslik.Text = "İnternet Hız Testi";
                btnAgYenile.Text = "Ağı Yenile";
                label1.Text = "Bağlantı";
                grpAgDurumu.Text = "Bağlantı Bilgileri";
            }
            else
            {
                btnAğim.Text = "My Network";
                btnIpHesaplayici.Text = "IP Subnet Calculator";
                btnBilgi.Text = "Information";
                btnAyarlar.Text = "Settings";
                lblLanguage.Text = "Language";
                btnHizTestiMenu.Text = "Speed Test";
                btnHizTestiBaslat.Text = "Start Speed Test";
                groupBox1.Text = "Speed Test";
                lblBaslik.Text = "Internet Speed Test";
                btnAgYenile.Text = "Refresh";
                label1.Text = "Connection";
                grpAgDurumu.Text = "Connection Information";
            }
        }

        private void DilDegistir(string dil)
        {
            Properties.Settings.Default.Language = dil;
            Properties.Settings.Default.Save();

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(dil);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(dil);

            UygulamaDiliniUygula();
        }


        private void AgBilgileriniGetir()
        {
            string baglanti = "Bağlı Değil";
            string ipv4 = "-";
            string gateway = "-";
            string dns = "-";

            try
            {
                var kartlar = NetworkInterface.GetAllNetworkInterfaces()
                    .Where(n =>
                        n.OperationalStatus == OperationalStatus.Up &&
                        n.NetworkInterfaceType != NetworkInterfaceType.Loopback &&
                        n.NetworkInterfaceType != NetworkInterfaceType.Tunnel)
                    .ToList();

                NetworkInterface aktifKart = null;

                // Gateway'i olan IPv4 bağlantıyı bul
                foreach (var kart in kartlar)
                {
                    var ozellikler = kart.GetIPProperties();

                    bool ipv4Var = ozellikler.UnicastAddresses.Any(a =>
                        a.Address.AddressFamily == AddressFamily.InterNetwork);

                    bool gatewayVar = ozellikler.GatewayAddresses.Any(g =>
                        g.Address.AddressFamily == AddressFamily.InterNetwork);

                    if (ipv4Var && gatewayVar)
                    {
                        aktifKart = kart;
                        break;
                    }
                }

                // Gateway bulunamazsa IPv4 bağlantıyı bul
                if (aktifKart == null)
                {
                    aktifKart = kartlar.FirstOrDefault(k =>
                        k.GetIPProperties().UnicastAddresses.Any(a =>
                            a.Address.AddressFamily == AddressFamily.InterNetwork));
                }

                if (aktifKart != null)
                {
                    var ozellikler = aktifKart.GetIPProperties();

                    baglanti = aktifKart.Name;

                    // IPv4
                    var ipBilgisi = ozellikler.UnicastAddresses
                        .FirstOrDefault(a =>
                            a.Address.AddressFamily == AddressFamily.InterNetwork);

                    if (ipBilgisi != null)
                    {
                        ipv4 = ipBilgisi.Address.ToString();
                    }

                    // Gateway
                    var gatewayBilgisi = ozellikler.GatewayAddresses
                        .FirstOrDefault(g =>
                            g.Address.AddressFamily == AddressFamily.InterNetwork);

                    if (gatewayBilgisi != null)
                    {
                        gateway = gatewayBilgisi.Address.ToString();
                    }

                    // DNS
                    var dnsBilgisi = ozellikler.DnsAddresses
                        .FirstOrDefault(d =>
                            d.AddressFamily == AddressFamily.InterNetwork);

                    if (dnsBilgisi != null)
                    {
                        dns = dnsBilgisi.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ağ bilgileri alınamadı:\n" + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            label8.Text = baglanti;
            label7.Text = ipv4;
            label6.Text = gateway;
            label5.Text = dns;
        }



    }
}
