using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_Double
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize = Convert.ToDouble(textBox1.Text);
            double final = Convert.ToDouble(textBox2.Text);
            double odev = Convert.ToDouble(textBox3.Text);

            double ortalama = (vize + final + odev) / 3;

            label4.Text = ortalama.ToString("0.00");
        }
    }
}
