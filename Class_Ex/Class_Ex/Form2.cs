using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Ex
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba araba2 = new Araba();
            araba2.renk = "Kırmızı";
            araba2.hız = 235;
            araba2.motor = 1654.68;
            araba2.fiyat = 150000;
            araba2.durum = "Sıfır";

            label1.Text = "Renk : " + araba2.renk;
            label2.Text = "Max Hız : " + araba2.hız.ToString();
            label3.Text = "Motor Gücü : " + araba2.motor.ToString();
            label4.Text = "Aracın Durumu : " + araba2.durum.ToString();
            label5.Text = "Fiyat :" + araba2.fiyat.ToString() + " TL";
        }
    }
}
