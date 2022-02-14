using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionStructuresExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sinav1 = Convert.ToDouble(textBox1.Text);
            double sinav2 = Convert.ToDouble(textBox2.Text);
            double proje = Convert.ToDouble(textBox3.Text);

            double result = (sinav1 + sinav2 + proje) / 3;

            textBox4.Text = result.ToString("0.00");

            if (result >=50)
            {
                label5.Text = "Geçti";
            }
            else
            {
                label5.Text = "Kaldı";
            }


        }
    }
}
