using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_ochcka
{
    public partial class race : Form
    { 
        static int width = 20, height = 20;
        Pen Field = new Pen(Color.Red, 3);
        public int count;
        Bitmap bitmap;
        car Racer;
        SolidBrush Red = new SolidBrush(Color.DarkGray);
        aspalt aspalt;
        aspalt1 aspalt1;
        aspalt2 aspalt2;
        aspalt3 aspalt3;
        aspalt4 aspalt4;
        aspalt5 aspalt5;
        aspalt6 aspalt6;
        aspalt7 aspalt7;
        aspalt8 aspalt8;
        public race()
        {
            InitializeComponent();
            KeyPreview = true;
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Racer = new car();
            aspalt = new aspalt();
            timer1.Interval = 400;
            timer1.Enabled = true;
            aspalt1 = new aspalt1();
            aspalt2 = new aspalt2();
            aspalt3 = new aspalt3();
            aspalt4 = new aspalt4();
            aspalt5 = new aspalt5();
            aspalt6 = new aspalt6();
            aspalt7 = new aspalt7();
            aspalt8 = new aspalt8();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = Racer.coordinatSnakes.Count() - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    Racer.Move();
                }
                else
                {
                    var temp = Racer.coordinatSnakes[i];
                    temp.x = Racer.coordinatSnakes[i - 1].x;
                    temp.y = Racer.coordinatSnakes[i - 1].y;
                    Racer.coordinatSnakes[i] = temp;
                }
            }

            if ((Racer.coordinatSnakes[0].x == aspalt.x) && (Racer.coordinatSnakes[0].y == aspalt.y) || (Racer.coordinatSnakes[0].x == aspalt1.x) && (Racer.coordinatSnakes[0].y == aspalt1.y) || (Racer.coordinatSnakes[0].x == aspalt2.x) && (Racer.coordinatSnakes[0].y == aspalt2.y) || (Racer.coordinatSnakes[0].x == aspalt3.x) && (Racer.coordinatSnakes[0].y == aspalt3.y) || (Racer.coordinatSnakes[0].x == aspalt4.x) && (Racer.coordinatSnakes[0].y == aspalt4.y) || (Racer.coordinatSnakes[0].x == aspalt5.x) && (Racer.coordinatSnakes[0].y == aspalt5.y) || (Racer.coordinatSnakes[0].x == aspalt6.x) && (Racer.coordinatSnakes[0].y == aspalt6.y) || (Racer.coordinatSnakes[0].x == aspalt7.x) && (Racer.coordinatSnakes[0].y == aspalt7.y) || (Racer.coordinatSnakes[0].x == aspalt8.x) && (Racer.coordinatSnakes[0].y == aspalt8.y))
            {
                var temp = Racer.coordinatSnakes.Last();
                timer1.Interval = 100;
                timer1.Enabled = true;
            }

            if ((Racer.coordinatSnakes[0].x != aspalt.x) && (Racer.coordinatSnakes[0].y != aspalt.y) || (Racer.coordinatSnakes[0].x != aspalt1.x) && (Racer.coordinatSnakes[0].y != aspalt1.y) || (Racer.coordinatSnakes[0].x != aspalt2.x) && (Racer.coordinatSnakes[0].y != aspalt2.y) || (Racer.coordinatSnakes[0].x != aspalt3.x) && (Racer.coordinatSnakes[0].y != aspalt3.y) || (Racer.coordinatSnakes[0].x != aspalt4.x) && (Racer.coordinatSnakes[0].y != aspalt4.y) || (Racer.coordinatSnakes[0].x != aspalt5.x) && (Racer.coordinatSnakes[0].y != aspalt5.y) || (Racer.coordinatSnakes[0].x != aspalt6.x) && (Racer.coordinatSnakes[0].y != aspalt6.y) || (Racer.coordinatSnakes[0].x != aspalt7.x) && (Racer.coordinatSnakes[0].y != aspalt7.y) || (Racer.coordinatSnakes[0].x != aspalt8.x) && (Racer.coordinatSnakes[0].y != aspalt8.y))
            {
                var temp = Racer.coordinatSnakes.Last();
                timer1.Interval = 300;
                timer1.Enabled = true;
            }

            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.Green);

            for (int i = 0; i < Racer.coordinatSnakes.Count(); i++)
            {
                g.DrawRectangle(Field, Racer.coordinatSnakes[i].x * width, Racer.coordinatSnakes[i].y * height, width, height);
            }

            g.FillRectangle(Red, aspalt.x * width, aspalt.y * height, width, height);
            g.FillRectangle(Red, aspalt1.x * width, aspalt1.y * height, width, height);
            g.FillRectangle(Red, aspalt2.x * width, aspalt2.y * height, width, height);
            g.FillRectangle(Red, aspalt3.x * width, aspalt3.y * height, width, height);
            g.FillRectangle(Red, aspalt4.x * width, aspalt4.y * height, width, height);
            g.FillRectangle(Red, aspalt5.x * width, aspalt5.y * height, width, height);
            g.FillRectangle(Red, aspalt6.x * width, aspalt6.y * height, width, height);
            g.FillRectangle(Red, aspalt7.x * width, aspalt7.y * height, width, height);
            g.FillRectangle(Red, aspalt8.x * width, aspalt8.y * height, width, height);
            if ((Racer.coordinatSnakes[0].x < 0) || (Racer.coordinatSnakes[0].x > width) || (Racer.coordinatSnakes[0].y < 0) || (Racer.coordinatSnakes[0].y > height))
            {
                timer1.Stop();
                MessageBox.Show("ВЫ РАЗБИЛИ МАШИНУ!");
                label2.Text = count.ToString();
                vibor f = new vibor();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            pictureBox1.Image = bitmap;
        }

        private void race_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "W":
                    {
                        Racer.WantNavigation = 'T';
                        break;
                    }
                case "A":
                    {
                        Racer.WantNavigation = 'L';
                        break;
                    }
                case "S":
                    {
                        Racer.WantNavigation = 'D';
                        break;
                    }
                case "D":
                    {
                        Racer.WantNavigation = 'R';
                        break;
                    }
                default:
                    {
                        Racer.WantNavigation = Racer.Navigation;
                        break;
                    }
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void race_Load(object sender, EventArgs e)
        {

        }

    }
}
