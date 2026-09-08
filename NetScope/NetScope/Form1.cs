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
using System.Net.Http;
using System.Diagnostics;
using System.IO;
using System.Media;

namespace NetScope
{
    public partial class NetScope : Form
    {
        private SoundPlayer hoverSesi;
        private SoundPlayer clickSesi;

        public NetScope()
        {
            InitializeComponent();
            
            panelHizTesti.ForeColor = Color.White;
            ComboBoxSubnet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            ButonYuvarla(btnHizTestiBaslat, 15);
            ButonYuvarla(btnAğim, 15);
            ButonYuvarla(btnIpHesaplayici, 15);
            ButonYuvarla(btnPing, 15);
            ButonYuvarla(btnHizTestiMenu, 15);
            ButonYuvarla(btnBilgi, 15);
            ButonYuvarla(btnAyarlar, 15);
            ButonYuvarla(btnAgYenile, 15);
            ButonYuvarla(btnHesapla, 15);

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

            btnHesapla.MouseEnter += Buton_MouseEnter;
            btnHesapla.MouseLeave += Buton_MouseLeave;
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
            clickSesi.Play();
            SayfaGöster(PanelSubnetHesaplayıcı);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clickSesi.Play();
            SayfaGöster(PanelPing);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clickSesi.Play();
            SayfaGöster(Ayarlar);
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clickSesi.Play();
            SayfaGöster(Bilgi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            hoverSesi = new SoundPlayer(Properties.Resources.Hover_sesi);
            clickSesi = new SoundPlayer(Properties.Resources.Tıklama_sesi);

            hoverSesi.Load();
            clickSesi.Load();

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

            ComboBoxSubnet.Items.Clear();
            ComboBoxSubnet.Items.AddRange(new string[]
            {
    "255.0.0.0 (/8)",
    "255.255.0.0 (/16)",
    "255.255.255.0 (/24)",
    "255.255.255.128 (/25)",
    "255.255.255.192 (/26)",
    "255.255.255.224 (/27)",
    "255.255.255.240 (/28)",
    "255.255.255.248 (/29)",
    "255.255.255.252 (/30)",
    "255.255.255.254 (/31)",
    "255.255.255.255 (/32)"
            });
            ComboBoxSubnet.SelectedIndex = 2; // Varsayılan: 255.255.255.0 (/24)

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
        private bool testDevamEdiyor = false;
        string Mesaj;
        string HataMesaji;

        string pingMesajı, DownloadMesajı, UploadMesajı;
        string Mesaj1;
        string bağlıMesaj;
        private async void button2_Click_1(object sender, EventArgs e)
        {
            clickSesi.Play();
            if (testDevamEdiyor)
            {
                return;
            }

            testDevamEdiyor = true;
            string orijinalMetin = btnHizTestiBaslat.Text;
            

            lblPing.Text = "Ping: -- ms";
            lblDownload.Text = "Download: -- Mbps";
            lblUpload.Text = "Upload: -- Mbps";

            try
            {
                btnHizTestiBaslat.Text = pingMesajı;
                long pingMs = await PingTestiYapAsync("8.8.8.8");
                lblPing.Text = pingMs >= 0 ? $"Ping: {pingMs} ms" : $"Ping: {HataMesaji}";

                btnHizTestiBaslat.Text = DownloadMesajı;
                double indirmeMbps = await IndirmeTestiYapAsync();
                lblDownload.Text = indirmeMbps >= 0 ? $"Download: {indirmeMbps:0.00} Mbps" : $"Download: {HataMesaji}";

                btnHizTestiBaslat.Text = UploadMesajı;
                double yuklemeMbps = await YuklemeTestiYapAsync();
                lblUpload.Text = yuklemeMbps >= 0 ? $"Upload: {yuklemeMbps:0.00} Mbps" : $"Upload: {HataMesaji}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"{Mesaj1}" + ex.Message,
                    $"{HataMesaji}",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnHizTestiBaslat.Text = orijinalMetin;
                testDevamEdiyor = false;
            }
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
            Bilgi.Visible = false;
            PanelSubnetHesaplayıcı.Visible = false;
            PanelPing.Visible = false;

            panel.Visible = true;
            panel.BringToFront();
        }

        private void panelAgim_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgYenile_Click(object sender, EventArgs e)
        {
            clickSesi.Play();
            AgBilgileriniGetir();
        }

        private void btnHizTestiMenu_Click(object sender, EventArgs e)
        {
            clickSesi.Play();
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
                lblHizBaslik.Text = "İnternet Hız Testi";
                lblBaslik.Text = "Ağ Durumu"; 
                btnAgYenile.Text = "Ağı Yenile";
                label1.Text = "Bağlantı:";
                grpAgDurumu.Text = "Bağlantı Bilgileri";
                Mesaj = "Ağ bilgileri alınamadı:\n";
                HataMesaji = "Hata";
                pingMesajı = "Ping ölçülüyor...";
                DownloadMesajı = "İndirme ölçülüyor...";
                UploadMesajı = "Yükleme ölçülüyor...";
                Mesaj1 = "Hız testi sırasında bir hata oluştu:\n";
                bağlıMesaj = "Bağlı değil";
                lblBilgiBaslik.Text = "Temel Ağ Bilgisi";
                lbnIPAdresi.Text = "IP Adresi:";
                lbnSubnetMaskesi.Text = "Alt Ağ Maskesi:";
                GroupSonuçlar.Text = "Sonuçlar";
                rtbBilgi.Text =
                    "IP Adresi: Cihazınızın ağdaki kimliğidir. Örn: 192.168.1.5\n\n" +
                    "Alt Ağ Maskesi (Subnet Mask): Bir ağın hangi IP aralığını kapsadığını belirler. Örn: 255.255.255.0\n\n" +
                    "Ağ Geçidi (Gateway): Yerel ağınızı internete bağlayan cihazdır (genellikle modem/router).\n\n" +
                    "DNS: Alan adlarını (örn. google.com) IP adreslerine çeviren sistemdir.\n\n" +
                    "Ping: Bir isteğin karşı sunucuya gidip geri dönme süresidir, milisaniye (ms) cinsinden ölçülür.\n" +
                    " Düşük ping, daha hızlı tepki demektir.\n" +
                    "\nDownload (İndirme) Hızı: Internetten cihazınıza veri gelme hızıdır, Mbps (megabit/saniye) cinsinden ölçülür.\n\n" +
                    "Upload (Yükleme) Hızı: Cihazınızdan internete veri gönderme hızıdır.\n\n" +
                    "Not: Mbps ile MB/s birbirinden farklıdır. 8 Mbps ≈ 1 MB/s (1 bayt = 8 bit).";
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
                lblHizBaslik.Text = "Internet Speed Test";
                lblBaslik.Text = "Network Status";
                btnAgYenile.Text = "Refresh";
                label1.Text = "Connection:";
                grpAgDurumu.Text = "Connection Information";
                Mesaj = "Could not retrieve network information:\n";
                HataMesaji = "Error";
                pingMesajı = "Measuring ping...";
                DownloadMesajı = "Measuring download...";
                UploadMesajı = "Measuring upload...";
                Mesaj1 = "An error occurred during the speed test:\n";
                bağlıMesaj = "Not connected";
                lblBilgiBaslik.Text = "Basic Network Info";
                lbnIPAdresi.Text = "IP Address:";
                lbnSubnetMaskesi.Text = "Subnet Mask:";
                GroupSonuçlar.Text = "Results"; 
                rtbBilgi.Text =
                    "IP Address: Your device's identity on the network. Ex: 192.168.1.5\n\n" +
                    "Subnet Mask: Defines which IP range a network covers. Ex: 255.255.255.0\n\n" +
                    "Gateway: The device that connects your local network to the internet (usually your router/modem).\n\n" +
                    "DNS: The system that translates domain names (e.g. google.com) into IP addresses.\n\n" +
                    "Ping: The time it takes for a request to reach a server and come back, measured in milliseconds (ms).\n" +
                    "Lower ping means faster response.\n" +
                    "\nDownload Speed: How fast data comes from the internet to your device," +
                    "\nmeasured in Mbps (megabits per second).\n" +
                    "\nUpload Speed: How fast data goes from your device to the internet.\n" +
                    "Note: Mbps and MB/s are different. 8 Mbps ≈ 1 MB/s (1 byte = 8 bits).";






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
            string baglanti = bağlıMesaj;
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

                    var ipBilgisi = ozellikler.UnicastAddresses
                        .FirstOrDefault(a =>
                            a.Address.AddressFamily == AddressFamily.InterNetwork);

                    if (ipBilgisi != null)
                    {
                        ipv4 = ipBilgisi.Address.ToString();
                    }

                    var gatewayBilgisi = ozellikler.GatewayAddresses
                        .FirstOrDefault(g =>
                            g.Address.AddressFamily == AddressFamily.InterNetwork);

                    if (gatewayBilgisi != null)
                    {
                        gateway = gatewayBilgisi.Address.ToString();
                    }

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
                    $"{Mesaj}" + ex.Message, 
                    $"{HataMesaji}",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            label8.Text = baglanti;
            label7.Text = ipv4;
            label6.Text = gateway;
            label5.Text = dns;
        }



        private static readonly HttpClient httpClient = new HttpClient();

        

        private async Task<long> PingTestiYapAsync(string host)
        {
            try
            {
                using (var ping = new Ping())
                {
                    long toplamSure = 0;
                    int basariliSayisi = 0;

                    for (int i = 0; i < 4; i++)
                    {
                        PingReply reply = await ping.SendPingAsync(host, 2000);

                        if (reply.Status == IPStatus.Success)
                        {
                            toplamSure += reply.RoundtripTime;
                            basariliSayisi++;
                        }
                    }

                    return basariliSayisi > 0 ? toplamSure / basariliSayisi : -1;
                }
            }
            catch
            {
                return -1;
            }
        }

        private void ComboBoxSubnet_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbnIPAdresi_Click(object sender, EventArgs e)
        {

        }

        private void PanelSubnetHesaplayıcı_Paint(object sender, PaintEventArgs e)
        {

        }

        private void m(object sender, EventArgs e)
        {
            clickSesi.Play();
            SayfaGöster(panelAgim);
        }

        private void btnAğim_MouseHover(object sender, EventArgs e)
        {
            hoverSesi.Play();
        }

        private void btnIpHesaplayici_MouseHover(object sender, EventArgs e)
        {
            hoverSesi.Play();
        }

        private void btnPing_MouseHover(object sender, EventArgs e)
        {
            hoverSesi.Play();
        }

        private void btnHizTestiMenu_MouseHover(object sender, EventArgs e)
        {
            hoverSesi.Play();
        }

        private void btnBilgi_MouseHover(object sender, EventArgs e)
        {
            hoverSesi.Play();
        }

        private void btnAyarlar_MouseHover(object sender, EventArgs e)
        {
            hoverSesi.Play();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            clickSesi.Play();

            string ipMetni = textBox1.Text.Trim();

            if (!IPAddress.TryParse(ipMetni, out IPAddress ip) || ip.AddressFamily != AddressFamily.InterNetwork)
            {
                MessageBox.Show("Geçerli bir IPv4 adresi girin. Örn: 192.168.1.25", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ComboBoxSubnet.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir subnet maskesi seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string secilen = ComboBoxSubnet.SelectedItem.ToString(); // Örn: "255.255.255.0 (/24)"
            int slashIndex = secilen.IndexOf('/');
            int parantezIndex = secilen.IndexOf(')');
            int cidr = int.Parse(secilen.Substring(slashIndex + 1, parantezIndex - slashIndex - 1));

            uint ipSayi = IpToUInt(ip);
            uint maske = cidr == 0 ? 0 : 0xFFFFFFFF << (32 - cidr);

            uint agAdresi = ipSayi & maske;
            uint yayinAdresi = agAdresi | ~maske;

            long toplamAdres = (long)Math.Pow(2, 32 - cidr);
            long kullanilabilirHost = cidr >= 31 ? 0 : toplamAdres - 2;

            string ilkIp = cidr >= 31 ? UIntToIp(agAdresi).ToString() : UIntToIp(agAdresi + 1).ToString();
            string sonIp = cidr >= 31 ? UIntToIp(yayinAdresi).ToString() : UIntToIp(yayinAdresi - 1).ToString();

            lblNetwork.Text = UIntToIp(agAdresi).ToString();
            lblBroadcast.Text = UIntToIp(yayinAdresi).ToString();
            lblIlkIp.Text = ilkIp;
            lblSonIp.Text = sonIp;
            lblHostSayisi.Text = kullanilabilirHost.ToString();
            lblCidr.Text = "/" + cidr;
        }

        private void btnHesapla_MouseHover(object sender, EventArgs e)
        {
            hoverSesi.Play();
        }

        private void btnHizTestiBaslat_MouseHover(object sender, EventArgs e)
        {
            hoverSesi.Play();
        }

        private void btnAgYenile_MouseHover(object sender, EventArgs e)
        {
            hoverSesi.Play();
        }

        private async Task<double> IndirmeTestiYapAsync()
        {
            try
            {
                const long hedefBoyutBayt = 25_000_000; 
                string url = $"https://speed.cloudflare.com/__down?bytes={hedefBoyutBayt}";

                var kronometre = Stopwatch.StartNew();
                long okunanBayt = 0;

                using (var yanit = await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
                {
                    yanit.EnsureSuccessStatusCode();

                    using (var akis = await yanit.Content.ReadAsStreamAsync())
                    {
                        byte[] tampon = new byte[81920];
                        int okunan;

                        while ((okunan = await akis.ReadAsync(tampon, 0, tampon.Length)) > 0)
                        {
                            okunanBayt += okunan;
                        }
                    }
                }

                kronometre.Stop();

                double saniye = kronometre.Elapsed.TotalSeconds;
                if (saniye <= 0 || okunanBayt == 0) return -1;

                return (okunanBayt * 8.0) / saniye / 1_000_000.0; 
            }
            catch
            {
                return -1;
            }
        }

        private async Task<double> YuklemeTestiYapAsync()
        {
            try
            {
                const int veriBoyutuBayt = 5_000_000; 
                byte[] veri = new byte[veriBoyutuBayt];
                new Random().NextBytes(veri);

                string url = "https://speed.cloudflare.com/__up";

                var kronometre = Stopwatch.StartNew();

                using (var icerik = new ByteArrayContent(veri))
                {
                    icerik.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");

                    using (var yanit = await httpClient.PostAsync(url, icerik))
                    {
                        yanit.EnsureSuccessStatusCode();
                    }
                }

                kronometre.Stop();

                double saniye = kronometre.Elapsed.TotalSeconds;
                if (saniye <= 0) return -1;

                return (veriBoyutuBayt * 8.0) / saniye / 1_000_000.0;
            }
            catch
            {
                return -1;
            }
        }

        private uint IpToUInt(IPAddress ip)
        {
            byte[] bayt = ip.GetAddressBytes();
            if (BitConverter.IsLittleEndian) Array.Reverse(bayt);
            return BitConverter.ToUInt32(bayt, 0);
        }

        private IPAddress UIntToIp(uint deger)
        {
            byte[] bayt = BitConverter.GetBytes(deger);
            if (BitConverter.IsLittleEndian) Array.Reverse(bayt);
            return new IPAddress(bayt);
        }































    }
}
