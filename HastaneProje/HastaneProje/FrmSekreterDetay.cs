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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        public string tc;
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblSekreterTC.Text = tc;

            //Sekreter Ad Çekme

            SqlCommand komut = new SqlCommand("SELECT SekreterAdSoyad FROM SekreterBilgi WHERE SekreterTC =@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblSekreterTC.Text);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                LblSekreterAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //Branş DataGrid e Aktarma

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT BransId,BransAd FROM BranslarBilgi",bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları DataGrid e Aktarma

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT (DoktorAd+' '+DoktorSoyad) AS 'Doktor Ad-Soyad',DoktorBrans FROM DoktorBilgi", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşı ComboBox a aktarma
            SqlCommand komut2 = new SqlCommand("SELECT BransAd FROM BranslarBilgi", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                comboBrans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("INSERT INTO Randevular(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) VALUES(@p1,@p2,@p3,@p4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2", mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", comboBrans.Text);
            komutkaydet.Parameters.AddWithValue("@p4", comboDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

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
    }
}
