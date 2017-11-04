using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Quiz_dobry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        



        int pkt = 0;


        string pytanie1=File.ReadLines(@"test.txt").Skip(1).Take(1).First();
        string odp_a1 = File.ReadLines(@"test.txt").Skip(2).Take(1).First();
        string odp_b1 = File.ReadLines(@"test.txt").Skip(3).Take(1).First();
        string odp_c1 = File.ReadLines(@"test.txt").Skip(4).Take(1).First();
        string odp_d1 = File.ReadLines(@"test.txt").Skip(5).Take(1).First();

        string pytanie2=File.ReadLines(@"test.txt").Skip(10).Take(1).First();
        string odp_a2 = File.ReadLines(@"test.txt").Skip(11).Take(1).First();
        string odp_b2 = File.ReadLines(@"test.txt").Skip(12).Take(1).First();
        string odp_c2 = File.ReadLines(@"test.txt").Skip(13).Take(1).First();
        string odp_d2 = File.ReadLines(@"test.txt").Skip(14).Take(1).First();

        string pytanie3=File.ReadLines(@"test.txt").Skip(20).Take(1).First();
        string odp_a3 = File.ReadLines(@"test.txt").Skip(21).Take(1).First();
        string odp_b3 = File.ReadLines(@"test.txt").Skip(22).Take(1).First();
        string odp_c3 = File.ReadLines(@"test.txt").Skip(23).Take(1).First();
        string odp_d3 = File.ReadLines(@"test.txt").Skip(24).Take(1).First();

        string pytanie4=File.ReadLines(@"test.txt").Skip(30).Take(1).First();
        string odp_a4 = File.ReadLines(@"test.txt").Skip(31).Take(1).First();
        string odp_b4 = File.ReadLines(@"test.txt").Skip(32).Take(1).First();
        string odp_c4 = File.ReadLines(@"test.txt").Skip(33).Take(1).First();
        string odp_d4 = File.ReadLines(@"test.txt").Skip(34).Take(1).First();

        string pytanie5=File.ReadLines(@"test.txt").Skip(40).Take(1).First();
        string odp_a5 = File.ReadLines(@"test.txt").Skip(41).Take(1).First();
        string odp_b5 = File.ReadLines(@"test.txt").Skip(42).Take(1).First();
        string odp_c5 = File.ReadLines(@"test.txt").Skip(43).Take(1).First();
        string odp_d5 = File.ReadLines(@"test.txt").Skip(44).Take(1).First();

        string pytanie6=File.ReadLines(@"test.txt").Skip(50).Take(1).First();
        string odp_a6 = File.ReadLines(@"test.txt").Skip(51).Take(1).First();
        string odp_b6 = File.ReadLines(@"test.txt").Skip(52).Take(1).First();
        string odp_c6 = File.ReadLines(@"test.txt").Skip(53).Take(1).First();
        string odp_d6 = File.ReadLines(@"test.txt").Skip(54).Take(1).First();

        string pytanie7=File.ReadLines(@"test.txt").Skip(60).Take(1).First();
        string odp_a7 = File.ReadLines(@"test.txt").Skip(61).Take(1).First();
        string odp_b7 = File.ReadLines(@"test.txt").Skip(62).Take(1).First();
        string odp_c7 = File.ReadLines(@"test.txt").Skip(63).Take(1).First();
        string odp_d7 = File.ReadLines(@"test.txt").Skip(64).Take(1).First();





        private void Form1_Load(object sender, EventArgs e)
        {

        }
        





        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == pytanie3)
            {
                textBox1.Text = "PRZEGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
            }
            if (textBox1.Text == pytanie5)
            {
                textBox1.Text = "PRZEGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
            }
            if (textBox1.Text == pytanie7)
            {
                textBox1.Text = "PRZEGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
            }
            if (textBox1.Text == pytanie2)
            {
                pkt = pkt + 1;
                textBox1.Text = pytanie3;
                button1.Text = odp_a3;
                button2.Text = odp_b3;
                button3.Text = odp_c3;
                button4.Text = odp_d3;
                textBox2.Text = pkt.ToString();
            }

            if (textBox1.Text == pytanie4)
            {
                pkt = pkt + 1;
                textBox1.Text = pytanie5;
                button1.Text = odp_a5;
                button2.Text = odp_b5;
                button3.Text = odp_c5;
                button4.Text = odp_d5;
                textBox2.Text = pkt.ToString();
            }

            if (textBox1.Text == pytanie6)
            {
                pkt = pkt + 1;
                textBox1.Text = pytanie7;
                button1.Text = odp_a7;
                button2.Text = odp_b7;
                button3.Text = odp_c7;
                button4.Text = odp_d7;
                textBox2.Text = pkt.ToString();
            }

            if (textBox1.Text == pytanie1)
            {
                textBox1.Text = "PRZEGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
            }

        }









        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == pytanie6)
            {
                textBox1.Text = "PRZEGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
            }
            if (textBox1.Text == pytanie5)
            {
                pkt = pkt + 1;
                textBox1.Text = pytanie6;
                button1.Text = odp_a6;
                button2.Text = odp_b6;
                button3.Text = odp_c6;
                button4.Text = odp_d6;
                textBox2.Text = "5";
            }

            if (textBox1.Text == pytanie7)
            {
                pkt = pkt + 1;
                textBox1.Text = "WYGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
                textBox2.Text = pkt.ToString();
            }
            if (textBox1.Text == pytanie1)
            {
                textBox1.Text = "PRZEGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
            }
            if (textBox1.Text == pytanie2)
            {
                textBox1.Text = "PRZEGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
            }
            if (textBox1.Text == pytanie3)
            {
                textBox1.Text = "PRZEGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
            }
            if (textBox1.Text == pytanie4)
            {
                textBox1.Text = "PRZEGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
            }

        }









        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == pytanie4)
            {
                textBox1.Text = "PRZEGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
            }
            if (textBox1.Text == pytanie3)
            {
                pkt = pkt + 1;
                textBox1.Text = pytanie4;
                button1.Text = odp_a4;
                button2.Text = odp_b4;
                button3.Text = odp_c4;
                button4.Text = odp_d4;
                textBox2.Text = pkt.ToString();
            }
            if (textBox1.Text == pytanie1)
            {
                textBox1.Text = "PRZEGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
            }
            if (textBox1.Text == pytanie2)
            {
                textBox1.Text = "PRZEGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
            }
            if (textBox1.Text == pytanie5)
            {
                textBox1.Text = "PRZEGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
            }
            if (textBox1.Text == pytanie6)
            {
                textBox1.Text = "PRZEGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
            }
            if (textBox1.Text == pytanie7)
            {
                textBox1.Text = "PRZEGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
            }

        }











        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == pytanie2)
            {
                textBox1.Text = "PRZEGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
            }

            if (textBox1.Text == pytanie1)
            {
                pkt = pkt + 1;
                textBox1.Text = pytanie2;
                button1.Text = odp_a2;
                button2.Text = odp_b2;
                button3.Text = odp_c2;
                button4.Text = odp_d2;
                textBox2.Text = pkt.ToString();
            }

            if (textBox1.Text == pytanie3)
            {
                textBox1.Text = "PRZEGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
            }
            if (textBox1.Text == pytanie4)
            {
                textBox1.Text = "PRZEGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
            }
            if (textBox1.Text == pytanie5)
            {
                textBox1.Text = "PRZEGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
            }
            if (textBox1.Text == pytanie6)
            {
                textBox1.Text = "PRZEGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
            }
            if (textBox1.Text == pytanie7)
            {
                textBox1.Text = "PRZEGRANA!";
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
            }

        }










        private void button5_Click(object sender, EventArgs e)
        {
            pkt = 0;
            textBox1.Text = pytanie1;
            button1.Text = odp_a1;
            button2.Text = odp_b1;
            button3.Text = odp_c1;
            button4.Text = odp_d1;
            textBox2.Text = pkt.ToString();
        }



    }
}
