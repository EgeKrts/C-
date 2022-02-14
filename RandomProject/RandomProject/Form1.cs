using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int sayi1 = random.Next(0, 10);
            int sayi2 = random.Next(0, 10);
            int sayi3 = random.Next(0, 10);
            int sayi4 = random.Next(0, 10);
            int sayi5 = random.Next(0, 10);
            int sayi6 = random.Next(0, 10);
            int sayi7 = random.Next(0, 10);
            int sayi8 = random.Next(0, 10);

            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
            label3.Text = sayi3.ToString();
            label4.Text = sayi4.ToString();

            textBox1.Text = sayi5.ToString();
            textBox2.Text = sayi6.ToString();
            textBox3.Text = sayi7.ToString();
            textBox4.Text = sayi8.ToString();

            if(label1.Text == textBox1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            if(label2.Text == textBox2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            if (label3.Text == textBox3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            if (label4.Text == textBox4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }


        }
    }
}
