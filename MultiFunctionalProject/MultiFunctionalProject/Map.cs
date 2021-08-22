using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01Deneme
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }
        guessPos map = new guessPos();
        public static int index1,index2;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                map.guess_rightdown();
                label1.Text = index1 + "," + index2;
            }
            catch (Exception)
            {
                MessageBox.Show("İstediğiniz lokasyona dair yanlış girdiler yaptınız. Harita boyutu 1024 1024'tür.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                map.guess_down();
                label1.Text = index1 + "," + index2;
            }
            catch (Exception)
            {
                MessageBox.Show("İstediğiniz lokasyona dair yanlış girdiler yaptınız. Harita boyutu 1024 1024'tür.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                map.guess_leftdown();
                label1.Text = index1 + "," + index2;
            }
            catch (Exception)
            {
                MessageBox.Show("İstediğiniz lokasyona dair yanlış girdiler yaptınız. Harita boyutu 1024 1024'tür.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                map.guess_left();
                label1.Text = index1 + "," + index2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("İstediğiniz lokasyona dair yanlış girdiler yaptınız. Harita boyutu 1024 1024'tür.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                map.guess_leftup();
                label1.Text = index1 + "," + index2;
            }
            catch (Exception)
            {
                MessageBox.Show("İstediğiniz lokasyona dair yanlış girdiler yaptınız. Harita boyutu 1024 1024'tür.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                map.guess_up();
                label1.Text = index1 + "," + index2;
            }
            catch (Exception)
            {
                MessageBox.Show("İstediğiniz lokasyona dair yanlış girdiler yaptınız. Harita boyutu 1024 1024'tür.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                map.guess_rightup();
                label1.Text = index1 + "," + index2;
            }
            catch (Exception)
            {
                MessageBox.Show("İstediğiniz lokasyona dair yanlış girdiler yaptınız. Harita boyutu 1024 1024'tür.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Map_Load(object sender, EventArgs e)
        {
            try
            {
                map.guess_first();
                label1.Text = index1 + "," + index2;
            }
            catch (Exception)
            {
                MessageBox.Show("İstediğiniz lokasyona dair yanlış girdiler yaptınız. Harita boyutu 1024 1024'tür.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
                map.guess_first();
                label1.Text = index1 + "," + index2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                map.guess_right();
                label1.Text = index1 + "," + index2;
            }
            catch (Exception)
            {
                MessageBox.Show("İstediğiniz lokasyona dair yanlış girdiler yaptınız. Harita boyutu 1024 1024'tür.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
