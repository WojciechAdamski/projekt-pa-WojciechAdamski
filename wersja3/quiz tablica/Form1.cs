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
        int time = 6;
        int time1 = 50;
        int[] tablica_pytania = new int[25];
        Random r = new Random();
        int i = 1;



        void zerowanie()
        {
            pkt = 0;
            textBox1.Text = "Wylosuj pytanie";
            button4.Text = "A";
            button5.Text = "B";
            button2.Text = "C";
            button3.Text = "D";
            time = 6;
            textBox2.Text = pkt.ToString();
        }


        void losowanie()
        {
            while (tablica_pytania.Contains(x))

            {
                x = r.Next(1, 20);
            }


            tablica_pytania[i] = x;
            i++;


            if (i == 20)
            {
                timer1.Stop();
                timer2.Stop();
                Array.Clear(tablica_pytania, 0, tablica_pytania.Length);
                if (pkt > 9) { File.AppendAllText(@"wyniki.txt", pkt + "pkt.    " + "    Zostalo czasu : " + time1 + "s.       " + textBox4.Text + Environment.NewLine); }
                MessageBox.Show("Brawo. Udzielono odpowiedzi na wszystkie pytania!  Wynik:  " + pkt + " pkt");
                zerowanie();
                button();
                i = 1;
            }

            else
            {
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
                textBox2.Text = pkt.ToString();
            }
        }


        void button ()
        {
            button7.Enabled = true; //START
            button4.Enabled = false; //A
            button5.Enabled = false; //B
            button2.Enabled = false; //C
            button3.Enabled = false; //D
            textBox4.Enabled = true;
        }


        void timer()
        {
            timer1.Stop();
            timer2.Stop();
            if (pkt > 9) { File.AppendAllText(@"wyniki.txt", pkt + "pkt.    " + "    Zostalo czasu : " + time1 + "s.       " + textBox4.Text + Environment.NewLine); }
            MessageBox.Show("Koniec czasu!  Wynik:  " + pkt + " pkt");
            zerowanie();
            button();
            i = 1;
        }


        void zla_odp()
        {
            timer1.Stop();
            timer2.Stop();
            if (pkt > 9) { File.AppendAllText(@"wyniki.txt", pkt + "pkt.    " + "    Zostalo czasu : " + time1 + "s.       " + textBox4.Text + Environment.NewLine); }
            MessageBox.Show("Zla odpowiedz.  Wynik:  " + pkt + " pkt");
            zerowanie();
            button();
            i = 1;
        }


        private void button7_Click(object sender, EventArgs e) // START
        {
            time = 6;
            time1 = 50;
            pkt = 0;
            timer2.Start();
            losowanie();
            button7.Enabled = false; //START
            button4.Enabled = true; //A
            button5.Enabled = true; //B
            button2.Enabled = true; //C
            button3.Enabled = true; //D
            textBox4.Enabled = false;
        }


        private void button4_Click(object sender, EventArgs e)   //A
        {
            if (z <= 20)
            {
                time = 6;
                pkt = pkt + 1;
                losowanie();
            }
            else
            {
                zla_odp();
            }
        }


        private void button5_Click(object sender, EventArgs e)  //B
        {
            if (z > 20 & z <= 40)
            {
                time = 6;
                pkt = pkt + 1;
                losowanie();
            }
            else
            {
                zla_odp();
            }
        }


        private void button2_Click(object sender, EventArgs e)  // C
        {
            if (z > 40 & z <= 60)
            {
                time = 6;
                pkt = pkt + 1;
                losowanie();
            }
            else
            {
                zla_odp();
            }
        }


        private void button3_Click(object sender, EventArgs e) // D
        {
            if (z > 60 & z <= 100)
            {
                time = 6;
                pkt = pkt + 1;
                losowanie();
            }
            else
            {
                zla_odp();
            }
        }


        private void button6_Click(object sender, EventArgs e) // Tablica wynikow
        {
            string[] readText = File.ReadAllLines(@"wyniki.txt");
            Array.Sort(readText);
            Array.Reverse(readText);
            MessageBox.Show("1 miejsce:   " + readText[0] + Environment.NewLine + "2 miejsce:   " + readText[1] + Environment.NewLine + "3 miejsce:   " + readText[2] + Environment.NewLine + "4 miejsce:   " + readText[3] + Environment.NewLine + "5 miejsce:   " + readText[4]);
        }


        private void button1_Click(object sender, EventArgs e)  // Czyszczenie tablicy
        {
            if (MessageBox.Show("Czy jestes pewien?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Wyniki zostaly skasowane");
                File.WriteAllText(@"wyniki.txt", " " + Environment.NewLine + " " + Environment.NewLine + " " + Environment.NewLine + " " + Environment.NewLine + " " + Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Wyniki nie zostaly skasowane");
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            textBox3.Text = time.ToString();
            if (time == 0)
            {
                timer();
            }
        }
             

        private void timer2_Tick(object sender, EventArgs e)
        {
            time1--;
            textBox5.Text = time1.ToString();
            if (time1 == 0)
            {
                timer();
            }
        }
    }
}

