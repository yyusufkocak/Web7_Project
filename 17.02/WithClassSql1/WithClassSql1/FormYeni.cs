using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithClassSql1
{
    public partial class FormYeni : Form
    {
        VeriTabani veriTabani = new VeriTabani();
        public FormYeni()
        {
            InitializeComponent();
        }
        void Temizle()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is TextBox || this.Controls[i] is ComboBox)
                {
                    this.Controls[i].Text = "";
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            veriTabani.Ekle(txtTc.Text,txtAd.Text,txtSoyad.Text,
                            cmbCinsiyet.Text=="Kadın" ? "K":"E",
                            txtAdres.Text,txtTelefon.Text,txtMail.Text);

            //Temizle();
        }

        private void FormYeni_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAna formAna = new FormAna();
            formAna.Show();
            this.Hide();
        }
    }
}
