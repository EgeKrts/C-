using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_Kullanimlari
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Telefon : "+maskedTextBox1.Text + " ");
            listBox1.Items.Add("T.C : "+maskedTextBox2.Text + " ");
            listBox1.Items.Add("Tarih : "+maskedTextBox3.Text + " ");
            listBox1.Items.Add("Saat : "+maskedTextBox4.Text + " ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(dateTimePicker1.Text);
        }
    }
}
