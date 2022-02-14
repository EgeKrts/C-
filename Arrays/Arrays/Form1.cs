using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] people = { "Ali", "Veli", "Ceren","Ayşe" };

            //For Kullanımı
            /*
            for (int i = 0; i < people.Length; i++)
            {
                listBox1.Items.Add(people[i]);
            }*/

            //For-each Kullanımı
            /*
            foreach (String person in people)
            {
                listBox1.Items.Add(person);
            }*/
        }
    }
}
