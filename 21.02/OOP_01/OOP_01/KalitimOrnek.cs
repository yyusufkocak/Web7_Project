using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_01
{
    public partial class KalitimOrnek : Form
    {
        Sepet sepet = new Sepet();
        public KalitimOrnek()
        {
            InitializeComponent();
        }
        class Urun
        {
            public string UrunAdi { get; set; }
            public double Fiyat { get; set; }
            public double KDVUygula()
            {
                return Fiyat * 1.18;
            }
            public Urun()
            {

            }
            public Urun(string UrunAdi, double Fiyat)
            {
                this.UrunAdi = UrunAdi;
                this.Fiyat = Fiyat;
            }
        }
        class Tekstil : Urun
        {
            public string KumasTuru { get; set; }
            public short Beden { get; set; }
            public string UreticiFirma { get; set; }

            public Tekstil(string tAd, double tFiyat, string tKumasTuru, short tBeden)
            {
                UrunAdi = tAd;
                Fiyat = tFiyat;
                KumasTuru = tKumasTuru;
                Beden = tBeden;
            }
        }
        class CepTelefonu : Urun
        {
            public string Ozellikler { get; set; }
            public string Marka { get; set; }
            public CepTelefonu(string cAd, double cFiyat, string cMarka)
            {
                UrunAdi = cAd;
                Fiyat = cFiyat;
                Marka = cMarka;
            }
        }
        class Ekmek : Urun
        {
            public string EkmekTuru { get; set; }
            public double Gramaj { get; set; }

            public Ekmek(string eAd, double eFiyat, string eEkmekTuru, double eGramaj)
            {
                UrunAdi = eAd;
                Fiyat = eFiyat;
                EkmekTuru = eEkmekTuru;
                Gramaj = eGramaj;
            }
        }
        class Sepet
        {
            List<Urun> Urunler = new List<Urun>();
            public double ToplamTutar()
            {
                double toplamFiyat = 0;

                foreach (var item in Urunler)
                {
                    toplamFiyat += item.KDVUygula();
                }
                return toplamFiyat;
            }
            public void SepeteEkle(Urun eklenecekUrun)
            {
                Urunler.Add(eklenecekUrun);
            }
        }
        private void KalitimOrnek_Load(object sender, EventArgs e)
        {
            //sepet.SepeteEkle(ekmek);
            //sepet.SepeteEkle(cepTelefonu1);
            //MessageBox.Show(sepet.ToplamTutar().ToString());
        }

        private void btnTekstil_Click(object sender, EventArgs e)
        {
            Tekstil tekstil = new Tekstil("pantolon", 100, "Kot", 42);
            sepet.SepeteEkle(tekstil);
            dgvSepet.Rows.Add(tekstil.UrunAdi,tekstil.Fiyat,tekstil.KDVUygula());
            lblToplam.Text = sepet.ToplamTutar().ToString();

        }

        private void btnCepTelefonu_Click(object sender, EventArgs e)
        {
            CepTelefonu cepTelefonu1 = new CepTelefonu("TCL PLEX", 9000, "TCL");
            sepet.SepeteEkle(cepTelefonu1);
            dgvSepet.Rows.Add(cepTelefonu1.UrunAdi,cepTelefonu1.Fiyat,cepTelefonu1.KDVUygula());
            lblToplam.Text = sepet.ToplamTutar().ToString();
        }

        private void btnEkmek_Click(object sender, EventArgs e)
        {
            Ekmek ekmek = new Ekmek("Uno", 1000, "Kepekli", 330);
            sepet.SepeteEkle(ekmek);
            dgvSepet.Rows.Add(ekmek.UrunAdi, ekmek.Fiyat, ekmek.KDVUygula());
            lblToplam.Text = sepet.ToplamTutar().ToString();

        }
    }
}
