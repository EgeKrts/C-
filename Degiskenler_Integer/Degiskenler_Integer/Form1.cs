using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_Integer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int kenar = 15;
            int alan = kenar* kenar;
            int cevre = 4 * kenar;
            label1.Text = "Alan :" + alan + "\n"+
                           "Cevre :" + cevre; */

            /*int sayi;
            sayi = Convert.ToInt32(textBox1.Text);

            label2.Text = sayi.ToString();*/

            int num, result;
            num = Convert.ToInt32(textBox1.Text);
            result = num * num * num;

            label2.Text = result.ToString();


        }
    }
}
