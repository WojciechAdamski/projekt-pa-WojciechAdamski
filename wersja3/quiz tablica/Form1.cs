using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace quiz_tablica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int pkt;
        public string pytania;
        public string a;
        public string b;
        public string c;
        public string d;
        int x;

        Random r = new Random();

        void zerowanie ()       
        {
                x = 100;
                textBox1.Text = "Wylosuj pytanie";
                button4.Text = "A";
                button5.Text = "B";
                button2.Text = "C";
                button3.Text = "D";
                pkt = 0;
                textBox2.Text = pkt.ToString();
         }


        private void button1_Click(object sender, EventArgs e)  // LOSOWANIE PYTANIA
        {
            textBox2.Text = pkt.ToString();

            x = r.Next(0, 15);

            pytania = File.ReadLines(@"pytania.txt").Skip(x).Take(1).First();
            a = File.ReadLines(@"a.txt").Skip(x).Take(1).First();
            b = File.ReadLines(@"b.txt").Skip(x).Take(1).First();
            c = File.ReadLines(@"c.txt").Skip(x).Take(1).First();
            d = File.ReadLines(@"d.txt").Skip(x).Take(1).First();

            textBox1.Text = pytania;
            button4.Text = a;
            button5.Text = b;
            button2.Text = c;
            button3.Text = d;
        }






        private void button4_Click(object sender, EventArgs e)   //A
        {
            if (x < 4)
            {
                pkt = pkt + 1;
                button1.PerformClick();
            }
            else
            {
                pkt = 0;
                MessageBox.Show("PRZEGRANA");
                zerowanie();
            }
        }





        private void button5_Click(object sender, EventArgs e)  //B
        {
            if (x >= 4 & x < 8)
            {
                pkt = pkt + 1;
                button1.PerformClick();
            }
            else
            {
                pkt = 0;
                MessageBox.Show("PRZEGRANA");
                zerowanie();
            }
        }





        private void button2_Click(object sender, EventArgs e)  // C
        {
            if (x >= 8 & x < 12)
            {
                pkt = pkt + 1;
                button1.PerformClick();
            }
            else
            {
                pkt = 0;
                MessageBox.Show("PRZEGRANA");
                zerowanie();
            }
        }





        private void button3_Click(object sender, EventArgs e) // D
        {
            if (x >= 12 & x < 16)
            {
                pkt = pkt + 1;
                button1.PerformClick();
            }
            else
            {
                pkt = 0;
                MessageBox.Show("PRZEGRANA");
                zerowanie();
            }
        }
    }
}
