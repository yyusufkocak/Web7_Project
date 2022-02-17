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

namespace Telefon_Rehberi_V1
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter adapter;
        DataTable dt;
        SqlCommand komut;
        string id;
        string ad;
        string soyad;
        string cinsiyet;
        string tel;
        string baglantiCümlesi =@"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=aRehber; User=sa; Pwd=123";
        void KisileriGetir()
        {
            sorguCümlesi = "SELECT * FROM tblKisiler";
            baglanti = new SqlConnection(baglantiCümlesi);
            adapter = new SqlDataAdapter(sorguCümlesi,baglantiCümlesi);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvKisiler.DataSource = dt;
            dgvKisiler.Columns[0].Visible = false;
        }
        string sorguCümlesi ;
        public Form1()
        {
            InitializeComponent();
        }
        void Aktar()
        {
            lblID.Text = dgvKisiler.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dgvKisiler.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvKisiler.CurrentRow.Cells[2].Value.ToString();
            rdbKadin.Checked = dgvKisiler.CurrentRow.Cells[3].Value.ToString() == "K" ? true : false;
            rdbErkek.Checked = dgvKisiler.CurrentRow.Cells[3].Value.ToString() == "E" ? true : false;
            //if (dgvKisiler.CurrentRow.Cells[2].Value.ToString()=="K")
            //{
            //    rdbKadin.Checked = true;
            //}
            //else
            //{
            //    rdbErkek.Checked = true;
            //}
            txtNumara.Text = dgvKisiler.CurrentRow.Cells[4].Value.ToString();

        }
        void Kaydet()
        {
           
            ad = txtAd.Text;
            soyad = txtSoyad.Text;
            tel = txtNumara.Text;
            if (rdbKadin.Checked == true)
            {
                cinsiyet = "K";
            }
            else
            {
                cinsiyet = "E";
            }
            sorguCümlesi = $"INSERT INTO tblKisiler VALUES('{ad}','{soyad}','{cinsiyet}','{tel}')";
            baglanti = new SqlConnection(baglantiCümlesi);
            komut = new SqlCommand(sorguCümlesi,baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisileriGetir();
        }
        void Sil()
        {
            id = lblID.Text;
            sorguCümlesi = $"DELETE tblKisiler Where ID={id}";
            baglanti = new SqlConnection(baglantiCümlesi);
            komut = new SqlCommand(sorguCümlesi,baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisileriGetir();
        }
        void Duzelt()
        {
            id = lblID.Text;
            ad = txtAd.Text;
            soyad = txtSoyad.Text;
            
            if (rdbKadin.Checked==true)
            {
                cinsiyet = "K";
            }
            else
            {
                cinsiyet = "E";
            }
            tel = txtNumara.Text;
            sorguCümlesi = $"UPDATE tblKisiler SET Ad='{ad}',Soyad='{soyad}',Cinsiyet='{cinsiyet}',Telefon='{tel}' WHERE ID={id} ";
            baglanti = new SqlConnection(baglantiCümlesi);
            komut = new SqlCommand(sorguCümlesi,baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisileriGetir();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Duzelt();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KisileriGetir();
        }

      

        private void dgvKisiler2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Aktar();
        }

        private void dgvKisiler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sil();
        }
        void YeniKayitFormuHazirla()
        {
            //textboxları temizler,Düzelt ve Sil'i pasif yapar.
            lblID.Text = "Yeni Kayıt";
            txtAd.ResetText();
            txtSoyad.ResetText();
            txtNumara.ResetText();
            rdbErkek.Checked = false;
            rdbKadin.Checked = false;
            txtAd.Focus();

            AktifPasif();
        }
        void AktifPasif()
        {
            if (button2.Enabled==true)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                dgvKisiler.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
                button3.Enabled = true;
                dgvKisiler.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text=="Yeni")
            {
                button1.Text = "Kaydet";
                YeniKayitFormuHazirla();
            }
            else
            {
                button1.Text = "Yeni";
                AktifPasif();
                Kaydet();
            }
        }
        void Arama()
        {
            DataView dw = dt.DefaultView;
            string ara = txtAranan.Text;
            dw.RowFilter = $"Ad LIKE '{ara}%' OR Soyad LIKE '{ara}%'";
            dgvKisiler.DataSource = dw;
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            Arama();
        }

        private void txtAranan_KeyDown(object sender, KeyEventArgs e)
        {
            Arama();
        }

        private void txtAranan_KeyUp(object sender, KeyEventArgs e)
        {
            Arama();
        }
    }
}
