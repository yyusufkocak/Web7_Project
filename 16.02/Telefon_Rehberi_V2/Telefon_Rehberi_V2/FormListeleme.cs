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
    public partial class FormListeleme : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter adapter;
        DataTable dt;
        SqlCommand komut;
        string baglantiCümlesi = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=aRehber;User=sa;pwd=123";
        string sorguCumlesi;
        public FormListeleme()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Doldur()
        {
            sorguCumlesi = $"SELECT * FROM tblKisiler";
            baglanti = new SqlConnection(baglantiCümlesi);
            adapter = new SqlDataAdapter(sorguCumlesi, baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvKisiler.DataSource = dt;

        }
        private void FormListeleme_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            FormAnaMenu formAnaMenu = new FormAnaMenu();
            formAnaMenu.Show();
            this.Hide();

        }
        void Sil()
        {
            string id = dgvKisiler.CurrentRow.Cells[0].Value.ToString();
            sorguCumlesi = $"DELETE tblKisiler WHERE ID='{id}'";
            baglanti = new SqlConnection(baglantiCümlesi);
            baglanti.Open();
            komut = new SqlCommand(sorguCumlesi,baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Doldur();

        }
        void Guncelle()
        {
            string cinsiyet = cmbCinsiyet.SelectedIndex == 0 ? "K" : "E";
            string id = dgvKisiler.CurrentRow.Cells[0].Value.ToString();
            sorguCumlesi = $"UPDATE tblKisiler SET Ad='{txtAd.Text}',Soyad='{txtSoyad.Text}',Cinsiyet='{cinsiyet}',Telefon='{mtxtTelefon.Text}' WHERE ID='{id}' ";
            baglanti = new SqlConnection(baglantiCümlesi);
            baglanti.Open();
            komut = new SqlCommand(sorguCumlesi,baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Doldur();

        }
        void Aktar()
        {
            txtAd.Text = dgvKisiler.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvKisiler.CurrentRow.Cells[2].Value.ToString();
            cmbCinsiyet.SelectedIndex = dgvKisiler.CurrentRow.Cells[3].Value.ToString() == "K" ? 0 : 1;
            mtxtTelefon.Text = dgvKisiler.CurrentRow.Cells[4].Value.ToString();
        }
        private void FormListeleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnKapat.PerformClick();
        }

        private void dgvKisiler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }
    }
}
