using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart_Using
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Kitap"].Points.AddXY("Ege", 3);
            chart1.Series["Kitap"].Points.AddXY("Karadeniz", 2);
            chart1.Series["Kitap"].Points.AddXY("Marmara", 5);
            chart1.Series["Kitap"].Points.AddXY("Akdeniz", 4);
            chart1.Series["Kitap"].Points.AddXY("iç Anadolu", 2);
            chart1.Series["Kitap"].Points.AddXY("Doğu Anadolu", 1);
            chart1.Series["Kitap"].Points.AddXY("Güneydoğu Anadolu", 1);
        }
    }
}
