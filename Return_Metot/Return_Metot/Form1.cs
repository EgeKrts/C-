using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Return_Metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int topla(int x,int y)
        {
            int sonuc = x + y;

            return sonuc;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);

            int sayi2 = Convert.ToInt32(textBox2.Text);

           label2.Text = topla(sayi1,sayi2).ToString();
        }
    }
}
