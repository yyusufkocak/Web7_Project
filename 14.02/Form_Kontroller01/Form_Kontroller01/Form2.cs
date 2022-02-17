using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Kontroller01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void Ekle()
        {
            listKisiler.Items.Add(txtAdSoyad.Text);
            txtAdSoyad.ResetText();
            txtAdSoyad.Focus();
            lblKisiSayisi.Text = listKisiler.Items.Count.ToString();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!Ara(txtAdSoyad.Text))
            {
                Ekle();
            }
            else
            {
                MessageBox.Show("İlgili Kişi Kayıtlı");
            }
           
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter && txtAdSoyad.Text!="")
            {
                Ekle();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblKisiSayisi.Text = "";
        }
        bool Ara(string aranan)
        {
            
            if (listKisiler.Items.Contains(aranan))
            {
                return true;
               
            }
            else
            {
                return false;
               
            }
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = txtAranan.Text;
            if (Ara(txtAranan.Text))
            {
                lblSonuc.Text = aranan;
            }
            else
            {
                lblSonuc.Text = "Aradığınız Kayıt Bulunamadı";
            }
        }
    }
}
