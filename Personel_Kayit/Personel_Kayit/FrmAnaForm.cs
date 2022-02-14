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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-Q149M4S\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");


        void temizle()
        {
            IdTxt.Text = "";
            AdTxt.Text = "";
            SoyadTxt.Text = "";
            MeslekTxt.Text = "";
            MaasTxt.Text = "";
            SehirTxt.Text = "";
            MedeniTxt.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet2.Personel_Info' table. You can move, or remove it, as needed.
            this.personel_InfoTableAdapter2.Fill(this.personelVeriTabaniDataSet2.Personel_Info);



        }

        private void ListeleBtn_Click(object sender, EventArgs e)
        {
            this.personel_InfoTableAdapter2.Fill(this.personelVeriTabaniDataSet2.Personel_Info);

        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutguncel = new SqlCommand("INSERT INTO Personel_Info(Ad,Soyad,Şehir,Maaş,MedeniDurum,Meslek) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komutguncel.Parameters.AddWithValue("@p1", AdTxt.Text);
            komutguncel.Parameters.AddWithValue("@p2", SoyadTxt.Text);
            komutguncel.Parameters.AddWithValue("@p3", SehirTxt.Text);
            komutguncel.Parameters.AddWithValue("@p4", MaasTxt.Text);
            komutguncel.Parameters.AddWithValue("@p5", MedeniTxt.Text);
            komutguncel.Parameters.AddWithValue("@p6", MeslekTxt.Text);
            komutguncel.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi!");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Evli";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Bekar";
        }

        private void TemizleBtn_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            IdTxt.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            AdTxt.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            SoyadTxt.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            SehirTxt.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MaasTxt.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            MedeniTxt.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            MeslekTxt.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM Personel_Info WHERE PersonelID = @k1", baglanti);
            komut.Parameters.AddWithValue("@k1", IdTxt.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kayıt Silindi!");
        }

        private void GüncelleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE Personel_Info SET Ad = @a1,Soyad=@a2,Şehir = @a3, Maaş = @a4,MedeniDurum =@a5,Meslek =@a6 WHERE PersonelID = @a7",baglanti);
            komut.Parameters.AddWithValue("@a7", IdTxt.Text);
            komut.Parameters.AddWithValue("@a1", AdTxt.Text);
            komut.Parameters.AddWithValue("@a2", SoyadTxt.Text);
            komut.Parameters.AddWithValue("@a3", SehirTxt.Text);
            komut.Parameters.AddWithValue("@a4", MaasTxt.Text);
            komut.Parameters.AddWithValue("@a5", MedeniTxt.Text);
            komut.Parameters.AddWithValue("@a6", MeslekTxt.Text);
          
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi!");
        }

        private void İstatistikBtn_Click(object sender, EventArgs e)
        {
            FormIstatistik formIstatistik = new FormIstatistik();
            formIstatistik.Show();
        }

        private void GrafiklerBtn_Click(object sender, EventArgs e)
        {
            FrmGrafikler frmGrafikler = new FrmGrafikler();
            frmGrafikler.Show();
        }
    }
}
