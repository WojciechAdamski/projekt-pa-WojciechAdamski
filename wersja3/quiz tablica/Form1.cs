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
        int z = 100;
        int time = 6;
        int time1 = 0;


        Random r = new Random();

        void zerowanie()
        {
            x = 100;
            z = 100;
            textBox1.Text = "Wylosuj pytanie";
            button4.Text = "A";
            button5.Text = "B";
            button2.Text = "C";
            button3.Text = "D";
            pkt = 0;
            time = 6;
            textBox2.Text = pkt.ToString();
            timer2.Stop();
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

            timer1.Start();



        }






        private void button4_Click(object sender, EventArgs e)   //A
        {
            if (z <= 20)
            {
                time = 6;
                pkt = pkt + 1;
                button1.Enabled = true;
                button1.PerformClick();
                button1.Enabled = false;
            }
            else
            {
                timer1.Stop();
                File.AppendAllText(@"wyniki.txt", textBox4.Text + ":  " + pkt + " pkt w czasie: " + time1 + Environment.NewLine);
                MessageBox.Show("Zla odpowiedz.  Wynik:  " + pkt + " pkt");
                zerowanie();
            }
        }





        private void button5_Click(object sender, EventArgs e)  //B
        {
            if (z > 20 & z <= 40)
            {
                time = 6;
                pkt = pkt + 1;
                button1.Enabled = true;
                button1.PerformClick();
                button1.Enabled = false;
            }
            else
            {
                timer1.Stop();
                File.AppendAllText(@"wyniki.txt", textBox4.Text + ":  " + pkt + " pkt w czasie: " + time1 + Environment.NewLine);
                MessageBox.Show("Zla odpowiedz.  Wynik:  " + pkt + " pkt");
                zerowanie();
            }
        }





        private void button2_Click(object sender, EventArgs e)  // C
        {
            if (z > 40 & z <= 60)
            {
                time = 6;
                pkt = pkt + 1;
                button1.Enabled = true;
                button1.PerformClick();
                button1.Enabled = false;
            }
            else
            {
                timer1.Stop();
                File.AppendAllText(@"wyniki.txt", textBox4.Text + ":  " + pkt + " pkt w czasie: " + time1 + Environment.NewLine);
                MessageBox.Show("Zla odpowiedz.  Wynik:  " + pkt + " pkt");
                zerowanie();
            }
        }





        private void button3_Click(object sender, EventArgs e) // D
        {
            if (z > 60 & z <= 80)
            {
                time = 6;
                pkt = pkt + 1;
                button1.Enabled = true;
                button1.PerformClick();
                button1.Enabled = false;
            }
            else
            {
                timer1.Stop();
                File.AppendAllText(@"wyniki.txt", textBox4.Text + ":  " + pkt + " pkt w czasie: " + time1 + Environment.NewLine);
                MessageBox.Show("Zla odpowiedz.  Wynik:  " + pkt + " pkt");
                zerowanie();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            textBox3.Text = time.ToString();
            if (time == 0)
            {
                timer1.Stop();
                File.AppendAllText(@"wyniki.txt", textBox4.Text + ":  " + pkt + " pkt w czasie: " + time1 + Environment.NewLine);
                MessageBox.Show("Koniec czasu!  Wynik:  " + pkt + " pkt");
                zerowanie();
            }
        }

        private void button6_Click(object sender, EventArgs e) // Tablica wynikow
        {
            MessageBox.Show("Tablica wynikow." + Environment.NewLine + File.ReadAllText(@"wyniki.txt"));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time1++;
            textBox5.Text = time1.ToString();
        }

        private void button7_Click(object sender, EventArgs e) // START
        {
            time = 6;
            time1 = 0;
            pkt = 0;
            timer2.Start();
            button1.Enabled = true;
            button1.PerformClick();
            button1.Enabled = false;
        }
    }
}

