using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

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

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

            panel.Visible = true;
            panel.BringToFront();
        }

        private void panelAgim_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgYenile_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHizTestiMenu_Click(object sender, EventArgs e)
        {
            SayfaGöster(panelHizTesti);
        }
    }
}
