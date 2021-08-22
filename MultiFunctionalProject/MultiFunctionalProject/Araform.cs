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
    public partial class Araform : Form
    {
        public Araform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            WindowCalc calc = new WindowCalc();
            calc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            Cipher cipher = new Cipher();
            cipher.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            Map map = new Map();
            map.Show();
            this.Hide();
        }
    }
}
