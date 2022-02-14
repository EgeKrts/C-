using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnlocation = new Point(20, 10);
            btn.Location = btnlocation;
            btn.Name = "Button1";
            btn.Text = "Tıkla";
            btn.BackColor = Color.Green;
            btn.Height = 50;
            btn.Width = 80;
            this.Controls.Add(btn);

            Label label1 = new Label();
            Point lblocation = new Point(250, 20);
            label1.Location = lblocation;
            label1.Name = "Label1";
            label1.Text = "Merhaba";
            label1.BackColor = Color.Yellow;
            this.Controls.Add(label1);


            

            for (int i = 1 ; i < 5; i++)
            {
                TextBox txt = new TextBox();
                Point txtLoc = new Point(300, i * 25);
                txt.Location = txtLoc;
                txt.Name = "TextBox" + i;
                txt.Text = "Koltuk " + i;
                this.Controls.Add(txt);
            }

        }
    }
}
