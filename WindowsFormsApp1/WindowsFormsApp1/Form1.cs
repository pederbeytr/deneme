using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Media;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string baslik = Interaction.InputBox("Yeni form başlığı gir agaaaa :", "İsim değiştirme");

            this.Text = baslik;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = "İsim değiştirildi";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog arka = new OpenFileDialog();

            arka.Title = "Arka plan seç";

            if (arka.ShowDialog()==DialogResult.OK)
            {
                Bitmap resim = new Bitmap(arka.FileName);

                BackgroundImage = resim;
                button10.Enabled = true;
                button9.Enabled = true;
                button8.Enabled = true;
                button7.Enabled = true;
                button6.Enabled = true;



            }

 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog renkd = new ColorDialog();

            if (renkd.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = renkd.Color;
                MessageBox.Show("Arka Plan rengi" + renkd.Color.Name.ToString() + "olarak değiştirildi", "Arka Plan Rengi Değiştirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Arka Plan rengi değiştirilimedi", "Arka Plan Rengi Değiştirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string renk = Interaction.InputBox("Ana renkler için 1 , RGB renkler için 2 yaz", "Renk Değiştirme");

            switch (renk)
            {
                case "1":  this.BackColor = Color.Aqua; break;
                case "2": 
                    Random rbg = new Random();
                    int r, g, b;
                    r = rbg.Next(0,256);
                    g = rbg.Next(0,256);
                    b = rbg.Next(0,256);
                    this.BackColor = Color.FromArgb(r, g, b);
                break;

                default:
                    MessageBox.Show("Yanlış değer girildi", "Renk Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Tile;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.None;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Center;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog()==DialogResult.OK)
            {
                this.Font = font.Font;
                MessageBox.Show("Formun fontu değiştirildi brom", "Font Değiştirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Formun fontu değiştirilmedi.","Bilgi Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SoundPlayer music = new SoundPlayer();
            string dizin = Application.StartupPath + "\\song.wav";
           music.SoundLocation = dizin;
            music.Play();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            SoundPlayer music = new SoundPlayer();
            string dizin = Application.StartupPath + "\\song.wav";
            music.SoundLocation = dizin;
            music.Stop();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Font font = new Font("font", 10, FontStyle.Regular);
            this.Font = font;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                this.ForeColor = cld.Color;
                MessageBox.Show("Ön plan rengi " + cld.Color.Name.ToString() + " olarak değiştirildi","Bilgi Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ön plan rengi değiştirilmedi","Bilgi Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string projectAddress = Environment.CurrentDirectory;
            ofd.InitialDirectory = projectAddress;

            ofd.Title = "İkon Resmini Seç";
            ofd.Filter = "ico Dosyaları | *.ico;";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Icon ico = new Icon(ofd.FileName);
                this.Icon = ico;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Icon ico = new Icon(@".\uni.ico");
            this.Icon = ico;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.ShowIcon = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.ShowIcon = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            

            Random x = new Random ();

            int sayi = x.Next(6);

            switch (sayi)
            {
                case 1:
                    SoundPlayer music = new SoundPlayer();
                    string dizin = Application.StartupPath + "\\wtf.wav";
                    music.SoundLocation = dizin;
                    music.Play();
                    break;

                case 2:
                    SoundPlayer music2 = new SoundPlayer();
                    string dizin2 = Application.StartupPath + "\\omg.wav";
                    music2.SoundLocation = dizin2;
                    music2.Play();
                    break;

                case 3:
                    SoundPlayer music3 = new SoundPlayer();
                    string dizin3 = Application.StartupPath + "\\nice.wav";
                    music3.SoundLocation = dizin3;
                    music3.Play();
                    break;

                case 4:
                    SoundPlayer music4 = new SoundPlayer();
                    string dizin4 = Application.StartupPath + "\\cry.wav";
                    music4.SoundLocation = dizin4;
                    music4.Play();
                    break;

                case 5:
                    SoundPlayer music5 = new SoundPlayer();
                    string dizin5 = Application.StartupPath + "\\okay.wav";
                    music5.SoundLocation = dizin5;
                    music5.Play();
                    break;

                case 6:
                    SoundPlayer music6 = new SoundPlayer();
                    string dizin6 = Application.StartupPath + "\\y.wav";
                    music6.SoundLocation = dizin6;
                    music6.Play();
                    break;

                case 7:
                    SoundPlayer music7 = new SoundPlayer();
                    string dizin7 = Application.StartupPath + "\\hs.wav";
                    music7.SoundLocation = dizin7;
                    music7.Play();
                    break;

               

            }



           

        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Thread.Sleep(5000);
            this.Enabled = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.AutoScroll = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.AutoScroll = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.AutoSize = true;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.AutoSize = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowOnly;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            this.MaximizeBox = true;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.HelpButton = true;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            int w = Convert.ToInt32(textbox2.Text);
            int h = Convert.ToInt32(textbox3.Text);

            if (w!=0||h!=0)
            {
                this.Size = new Size(w, h);

            }
            else
            {
                  
            }

        }

        private void h_TextChanged(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {
            textbox2.Text = "";
            textbox3.Text = "";
            this.Size = new Size(825, 490);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
    
}
