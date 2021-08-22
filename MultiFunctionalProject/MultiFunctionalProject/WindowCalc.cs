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
    public partial class WindowCalc : Form
    {
        public WindowCalc()
        {
            InitializeComponent();
        }

        calculator calc = new calculator();
        
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gold;
            button2.BackColor = Color.DarkGray;
            button3.BackColor = Color.DarkGray;
            button4.BackColor = Color.DarkGray;
            double number1, number2 ,result;
            number1 = Convert.ToDouble(textBox1.Text);
            number2 = Convert.ToDouble(textBox2.Text);

            result = calc.addition(number1,number2);

            label5.Text = result.ToString();
            if (result > 0)
                label5.BackColor = Color.Green;
            else
                label5.BackColor = Color.Red;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gold;
            button1.BackColor = Color.DarkGray;
            button3.BackColor = Color.DarkGray;
            button4.BackColor = Color.DarkGray;
            double number1, number2, result;
            number1 = Convert.ToDouble(textBox1.Text);
            number2 = Convert.ToDouble(textBox2.Text);

            result = calc.subtraction(number1, number2);

            label5.Text = result.ToString();
            if (result > 0)
                label5.BackColor = Color.Green;
            else
                label5.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Gold;
            button2.BackColor = Color.DarkGray;
            button1.BackColor = Color.DarkGray;
            button4.BackColor = Color.DarkGray;
            double number1, number2, result;
            number1 = Convert.ToDouble(textBox1.Text);
            number2 = Convert.ToDouble(textBox2.Text);

            result = calc.multiplication(number1, number2);

            label5.Text = result.ToString();
            if (result > 0)
                label5.BackColor = Color.Green;
            else
                label5.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Gold;
            button2.BackColor = Color.DarkGray;
            button3.BackColor = Color.DarkGray;
            button1.BackColor = Color.DarkGray;
            double number1, number2, result=0.0;
            number1 = Convert.ToDouble(textBox1.Text);
            number2 = Convert.ToDouble(textBox2.Text);

            if (number2 == 0)
            {
                label5.Text = "UNDEFINED";
                label5.BackColor = Color.Transparent;
            }
            else
            {
                result = calc.division(number1, number2);
                label5.Text = result.ToString();
                if (result > 0)
                    label5.BackColor = Color.Green;
                else
                    label5.BackColor = Color.Red;
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Red;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Black;
        }
    }
}
