using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace clock
{
    public partial class Form1 : Form
    {
        int cx = 175, cy = 175; // Центр картинки.
        int secHAND = 100, minHAND = 90, hrHAND = 75;
        Timer t = new Timer();

        System.Drawing.Size  fontsize;

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();

        bool Electroni_clock = false;
        bool Settings = false;
        bool secundam = false;

        int s = 0;
        int m = 0;
        int h = 0;

        ColorDialog Dima = new ColorDialog();
        FontDialog Fontein = new FontDialog();
        Color CHandS = Color.DarkOrange;
        Color CHandM = Color.Gray;
        Color CHandH = Color.Black;
        Color clock = Color.Black;

        private void Form1_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;  //В миллисекундах
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }
        private int[] msCoord(int val, int hlen)
        {
            int[] coord = new int[2];
            val *= 6;

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }
        private int[] hrCoord(int hval, int mval, int hlen)
        {
            int[] coord = new int[2];
            int val = (int)((hval * 30) + (mval * 0.5));

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void электронкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Electroni_clock)
            {
                Size = new Size(350, 350);
                Electroni_clock = false;
                TimeLabel.Visible = false;
            }
            else
            {
                Size = new Size(350, 400);
                Electroni_clock = true;
                TimeLabel.Visible = true;
            }
        }
        private void настройкиToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Settings && Electroni_clock)
            {
                Size = new Size(350, 400);
                Settings = false;
                pictureBox2.Visible = false;
            }
            else if(Settings && !Electroni_clock)
            {
                Size = new Size(350, 350);
                Settings = false;
                pictureBox2.Visible = false;
            }
            else
            {
                Size = new Size(830, 450);
                Settings = true;
                pictureBox2.Visible = true;
            }
        }

        private void секундомерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] handCoord = new int[2];
            Graphics g = pictureBox1.CreateGraphics();

            ////стирание стрелок
            handCoord = msCoord(s, secHAND + 4);
            g.DrawLine(new Pen(Color.White, 45f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));
            handCoord = msCoord(m, minHAND + 4);
            g.DrawLine(new Pen(Color.White, 40f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));
            handCoord = hrCoord(h % 12, m, hrHAND + 4);
            g.DrawLine(new Pen(Color.White, 20f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));
            TimeLabel.Text = "";

            secundam = !secundam;
            s = 0;
            m = 0;
            h = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (Dima.ShowDialog() == DialogResult.OK) CHandS = Dima.Color;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (Dima.ShowDialog() == DialogResult.OK) CHandM = Dima.Color;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (Dima.ShowDialog() == DialogResult.OK) CHandH = Dima.Color;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (Dima.ShowDialog() == DialogResult.OK) clock = Dima.Color;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ///Шрифт часов
            if (Fontein.ShowDialog() == DialogResult.OK)
            {
                Font Num = new Font(Fontein.Font.FontFamily, Num0.Font.Size, Fontein.Font.Style);
                Num0.Font = Num;
                Num1.Font = Num;
                Num2.Font = Num;
                Num3.Font = Num;
                Num4.Font = Num;
                Num5.Font = Num;
                Num6.Font = Num;
                Num7.Font = Num;
                Num8.Font = Num ;
                Num9.Font = Num;
                Num10.Font = Num;
                Num11.Font = Num;
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (Dima.ShowDialog() == DialogResult.OK) TimeLabel.ForeColor = Dima.Color;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (Fontein.ShowDialog() == DialogResult.OK) { 
                Font El = new Font(Fontein.Font.FontFamily, TimeLabel.Font.Size, Fontein.Font.Style);
                TimeLabel.Font = El;
            }
        }

        private void внизуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeLabel.Location = new Point(83, 351);
            TimeLabel.BackColor = Color.AliceBlue;
        }

        private void посерединеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeLabel.Location = new Point(83, 151);
            TimeLabel.BackColor = Color.White;
        }

        private void t_Tick(object sender, EventArgs e)
        {
            if (!secundam)
            {
                s = DateTime.Now.Second;
                m = DateTime.Now.Minute;
                h = DateTime.Now.Hour;
            }
            else
            {
                s++;
                if (s == 60) m += 1;
                if (m == 60) h += 1;
                if (h == 24)
                {
                    s = 0;
                    m = 0;
                    h = 0;
                }
            }

            int[] handCoord = new int[2];
            Graphics g = pictureBox1.CreateGraphics();

            TimeLabel.Text = "";
            g.DrawEllipse(new Pen(Color.White, 170f), 90, 90, 170, 170);


            /////рисование стрелок
            handCoord = hrCoord(h % 12, m, hrHAND);
            g.DrawLine(new Pen(CHandH, 4f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));
            handCoord = msCoord(m, minHAND);
            g.DrawLine(new Pen(CHandM, 2f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));
            handCoord = msCoord(s, secHAND);
            g.DrawLine(new Pen(CHandS, 2f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            g.DrawEllipse(new Pen(clock, 6f), 2, 2, 345, 345);

            if (h < 10) TimeLabel.Text += $"0{h}:";
            else TimeLabel.Text += $"{h}:";
            if (m < 10) TimeLabel.Text += $"0{m}:";
            else TimeLabel.Text += $"{m}:";
            if (s < 10) TimeLabel.Text += $"0{s}";
            else TimeLabel.Text += $"{s}";
        }
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.AliceBlue;
            this.TransparencyKey = this.BackColor;
            ContextMenuStrip = contextMenuStrip1;

            fontsize = Num0.Size;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            const uint WM_SYSCOMMAND = 0x0112;
            const uint DOMOVE = 0xF012;

            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }
    }
}
