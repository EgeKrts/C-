using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HastaneProje
{
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void BtnKayıtOl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO HastaBilgi(HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) VALUES (@k1,@k2,@k3,@k4,@k5,@k6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", TxtHastaAdi.Text);
            komut.Parameters.AddWithValue("@k2", TxtHastaSoyad.Text);
            komut.Parameters.AddWithValue("@k3", MskTC.Text);
            komut.Parameters.AddWithValue("@k4", MskHastaTel.Text);
            komut.Parameters.AddWithValue("@k5", TxtHastaSifre.Text);
            komut.Parameters.AddWithValue("@k6", comboCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Hasta Kaydı Oluşturuldu","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
