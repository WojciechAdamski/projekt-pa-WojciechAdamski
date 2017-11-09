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
        string[] tablica_pytania = new string[4];
        Random r = new Random();




        private void button1_Click(object sender, EventArgs e) // Start
        {
            pkt = 0;
            textBox2.Text = pkt.ToString();

            tablica_pytania[0] = File.ReadLines(@"test.txt").Skip(1).Take(1).First();
            tablica_pytania[1] = File.ReadLines(@"test.txt").Skip(2).Take(1).First();
            tablica_pytania[2] = File.ReadLines(@"test.txt").Skip(3).Take(1).First();
            tablica_pytania[3] = File.ReadLines(@"test.txt").Skip(4).Take(1).First();

            textBox1.Text = tablica_pytania[r.Next(0, 4)];

        }

        private void button2_Click(object sender, EventArgs e) // tak
        {
            if (textBox1.Text == tablica_pytania[0])
            {
                pkt = pkt + 1;
                textBox1.Text = tablica_pytania[r.Next(0, 4)];
                textBox2.Text = pkt.ToString();
            }
            if (textBox1.Text == tablica_pytania[1])
            {
                pkt = pkt + 1;
                textBox1.Text = tablica_pytania[r.Next(0, 4)];
                textBox2.Text = pkt.ToString();
            }
            else
            {
                pkt = pkt - 1;
                textBox2.Text = pkt.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e) // nie
        {
            if (textBox1.Text == tablica_pytania[2])
            {
                pkt = pkt + 1;
                textBox1.Text = tablica_pytania[r.Next(0, 4)];
                textBox2.Text = pkt.ToString();
            }
            if (textBox1.Text == tablica_pytania[3])
            {
                pkt = pkt + 1;
                textBox1.Text = tablica_pytania[r.Next(0, 4)];
                textBox2.Text = pkt.ToString();
            }
            else
            {
                pkt = pkt - 1;
                textBox2.Text = pkt.ToString();
            }

        }
    }
}
