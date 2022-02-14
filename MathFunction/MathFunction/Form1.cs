using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);

            //label2.Text = Math.Abs(num).ToString(); //mutlak
            //label2.Text = Math.Ceiling(num).ToString(); //üste yuvarlama
            //label2.Text = Math.Floor(num).ToString(); //alta yuvarlama
            //label2.Text = Math.Pow(num, 3).ToString(); //üs alma
            //label2.Text = Math.Sqrt(num).ToString(); //karekök
        }
    }
}
