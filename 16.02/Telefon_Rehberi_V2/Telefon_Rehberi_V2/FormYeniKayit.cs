using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Rehberi_V2
{
    public partial class FormYeniKayit : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        string sorguCümlesi;
        string baglantiCümlesi;
        public FormYeniKayit()
        {
            InitializeComponent();
        }

        private void YeniKayit_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            FormAnaMenu anaMenu = new FormAnaMenu();
            anaMenu.Show();
            this.Hide();
        }

        private void FormYeniKayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnKapat.PerformClick();
        }
        void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            mtxtTelefon.Clear();
            cmbCinsiyet.SelectedIndex = 0;
        }
        void Kaydet()
        {
            try
            {
                baglantiCümlesi = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=aRehber;User=sa;pwd=123";
                baglanti = new SqlConnection(baglantiCümlesi);
                baglanti.Open();

                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                string tel = mtxtTelefon.Text;
                string cinsiyet = cmbCinsiyet.Text == "Kadın" ? "K" : "E";
                sorguCümlesi = $"INSERT INTO tblKisiler VALUES ('{ad}','{soyad}','{cinsiyet}','{tel}')";
                komut = new SqlCommand(sorguCümlesi, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("Kayıt işlemi başarıyla tamamlandı");
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu,işlem yapılamadı!");
                throw;
            }

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
    }
}
