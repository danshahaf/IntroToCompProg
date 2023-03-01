using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Slot_Machine
{
    public partial class Form1 : Form
    {
        int a = 0;
        int b = 0;
        int c = 0;
        double currentPrice = 100;
        int bet = 0;
        double win = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int a = rand.Next(1, 4);
            int b = rand.Next(1, 4);
            int c = rand.Next(1, 4);
            int bet = int.Parse(textBox1.Text);
            if (bet < currentPrice)
            {
                MessageBox.Show("you do not have enough money for this bet");
            }
            else
            {



                if (a == 1)
                {
                    pictureBox1.Image = Properties.Resources.orange1;
                }
                else if (a == 2)
                {
                    pictureBox1.Image = Properties.Resources.grapes1;
                }
                else if (a == 3)
                {
                    pictureBox1.Image = Properties.Resources.Banana1;

                }
                // setting pictures in label 1 randomly

                if (b == 1)
                {
                    pictureBox2.Image = Properties.Resources.orange1;
                }
                else if (b == 2)
                {
                    pictureBox2.Image = Properties.Resources.grapes1;
                }
                else if (b == 3)
                {
                    pictureBox2.Image = Properties.Resources.Banana1;
                }
                // setting pictures in label 2 randomly


                if (c == 1)
                {
                    pictureBox3.Image = Properties.Resources.orange1;
                }
                else if (c == 2)
                {
                    pictureBox3.Image = Properties.Resources.grapes1;
                }
                else if (c == 3)
                {
                    pictureBox3.Image = Properties.Resources.Banana1;
                }
                // setting pictures in label 3 randomly


                currentPrice -= bet;
                label3.Text = "$" + currentPrice.ToString("n2");
                System.Threading.Thread.Sleep(1000);
                // setting winning conditions and rewards

                if (a == b || a == c || b == c)
                {
                    MessageBox.Show("2 pictures are matching, you gained your bet - money doubles");
                    win = 2 * bet;
                    currentPrice += win;
                }
                else if (a == b && b == c)
                {
                    MessageBox.Show("You won the big price!! You gained your bet times 3");
                    win = 3 * bet;
                    currentPrice += win;
                }
                else //if (a != b || a!= c || b != c)
                {
                    MessageBox.Show("You won nothing");
                    textBox1.Text = "";
                }




                label3.Text = "$" + currentPrice.ToString("n2");

                ///if the money is over, the player will have to press to reset button
                if (currentPrice == 0)
                {
                    MessageBox.Show("GAME IS OVER!!! YOU RAN OUT OF MONEY");
                    textBox1.Text = "";
                    textBox1.Enabled = false;
                    button1.Enabled = false;

                }

            }





            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentPrice = 100;
            label3.Text = "$100";
            pictureBox1.Image = Properties.Resources.orange1;
            pictureBox2.Image = Properties.Resources.orange1;
            pictureBox3.Image = Properties.Resources.orange1;
            textBox1.Text = "";
            textBox1.Enabled = true;
            button1.Enabled = true;
            bet = 0;
            win = 0;




        }
    }
}
