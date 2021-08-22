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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static user[] users = user.instance_();
        int counter = 0;
        
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label4.Text = "LOGIN";
            textBox3.Visible = false;
            label3.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label4.Text = "SIGNUP";
            textBox3.Visible = true;
            label3.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label5.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label4.Text == "SIGNUP" && textBox2.Text == textBox3.Text)
            {
                users[counter].username = textBox1.Text;
                users[counter].password = Encryptor.MD5Hash(textBox2.Text);
                counter++;
                label5.Text = "SIGNUP SUCCESSFUL";
                label5.ForeColor = System.Drawing.Color.Green;
                
            }
            else
            {
                label5.Text = "SIGNUP FAILED";
                label5.ForeColor = System.Drawing.Color.Red;
             
            }
            if (label4.Text == "LOGIN")
            {
                int cou = 0;
                for(int i = 0; i <10; i++)
                {
                    if (users[i].username==textBox1.Text && users[i].password == Encryptor.MD5Hash(textBox2.Text))
                    {
                        label5.Text = "LOGIN SUCCESSFUL";
                        label5.ForeColor = System.Drawing.Color.Green;
                        Refresh();
                        cou++;
                        break;
                    }
                }
                if (cou != 0)
                {
                    System.Threading.Thread.Sleep(3000);
                    Araform araform = new Araform();
                    araform.Show();
                    this.Hide();
                }
                if (cou == 0)
                {
                    label5.Text = "LOGIN FAILED";
                    label5.ForeColor = System.Drawing.Color.Red;
               
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }


}
