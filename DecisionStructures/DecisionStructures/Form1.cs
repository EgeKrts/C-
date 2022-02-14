using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionStructures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);

            if (sayi % 2 ==0 || sayi > 10)
            {
                label1.Text = "Çift Sayı veya 10 'dan büyük";
            }
            else
            {
                label1.Text = "10'dan büyük değil ve Çift Değil";
            }
        }
    }
}
