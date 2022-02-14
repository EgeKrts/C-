using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProje
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void BtnHasta_Click(object sender, EventArgs e)
        {
            FrmHastaGiris hastaGiris = new FrmHastaGiris();
            hastaGiris.Show();
            this.Hide();

        }

        private void BtnDoktor_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris doktorGiris = new FrmDoktorGiris();
            doktorGiris.Show();
            this.Hide();
        }

        private void BtnSekreter_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris sekreterGiris = new FrmSekreterGiris();
            sekreterGiris.Show();
            this.Hide();
        }
    }
}
