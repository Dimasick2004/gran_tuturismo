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
    public partial class begin_menu : Form
    {
        public begin_menu()
        {
            InitializeComponent();
        }

        private void begin_menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            main_menu f = new main_menu();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
