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
    public partial class FormGuncelle : Form
    {
        VeriTabani vt = new VeriTabani();
        public FormGuncelle()
        {
            InitializeComponent();
        }
        void Doldur()
        {
            dgvHastalar.DataSource = vt.HastalariListele();
        }
        void Aktar()
        {
            txtTc.Text = dgvHastalar.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dgvHastalar.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text = dgvHastalar.CurrentRow.Cells[3].Value.ToString();
            cmbCinsiyet.Text = dgvHastalar.CurrentRow.Cells[4].Value.ToString() == "Kadın" ? "K" : "E";
            txtAdres.Text = dgvHastalar.CurrentRow.Cells[5].Value.ToString();
            txtTelefon.Text = dgvHastalar.CurrentRow.Cells[6].Value.ToString();
            txtMail.Text = dgvHastalar.CurrentRow.Cells[7].Value.ToString();
        }

        private void FormGuncelle_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string id = dgvHastalar.CurrentRow.Cells[0].Value.ToString();
            string cinsiyet = cmbCinsiyet.SelectedIndex == 0 ? "K" : "E";
            vt.Guncelle(id,txtTc.Text,txtAd.Text,txtSoyad.Text,cinsiyet,txtAdres.Text,txtTelefon.Text,txtMail.Text);
            Doldur();

        }

        private void dgvHastalar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string id = dgvHastalar.CurrentRow.Cells[0].Value.ToString();
            vt.Sil(id);
            Doldur();
        }
    }
}
