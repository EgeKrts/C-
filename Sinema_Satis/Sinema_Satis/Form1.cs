using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int misir = Convert.ToInt32(textBox1.Text);
            int su = Convert.ToInt32(textBox2.Text);
            int kola = Convert.ToInt32(textBox3.Text);
            int bilet = Convert.ToInt32(textBox4.Text);

            double misirPrice = 10;
            double suPrice = 2;
            double kolaPrice = 5;
            double biletPrice = 15;

            double result = (misir * misirPrice) + (su * suPrice) + (kola * kolaPrice) + (bilet * biletPrice);


            listBox1.Items.Add("Mısır Sayısı : " + textBox1.Text);
            listBox1.Items.Add("Su Sayısı : " + textBox2.Text);
            listBox1.Items.Add("Kola Sayısı : " + textBox3.Text);
            listBox1.Items.Add("Bilet Sayısı : " + textBox4.Text);

            textBox5.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            listBox1.Items.Clear();
        }
    }
}
