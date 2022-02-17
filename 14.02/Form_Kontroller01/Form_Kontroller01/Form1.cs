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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSayi_TextChanged(object sender, EventArgs e)
        {
            //lblKopya.Text = txtSayi.Text;
        }

        private void txtSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ////lblKopya.Text = e.KeyChar.ToString();
            ////e.Handled = true;
            //if (e.KeyChar.ToString()=="E")
            //{
            //    e.Handled = false;// Girişe izin var
            //}
            //else
            //{
            //    e.Handled = true; //Girişe izin yok
            //}

            if (!((char.IsDigit(e.KeyChar)) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textHarf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //IsGidit -> Rakam mı değil mi_
            //IsLetter -> Harf mi değil mi ?

            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }



        private void textBHarf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsUpper(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space;
        }

        private void btnMesaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Kestane Balının diyarı {cmbSehirler.Text}\n şehrinden tüm dünyaya selamlar");
        }

        private void cmbSehirler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbHayir_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("O zaman bana bir kahve ısmarla");
        }
        string Cinsiyet()
        {
            if (rdbKadin.Checked == true)
            {
                return "Bayan";
            }
            else
            {
                return "Bay";
            }
        }
        bool Cevap()
        {
            if (rbEvet.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void rbEvet_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("O zaman sana bir kahve ısmarlayayım");
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            string mesaj = $"{Cinsiyet()} {textHarf.Text}";

            if (Cevap())
            {
                mesaj = ", bana kahve ısmarlar mısın?";
            }
            else
            {
                mesaj = ", gel sana bir kahve ısmarlayayım.";
            }
            label5.Text = mesaj;
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            
        }
    }
}
