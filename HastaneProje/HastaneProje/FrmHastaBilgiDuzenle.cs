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
    public partial class FrmHastaBilgiDuzenle : Form
    {
        public FrmHastaBilgiDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public string tcno;
        private void FrmHastaBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = tcno;

            SqlCommand komut = new SqlCommand("SELECT * FROM HastaBilgi WHERE HastaTC =@p1", baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                TxtHastaAdi.Text = dr[1].ToString();
                TxtHastaSoyad.Text = dr[2].ToString();
                MskHastaTel.Text = dr[4].ToString();
                TxtHastaSifre.Text = dr[5].ToString();
                comboCinsiyet.Text = dr[6].ToString();
            }
            baglan.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("UPDATE HastaBilgi SET HastaAd =@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 WHERE HastaTC =@p6", baglan.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtHastaAdi.Text);
            komut2.Parameters.AddWithValue("@p2",TxtHastaSoyad.Text);
            komut2.Parameters.AddWithValue("@p3",MskHastaTel.Text);
            komut2.Parameters.AddWithValue("@p4", TxtHastaSifre.Text);
            komut2.Parameters.AddWithValue("@p5",comboCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", MskTC.Text);
            komut2.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Hasta Bilgileri Güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
