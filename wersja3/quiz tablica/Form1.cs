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
        int z;

        Random r = new Random();

        void zerowanie ()       
        {
                x = 100;
                z = 100;
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

            x = r.Next(1, 16);
            z = x * 5;

            pytania = File.ReadLines(@"pytania.txt").Skip(z).Take(1).First();
            a = File.ReadLines(@"pytania.txt").Skip(z + 1).Take(1).First();
            b = File.ReadLines(@"pytania.txt").Skip(z + 2).Take(1).First();
            c = File.ReadLines(@"pytania.txt").Skip(z + 3).Take(1).First();
            d = File.ReadLines(@"pytania.txt").Skip(z + 4).Take(1).First();

            textBox1.Text = pytania;
            button4.Text = a;
            button5.Text = b;
            button2.Text = c;
            button3.Text = d;
        }






        private void button4_Click(object sender, EventArgs e)   //A
        {
            if (z <= 20)
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
            if (z > 20 & x <= 40)
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
            if (z > 40 & x <= 60)
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
            if (z > 60 & x <= 80)
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
