using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_01
{


    public partial class Form2 : Form
    {
        int Hesapla(int sayi1,int sayi2,string islem)
        {
            int sonuc=0;
            if (islem == "+")
            {
                sonuc = sayi1 + sayi2;
                return sonuc;
            }
            else if (islem == "-")
            {
                sonuc = sayi1 - sayi2;
                return sonuc;
            }
            else if (islem == "*")
            {
                sonuc = sayi1 * sayi2;
                return sonuc;
            }
            else
                sonuc = sayi1 / sayi2;
                return sonuc;
        }
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnTopla_Click(object sender, EventArgs e)
        {

          int islemSonuc=  Hesapla(Convert.ToInt32(txtSayı1.Text), Convert.ToInt32(txtSayı2.Text), btnTopla.Text);
            lblSonuc.Text = Convert.ToString(islemSonuc);
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            int islemSonuc = Hesapla(Convert.ToInt32(txtSayı1.Text), Convert.ToInt32(txtSayı2.Text), btnCikar.Text);
            lblSonuc.Text = Convert.ToString(islemSonuc);
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            int islemSonuc = Hesapla(Convert.ToInt32(txtSayı1.Text), Convert.ToInt32(txtSayı2.Text), btnCarp.Text);
            lblSonuc.Text = Convert.ToString(islemSonuc);
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            int islemSonuc = Hesapla(Convert.ToInt32(txtSayı1.Text), Convert.ToInt32(txtSayı2.Text), btnBol.Text);
            lblSonuc.Text = Convert.ToString(islemSonuc);
        }
    }
}
