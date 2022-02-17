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


    public partial class Form3 : Form
    {
       public int oyunHak ;
       public int tSayi ;
       public int sonuc;


        void AktifPasif()
        {
            if (txtSayiGir.Enabled==true && btnTahminEt.Enabled==true)
            {
                txtSayiGir.Enabled = false;
                btnTahminEt.Enabled = false;
            }
            else
            {
                txtSayiGir.Enabled = true;
                btnTahminEt.Enabled = true;
            }
        }
        static int RandomSayi()
        {
            Random randomS = new Random();
            return randomS.Next(1, 100);
        }
        int SayiGir()
        {
            return Convert.ToInt32(txtSayiGir.Text);
        }
        bool SayiKontrol(int sayi, int randomSayi)
        {
            if (sayi == randomSayi)
            {
                return true;
            }
            else if (sayi > randomSayi)
            {
        
                lblTahminAciklama.Text = "Biraz daha küçük bir sayı girin !";
                
                sonuc = Puan(sonuc);
                return false;
            }
            else if (sayi < randomSayi)
            {
               
               
                lblTahminAciklama.Text = "Biraz daha büyük bir sayı girin !";
                sonuc = Puan(sonuc);
                return false;
            }

            return false;

        }
        int Puan(int puan)
        {
            puan = puan - 10;
            return puan;
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            AktifPasif();
            lblRandomSayi.Text = "";
            lblTahminAciklama.Text = "";
            lblPuan.Text = "";
            label1.Text = "Başlamak İçin Start Yapın";
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            oyunHak--;
            label1.Text = "Kalan Hakkınız : " + oyunHak;

            int gSayi = SayiGir();

                if (SayiKontrol(gSayi, tSayi) == true)
                {

                    lblTahminAciklama.Text = "Tebrikler Kazandınız ! Toplam Puanınız : " + sonuc;
                    AktifPasif();
                btnBaslat.Enabled = true;

            }
                else if (oyunHak == 0)
                {
                    sonuc = Puan(sonuc);
                    lblTahminAciklama.Text = "Hakkınız Bitti.Kaybettiniz ! Toplam Puanınız : " + sonuc;
                    AktifPasif();
                btnBaslat.Enabled = true;

            }
               
               
            lblPuan.Text = "Şu anki Puanınız:" + sonuc;

        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            AktifPasif();
            tSayi = RandomSayi();
            oyunHak = 5;
            sonuc = 100;
            lblPuan.Text = "Şu anki Puanınız:" + sonuc;
            lblRandomSayi.Text = "Rastgele Sayımız :" + tSayi;
            label1.Text = "Kalan Hakkınız : " + oyunHak;
            lblTahminAciklama.Text = "";
            txtSayiGir.Text = "";
            btnBaslat.Enabled = false;
        }
    }
}
