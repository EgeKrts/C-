using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlis = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;

            label2.Text = btnB.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                dgrLbl.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                ynlsLbl.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;
            label2.Text = btnC.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                dgrLbl.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                ynlsLbl.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;
            label2.Text = btnD.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                dgrLbl.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                ynlsLbl.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;
            label2.Text = btnA.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                dgrLbl.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                ynlsLbl.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soruNo++;
            soruLbl.Text = soruNo.ToString();

            if (soruNo ==1)
            {
                richTextBox1.Text = "Hangisi Fenerbahçe Futbol Takımı'nda oynamadı?";
                btnA.Text = "Burak Yılmaz";
                btnB.Text = "Robin Van Persie";
                btnC.Text = "Roberto Carlos";
                btnD.Text = "Atiba Hutchinson";

                label1.Text = "Atiba Hutchinson";
            }
            if (soruNo ==2)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi programlama dili değildir?";
                btnA.Text = "JAVA";
                btnB.Text = "C#";
                btnC.Text = "Shark";
                btnD.Text = "C++";

                label1.Text = "Shark";

            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Aşağıdakilerden hangi otomobil markası Alman markası değildir?";
                btnA.Text = "Opel";
                btnB.Text = "BMW";
                btnC.Text = "Smart";
                btnD.Text = "Peugeot";

                label1.Text = "Peugeot";
                btnNext.Text = "Sonuçlar";

            }
            if (soruNo >=4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnNext.Enabled = false;
                MessageBox.Show("Doğru : " + dgrLbl.Text + "\n" + "Yanlış : " + ynlsLbl.Text);

            }
        }
    }
}
