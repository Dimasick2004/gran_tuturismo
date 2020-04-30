using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace final_ochcka
{
    public partial class vibor : Form
    {
        
        public vibor()
        {
            InitializeComponent();
        }

        private void cars_Click(object sender, EventArgs e)
        {
            tracks.Hide();
            text.Show();
            fiat.Show();
            nsx.Show();
            r34.Show();
            aventador.Show();
            nissan_gtr.Show();
            fiat_big.Hide();
            nsx_big.Hide();
            r34_big.Hide();
            aventador_big.Hide();
            nissan_gtr_big.Hide();
            cars.Hide();
        }

        private void tracks_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vibor_Load(object sender, EventArgs e)
        {
            cars.Show();
            text.Hide();
            fiat.Hide();
            nsx.Hide();
            r34.Hide();
            aventador.Hide();
            nissan_gtr.Hide();
            car_name.Hide();
            fiat_big.Hide();
            r34_big.Hide();
            nsx_big.Hide();
            aventador_big.Hide();
            nissan_gtr_big.Hide();
            start_race.Hide();
        }

        private void fiat_Click(object sender, EventArgs e)
        {
            cars.Hide();
            text.Hide();
            tracks.Hide();
            fiat_big.Show();
            car_name.Show();
            car_name.Text = "FIAT 500F '68 ДАННАЯ МАШИНА НЕДОСТУПНА";
        }

        private void fiat_big_Click(object sender, EventArgs e)
        {

        }



        private void car_name_Click(object sender, EventArgs e)
        {

        }

        private void nsx_big_Click(object sender, EventArgs e)
        {

        }

        private void r34_Click(object sender, EventArgs e)
        {
            cars.Hide();
            text.Hide();
            tracks.Hide();
            r34_big.Show();
            car_name.Show();
            car_name.Text = "NISSAN SKYLINE GT-R V SPEC II NUR (R34) '99 ДАННАЯ МАШИНА НЕДОСТУПНА";
        }

        private void nsx_Click(object sender, EventArgs e)
        {
            cars.Hide();
            text.Hide();
            tracks.Hide();
            nsx_big.Show();
            car_name.Show();
            car_name.Text = "HONDA NSX TYPE R '02 ДАННАЯ МАШИНА НЕДОСТУПНА";
        }

        private void start_race_Click(object sender, EventArgs e)
        {
            race f = new race();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void nissan_gtr_Click(object sender, EventArgs e)
        {
            cars.Hide();
            text.Hide();
            tracks.Hide();
            nissan_gtr_big.Show();
            car_name.Show();
            car_name.Text = "NISSAN GTR '07 ДАННАЯ МАШИНА НЕДОСТУПНА";
        }

        private void aventador_Click(object sender, EventArgs e)
        {
            cars.Hide();
            text.Hide();
            tracks.Hide();
            aventador_big.Show();
            car_name.Show();
            car_name.Text = "LAMBORGHINI AVENTADOR LP 700-4 '11";
            start_race.Show();
        }
    }
} 
