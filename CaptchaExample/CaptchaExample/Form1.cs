using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptchaExample
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

            String[] symbol1 = { "a", "b", "c", "d", "e" };
            string[] symbol2 = { "+", "-", "*", "/" };
            

            int s1, s2, s3;
            s1 = random.Next(0, symbol1.Length);
            s2 = random.Next(0, symbol2.Length);
            s3 = random.Next(0, 10);

            label1.Text = symbol1[s1].ToString() +"     "+symbol2[s2].ToString() +"     "+s3.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
