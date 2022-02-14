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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        public string tc;

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            TblTC.Text = tc;


            //Ad-Soyad Çekme
            SqlCommand komut = new SqlCommand("SELECT HastaAd,HastaSoyad FROM HastaBilgi WHERE HastaTC = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] +" "+dr[1];
            }

            bgl.baglanti().Close();

            //Randevu Geçmiş
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Randevular WHERE HastaTC ="+tc,bgl.baglanti());
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşları Çekme
            SqlCommand komut2 = new SqlCommand("SELECT BransAd FROM BranslarBilgi", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                comboBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            
            

        }
        //Branşa göre doktor çekme
        private void comboBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("SELECT DoktorAd,DoktorSoyad FROM DoktorBilgi WHERE DoktorBrans = @p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", comboBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                comboDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();

        }

        private void comboDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Randevular WHERE RandevuBrans='"+comboBrans.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void linkBilgiGüncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgiDuzenle hastaBilgiDuzenle = new FrmHastaBilgiDuzenle();
            hastaBilgiDuzenle.tcno = TblTC.Text;
            hastaBilgiDuzenle.Show();
        }
    }
}
