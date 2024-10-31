using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skor_Tablosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte fb, gs;
            fb = Convert.ToByte(textBox1.Text);
            gs = Convert.ToByte(textBox2.Text);
            if (fb > gs)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/user/Desktop/10-M/Skor Tablosu/fb.jpg");
                MessageBox.Show("Fenerbahçe Kazandı");

            }
            if (gs > fb)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/user/Desktop/10-M/Skor Tablosu/gs.png");
                MessageBox.Show("Galatasaray Kazandı");
            }
            if (fb == gs)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/user/Desktop/10-M/Skor Tablosu/fbgs.jpg");
                MessageBox.Show("Maç Berabere");

            }

        }
    }
}
