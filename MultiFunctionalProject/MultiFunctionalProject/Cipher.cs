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
    public partial class Cipher : Form
    {
        public Cipher()
        {
            InitializeComponent();
        }
        private void Cipher_Load(object sender, EventArgs e)
        {
            textBox1.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox2.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            groupBox1.Show();
            int len = textBox1.Text.Length;
            letter[] alphabet_ = new letter[len];

            for (int i = 0; i < len; i++)
            {
                alphabet_[i] = new letter();
                alphabet_[i].letter_ = char.ToUpper(textBox1.Text[i]);
                alphabet_[i].index = i;
            }


            int len2 = textBox2.Text.Length;
            bool flag;
            for (int i = 0; i < len2; i++)
            {
                flag = false;
                for (int j = 0; j < len; j++)
                {
                    if (char.ToUpper(textBox2.Text[i]) == alphabet_[j].letter_)
                        flag = true;
                }
                if (flag == false)
                {
                    MessageBox.Show("Some char in the string is not convinced to alphabet!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            if (textBox1.Text != "" && textBox3.Text != "")
                textBox3_TextChanged(sender, e);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Rot Value:";
            label3.Show();
            textBox3.Show();
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Key Value:";
            label3.Show();
            textBox3.Show();
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Encrypted";
           
            textBox4.Text = "";

            if (textBox2.Text != "" && textBox3.Text != "" && textBox1.Text!="")
                textBox3_TextChanged(sender, e);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Decrypted";
           
            textBox4.Text = "";
            if (textBox2.Text != "" && textBox3.Text != "" && textBox1.Text != "")
                textBox3_TextChanged(sender, e);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label4.Show();
            textBox4.Show();
            textBox4.Text = "";
            int u=0;

            if (radioButton3.Checked)
            {

                int len = textBox1.Text.Length;
                letter[] alphabet_ = new letter[len];

                    for (int i = 0; i < len; i++)
                    {
                        alphabet_[i] = new letter();
                        alphabet_[i].letter_ = char.ToUpper(textBox1.Text[i]);
                        alphabet_[i].index = i;
                    }
                

                int len2 = textBox2.Text.Length;
                bool flag;
                for (int i = 0; i < len2; i++)
                {
                    flag = false;
                    for (int j = 0; j < len; j++)
                    {
                        if (char.ToUpper(textBox2.Text[i]) == alphabet_[j].letter_)
                            flag = true;
                    }
                    if (flag == false && textBox3.Text!="")
                    {
                        MessageBox.Show("Some char in the string is not convinced to alphabet!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }

                letter[] str_ = new letter[len2];
                for (int i = 0; i < len2; i++)
                {
                    str_[i] = new letter();
                    str_[i].letter_ = char.ToUpper(textBox2.Text[i]);
                }

                for (int i = 0; i < len2; i++)
                {
                    for (int k = 0; k < len; k++)
                    {
                        if (str_[i].letter_ == alphabet_[k].letter_)
                        {
                            str_[i].index = k;
                            str_[i].letter_ = alphabet_[k].letter_;
                        }
                    }

                }

                int len3 = textBox3.Text.Length;

                for (int i = 0; i < len3; i++)
                {
                    flag = false;
                    for (int j = 0; j < len; j++)
                    {
                        if (char.ToUpper(textBox3.Text[i]) == alphabet_[j].letter_)
                            flag = true;
                    }
                    if (flag == false && textBox3.Text != "")
                    {
                        MessageBox.Show("Some char in the key is not convinced to alphabet!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }

                letter[] key_ = new letter[len3];
                for (int i = 0; i < len3; i++)
                {
                    key_[i] = new letter();
                    key_[i].letter_ = char.ToUpper(textBox3.Text[i]);
                }

                for (int i = 0; i < len3; i++)
                {
                    for (int k = 0; k < len; k++)
                    {
                        if (key_[i].letter_ == alphabet_[k].letter_)
                        {
                            key_[i].index = k;
                            key_[i].letter_ = alphabet_[k].letter_;
                        }
                    }

                }
                if (textBox3.Text != "" && textBox3.Text.All(c => Char.IsLetter(c))) { 
                    if (radioButton1.Checked)
                {
                    char[] encryptedstr = new char[len2];
                    int t = 0;
                    for (int i = 0; i < len2; i++)
                    {
                        encryptedstr[t] = alphabet_[((str_[i].index + key_[i % len3].index)+1) % len].letter_;
                        t++;
                    }


                    for (int i = 0; i < len2; i++)
                        textBox4.Text += encryptedstr[i];
                }
                    if (radioButton2.Checked)
                    {
                        char[] decryptedstr = new char[len2];
                        int z = 0;
                        for (int i = 0; i < len2; i++)
                        {
                            if (key_[i % len3].index+1 > str_[i].index)
                            {
                                decryptedstr[z] = alphabet_[(str_[i].index - key_[i % len3].index)-1 + len].letter_;
                                z++;
                            }
                            else
                            {
                                decryptedstr[z] = alphabet_[(str_[i].index - key_[i % len3].index)-1].letter_;
                                z++;
                            }
                        }

                        for (int i = 0; i < len2; i++)
                            textBox4.Text += decryptedstr[i];
                    }
                }
            }


            if (radioButton4.Checked)
            {
                int lenn = textBox1.Text.Length;
                letter[] alphabet2_ = new letter[lenn];

                    for (int i = 0; i < lenn; i++)
                    {
                        alphabet2_[i] = new letter();
                        alphabet2_[i].letter_ = char.ToUpper(textBox1.Text[i]);
                        alphabet2_[i].index = i;
                    }
              

                int lenn2 = textBox2.Text.Length;
                bool flag2;
                for (int i = 0; i < lenn2; i++)
                {
                    flag2 = false;
                    for (int j = 0; j < lenn; j++)
                    {
                        if (char.ToUpper(textBox2.Text[i]) == alphabet2_[j].letter_)
                            flag2 = true;
                    }
                    if (flag2 == false && textBox3.Text != "")
                    {
                        MessageBox.Show("Some char in the string is not convinced to alphabet!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }

                letter[] str2_ = new letter[lenn2];
                for (int i = 0; i < lenn2; i++)
                {
                    str2_[i] = new letter();
                    str2_[i].letter_ = char.ToUpper(textBox2.Text[i]);
                }

                for (int i = 0; i < lenn2; i++)
                {
                    for (int k = 0; k < lenn; k++)
                    {
                        if (str2_[i].letter_ == alphabet2_[k].letter_)
                        {
                            str2_[i].index = k;
                            str2_[i].letter_ = alphabet2_[k].letter_;
                        }
                    }

                }

                int lenn3 = textBox3.Text.Length;
                bool flagg;
                for (int i = 0; i < lenn3; i++)
                {
                    flagg = false;
                    for (int j = 0; j < lenn; j++)
                    {
                        if (int.TryParse(textBox3.Text, out u))
                            flagg = true;
                    }
                    if (flagg == false && textBox3.Text != "")
                    {
                        MessageBox.Show("Some char in the Rot value is not integer!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }

                if (textBox3.Text != "" && int.TryParse(textBox3.Text,out u)) { 
                    int rotvalue_ = Convert.ToInt32(textBox3.Text);

                if (radioButton1.Checked)
                {
                    char[] encryptedstr2 = new char[lenn2];
                    int y = 0;

                    for (int i = 0; i < lenn2; i++)
                    {
                        encryptedstr2[y] = alphabet2_[(str2_[i].index + rotvalue_) % lenn].letter_;
                        y++;
                    }

                    for (int i = 0; i < lenn2; i++)
                        textBox4.Text += encryptedstr2[i];
                }

                    if (radioButton2.Checked)
                    {
                        char[] decryptedstr2 = new char[lenn2];
                        int x = 0;
                        for (int i = 0; i < lenn2; i++)
                        {
                            if (rotvalue_ > str2_[i].index)
                            {
                                decryptedstr2[x] = alphabet2_[(str2_[i].index - rotvalue_ % lenn) + lenn].letter_;
                                x++;
                            }
                            else
                            {
                                decryptedstr2[x] = alphabet2_[str2_[i].index - rotvalue_].letter_;
                                x++;
                            }
                        }

                        for (int i = 0; i < lenn2; i++)
                            textBox4.Text += decryptedstr2[i];
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.All(c => Char.IsLetter(c)))
            {
            }
            else
                MessageBox.Show("Some char in the alphabet is not letter!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if(textBox2.Text!="" && textBox3.Text!="")
            textBox3_TextChanged(sender, e);
        }
    }
}
