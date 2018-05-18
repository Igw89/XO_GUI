using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            listBox1.Items.Add(text[0]);


        }
        string[] text = new string[6] { "Для хода нажмите на кнопку", "Ход противника", "249, 207, 221", "Компьютер победил", "Вы победили", "Ничья" };
        int itog1 = 0;
        int itog2 = 0;
        int end = 1;








        private void sbros(object sender, EventArgs e)
        {
            button1.Text = "";
            button1.Enabled = false;
            button1.BackColor = Color.FromArgb(255, 255, 255);

            button2.Text = "";
            button2.Enabled = false;
            button2.BackColor = Color.FromArgb(255, 255, 255);

            button3.Text = "";
            button3.Enabled = false;
            button3.BackColor = Color.FromArgb(255, 255, 255);

            button4.Text = "";
            button4.Enabled = false;
            button4.BackColor = Color.FromArgb(255, 255, 255);

            button5.Text = "";
            button5.Enabled = false;
            button5.BackColor = Color.FromArgb(255, 255, 255);

            button6.Text = "";
            button6.Enabled = false;
            button6.BackColor = Color.FromArgb(255, 255, 255);

            button7.Text = "";
            button7.Enabled = false;
            button7.BackColor = Color.FromArgb(255, 255, 255);

            button8.Text = "";
            button8.Enabled = false;
            button8.BackColor = Color.FromArgb(255, 255, 255);

            button9.Text = "";
            button9.Enabled = false;
            button9.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void zanovo(object sender, EventArgs e)
        {
            
            button1.Text = ".";
            button1.Enabled = true;
            button1.BackColor = default(System.Drawing.Color);

            button2.Text = ".";
            button2.Enabled = true;
            button2.BackColor = default(System.Drawing.Color);

            button3.Text = ".";
            button3.Enabled = true;
            button3.BackColor = default(System.Drawing.Color);

            button4.Text = ".";
            button4.Enabled = true;
            button4.BackColor = default(System.Drawing.Color);

            button5.Text = ".";
            button5.Enabled = true;
            button5.BackColor = default(System.Drawing.Color);

            button6.Text = ".";
            button6.Enabled = true;
            button6.BackColor = default(System.Drawing.Color);

            button7.Text = ".";
            button7.Enabled = true;
            button7.BackColor = default(System.Drawing.Color);

            button8.Text = ".";
            button8.Enabled = true;
            button8.BackColor = default(System.Drawing.Color);

            button9.Text = ".";
            button9.Enabled = true;
            button9.BackColor = default(System.Drawing.Color);
        }








        private void result(object sender, EventArgs e)
        {
            button11.Enabled = false;
            button12.Enabled = false;
            listBox2.Items.Add(end);






            /// Положительный результат пользователя

            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                itog1 = itog1 + 1;
                sbros(sender, e);
                listBox1.Items.Add(text[4] + " " + itog1 + " раз");

            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                itog1 = itog1 + 1;
                sbros(sender, e);
                listBox1.Items.Add(text[4] + " " + itog1 + " раз");
            }

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                itog1 = itog1 + 1;
                sbros(sender, e);
                listBox1.Items.Add(text[4] + " " + itog1 + " раз");
            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                itog1 = itog1 + 1;
                sbros(sender, e);
                listBox1.Items.Add(text[4] + " " + itog1 + " раз");
            }

            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                itog1 = itog1 + 1;
                sbros(sender, e);
                listBox1.Items.Add(text[4] + " " + itog1 + " раз");
            }

            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                itog1 = itog1 + 1;
                sbros(sender, e);
                listBox1.Items.Add(text[4] + " " + itog1 + " раз");
            }

            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                itog1 = itog1 + 1;
                sbros(sender, e);
                listBox1.Items.Add(text[4] + " " + itog1 + " раз");
            }

            if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
            {
                itog1 = itog1 + 1;
                sbros(sender, e);
                listBox1.Items.Add(text[4] + " " + itog1 + " раз");
            }




            /// Положительный результат компьютера

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                itog2 = itog2 + 1;
                sbros(sender, e);
                listBox1.Items.Add(text[3] + " " + itog2 + " раз");
            }

            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                itog2 = itog2 + 1;
                sbros(sender, e);
                listBox1.Items.Add(text[3] + " " + itog2 + " раз");
            }

            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                itog2 = itog2 + 1;
                sbros(sender, e);
                listBox1.Items.Add(text[3] + " " + itog2 + " раз");
            }

            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                itog2 = itog2 + 1;
                sbros(sender, e);
                listBox1.Items.Add(text[3] + " " + itog2 + " раз");
            }

            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                itog2 = itog2 + 1;
                sbros(sender, e);
                listBox1.Items.Add(text[3] + " " + itog2 + " раз");
            }

            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                itog2 = itog2 + 1;
                sbros(sender, e);
                listBox1.Items.Add(text[3] + " " + itog2 + " раз");
            }

            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                itog2 = itog2 + 1;
                sbros(sender, e);
                listBox1.Items.Add(text[3] + " " + itog2 + " раз");
            }

            if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
            {
                itog2 = itog2 + 1;
                sbros(sender, e);
                listBox1.Items.Add(text[3] + " " + itog2 + " раз");
            }

            if (end % 3 == 0)
            {
                sbros(sender, e);
            }
            button11.Text = Convert.ToString(itog1);
            button12.Text = Convert.ToString(itog2);

        }










        private void hod1(object sender, EventArgs e)
        {
            while (true)
            {
                Random r1 = new Random();
                int ukalela = r1.Next(1, 10);
                if (ukalela == 1)
                {
                    if (button1.Text == ".")
                    {
                        button1.Text = "O";
                        button1.Enabled = false;
                        button1.BackColor = Color.FromArgb(249, 207, 221);
                        break;
                    }

                    if (button1.Text == "X")
                    {
                        continue;
                    }
                }


                if (ukalela == 2)
                {
                    if (button2.Text == ".")
                    {
                        button2.Text = "O";
                        button2.Enabled = false;
                        button2.BackColor = Color.FromArgb(249, 207, 221);
                        break;
                    }

                    if (button2.Text == "X")
                    {
                        continue;
                    }
                }


                if (ukalela == 3)
                {
                    if (button3.Text == ".")
                    {
                        button3.Text = "O";
                        button3.Enabled = false;
                        button3.BackColor = Color.FromArgb(249, 207, 221);
                        break;
                    }

                    if (button3.Text == "X")
                    {
                        continue;
                    }
                }


                if (ukalela == 4)
                {
                    if (button4.Text == ".")
                    {
                        button4.Text = "O";
                        button4.Enabled = false;
                        button4.BackColor = Color.FromArgb(249, 207, 221);
                        break;
                    }

                    if (button4.Text == "X")
                    {
                        continue;
                    }
                }


                if (ukalela == 5)
                {
                    if (button5.Text == ".")
                    {
                        button5.Text = "O";
                        button5.Enabled = false;
                        button5.BackColor = Color.FromArgb(249, 207, 221);
                        break;
                    }

                    if (button5.Text == "X")
                    {
                        continue;
                    }
                }


                if (ukalela == 6)
                {
                    if (button6.Text == ".")
                    {
                        button6.Text = "O";
                        button6.Enabled = false;
                        button6.BackColor = Color.FromArgb(249, 207, 221);
                        break;
                    }

                    if (button6.Text == "X")
                    {
                        continue;
                    }
                }


                if (ukalela == 7)
                {
                    if (button7.Text == ".")
                    {
                        button7.Text = "O";
                        button7.Enabled = false;
                        button7.BackColor = Color.FromArgb(249, 207, 221);
                        break;
                    }

                    if (button7.Text == "X")
                    {
                        continue;
                    }
                }


                if (ukalela == 8)
                {
                    if (button8.Text == ".")
                    {
                        button8.Text = "O";
                        button8.Enabled = false;
                        button8.BackColor = Color.FromArgb(249, 207, 221);
                        break;
                    }

                    if (button8.Text == "X")
                    {
                        continue;
                    }
                }


                if (ukalela == 9)
                {
                    if (button9.Text == ".")
                    {
                        button9.Text = "O";
                        button9.Enabled = false;
                        button9.BackColor = Color.FromArgb(249, 207, 221);
                        break;
                    }

                    if (button9.Text == "X")
                    {
                        continue;
                    }
                }













            }

        }






















        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(text[1]);
            button1.Text = "X";
            button1.Enabled = false;
            button1.BackColor = Color.FromArgb(198, 221, 197);
            hod1(sender, e);
            result(sender, e);
            end = end + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(text[1]);
            button2.Text = "X";
            button2.Enabled = false;
            button2.BackColor = Color.FromArgb(198, 221, 197);
            hod1(sender, e);
            result(sender, e);
            end = end + 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(text[1]);
            button3.Text = "X";
            button3.Enabled = false;
            button3.BackColor = Color.FromArgb(198, 221, 197);
            hod1(sender, e);
            result(sender, e);
            end = end + 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(text[1]);
            button4.Text = "X";
            button4.Enabled = false;
            button4.BackColor = Color.FromArgb(198, 221, 197);
            hod1(sender, e);
            result(sender, e);
            end = end + 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(text[1]);
            button5.Text = "X";
            button5.Enabled = false;
            button5.BackColor = Color.FromArgb(198, 221, 197);
            hod1(sender, e);
            result(sender, e);
            end = end + 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(text[1]);
            button6.Text = "X";
            button6.Enabled = false;
            button6.BackColor = Color.FromArgb(198, 221, 197);
            hod1(sender, e);
            result(sender, e);
            end = end + 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(text[1]);
            button7.Text = "X";
            button7.Enabled = false;
            button7.BackColor = Color.FromArgb(198, 221, 197);
            hod1(sender, e);
            result(sender, e);
            end = end + 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(text[1]);
            button8.Text = "X";
            button8.Enabled = false;
            button8.BackColor = Color.FromArgb(198, 221, 197);
            hod1(sender, e);
            result(sender, e);
            end = end + 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(text[1]);
            button9.Text = "X";
            button9.Enabled = false;
            button9.BackColor = Color.FromArgb(198, 221, 197);
            hod1(sender, e);
            result(sender, e);
            end = end + 1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            end = 1;
            zanovo(sender, e);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
        }
    }
}
