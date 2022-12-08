using b16.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            laporan2.Hide();
            stokBarang2.Hide();
            Profile.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            laporan2.Hide();
            stokBarang2.Hide();
            Profile.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            laporan2.Hide();
            stokBarang2.Hide();
            Profile.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            laporan2.Hide();
            Profile.Hide();
            stokBarang2.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Profile.Hide();
            stokBarang2.Hide();
            laporan2.Show();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
