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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba araba1 = new Araba();
            araba1.renk = "Altın";
            araba1.hız = 220;
            araba1.motor = 1435.58;
            araba1.fiyat = 100000;
            araba1.durum = "Sıfır";
            araba1.YIL = 2021;
            araba1.MARKA = "VOLKSWAGEN";
            araba1.muayene = 2020;
            araba1.plaka = "20 AV 123";
            araba1.sahip = "Ayşe Yıldız";

            label1.Text = "Renk : " + araba1.renk;
            label2.Text = "Max Hız : " + araba1.hız.ToString();
            label3.Text = "Motor Gücü : " + araba1.motor.ToString();
            label4.Text = "Aracın Durumu : " +araba1.durum.ToString();
            label5.Text = "Marka : " + araba1.MARKA.ToString();
            label6.Text = "Yılı : " + araba1.YIL.ToString();
            label7.Text = "Fiyat :" + araba1.fiyat.ToString() + " TL";
            label8.Text = "Plaka : " + araba1.plaka;
            label9.Text = "Muayene Yılı : " + araba1.muayene.ToString();
            label10.Text = "Aracın Sahibi : " + araba1.sahip; 
         

        }
    }
}
