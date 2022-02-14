using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mevsim = Convert.ToInt32(textBox1.Text);

            switch (mevsim)
            {
                case 1: label2.Text = "Sonbahar";
                    break;
                case 2: label2.Text = "Kış";
                    break;
                case 3:
                    label2.Text = "İlkbahar";
                    break;
                case 4:
                    label2.Text = "Yaz";
                    break;
                default :
                    label2.Text = "Hatalı sayı girdiniz!";
                    break;
            }
        }
    }
}
