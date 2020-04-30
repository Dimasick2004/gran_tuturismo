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
    public partial class main_menu : Form
    {
        SoundPlayer sf = new SoundPlayer(@"C:\Users\User\source\repos\final_ochcka\final_ochcka\Resources\Gran Turismo 4 Music – Arcade Mode.wav");
        public main_menu()
        {
            InitializeComponent();
        }

        private void main_menu_Load(object sender, EventArgs e)
        {
            sf.Play();
        }

        private void start_Click(object sender, EventArgs e)
        {
            vibor f = new vibor();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
