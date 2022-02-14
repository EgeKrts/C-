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

namespace Personel_Kayit
{
    public partial class FormIstatistik : Form
    {
        public FormIstatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-Q149M4S\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void FormIstatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("SELECT COUNT(*) FROM Personel_Info",baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read())
            {
                ToplamPer.Text = dr1[0].ToString();
            }
            
            
            baglanti.Close();

            //Evli-Personel

            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("SELECT COUNT(*) FROM Personel_Info WHERE MedeniDurum ='Evli' ", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                EvliPer.Text = dr2[0].ToString();
            }


            baglanti.Close();

            //Bekar-Personel

            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("SELECT COUNT(*) FROM Personel_Info WHERE MedeniDurum ='Bekar' ", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                BekarPer.Text = dr3[0].ToString();
            }
            
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("SELECT COUNT(DISTINCT(Şehir)) FROM Personel_Info ", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();

            while (dr4.Read())
            {
                SehirSay.Text = dr4[0].ToString();
            }

            baglanti.Close();

            //Toplam Maaş

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("SELECT SUM(Maaş) FROM Personel_Info", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();

            while (dr5.Read())
            {
                MaasTop.Text = dr5[0].ToString() +" TL";
            }
            baglanti.Close();

            //Maaş Ort

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("SELECT AVG(Maaş) FROM Personel_Info", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();

            while (dr6.Read())
            {
               OrtMaas.Text = dr6[0].ToString() +" TL";
            }
            baglanti.Close();
        }
    }
}
