using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace match_game_project
{
    public partial class Form1 : Form
    {
        bool yellow = false;
        bool blue = false;
        bool green = false;
        bool pink = false;
        bool purple = false;
        bool red = false;
        bool brown = false;
        bool white = false;
        bool gray = false;
        bool orange = false;
        bool correct = false;
        int counter = 0;
        String[] colors = { "blue", "yellow", "gray", "green", "red", "pink", "purple", "brown", "white", "orange" };
        int randomColor;
        String temp;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            
            label1.Text = counter.ToString();
            if (correct)
            {
                score++;
                label5.Text = score.ToString();
                
                correct = false;
            }
            label2.Text = temp;


            
            if(score == 10)
            {
                timer1.Stop();
                MessageBox.Show("YOU WON");
                
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox1.Image = Properties.Resources.black;
            pictureBox2.Image = Properties.Resources.black;
            pictureBox3.Image = Properties.Resources.black;
            pictureBox4.Image = Properties.Resources.black;
            pictureBox5.Image = Properties.Resources.black;
            pictureBox6.Image = Properties.Resources.black;
            pictureBox7.Image = Properties.Resources.black;
            pictureBox8.Image = Properties.Resources.black;
            pictureBox9.Image = Properties.Resources.black;
            pictureBox10.Image = Properties.Resources.black;
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = colors.Length - 1; i >=0; i--)
            {
                randomColor = rand.Next(i);
                temp = colors[i];
                colors[i] = colors[randomColor];
                colors[randomColor] = temp;
            }
            if (temp == "yellow")
                yellow = true;
            if (temp == "orange")
                orange = true;
            if (temp == "red")
                red = true;
            if (temp == "white")
                white = true;
            if (temp == "pink")
                pink = true;
            if (temp == "purple")
                purple = true;
            if (temp == "blue")
                blue = true;
            if (temp == "green")
                green = true;
            if (temp == "brown")
                brown = true;
            if (temp == "gray")
                gray = true;
            





            
            if (correct)
            {
                score++;
                label5.Text = score.ToString();
                correct = false;
            }





        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.yellow;
            if (yellow)
            {
                correct = true;
                
            }
            else
                pictureBox1.Image = Properties.Resources.black;


        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.orange1;
            if (orange)
                correct = true;
            else
                pictureBox2.Image = Properties.Resources.black;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Properties.Resources.red1;
            if (red)
                correct = true;
            else
                pictureBox3.Image = Properties.Resources.black;
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox4.Image = Properties.Resources.white;
            if (white)
                correct = true;
            else
                pictureBox4.Image = Properties.Resources.black;
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox5.Image = Properties.Resources.pink1;
            if (pink)
                correct = true;
            else
                pictureBox5.Image = Properties.Resources.black;
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox6.Image = Properties.Resources.purple1;
            if (purple)
                correct = true;
            else
                pictureBox6.Image = Properties.Resources.black;
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox7.Image = Properties.Resources.blue1;
            if (blue)
                correct = true;
            else
                pictureBox7.Image = Properties.Resources.black;
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox8.Image = Properties.Resources.green1;
            if (green)
                correct = true;
            else
                pictureBox8.Image = Properties.Resources.black;

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.brown1;
            if (brown)
                correct = true;
            else
                pictureBox9.Image = Properties.Resources.black;
        }

        private void pictureBox10_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox10.Image = Properties.Resources.gray1;
            if (gray)
                correct = true;
            else
                pictureBox10.Image = Properties.Resources.black;
        }
    }
}
