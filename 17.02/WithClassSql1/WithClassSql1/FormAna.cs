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
    public partial class FormAna : Form
    {
        VeriTabani vt = new VeriTabani();

        public FormAna()
        {
            InitializeComponent();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            dgvHastalar.DataSource = vt.HastalariListele();

        }

       

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            FormYeni formYeni = new FormYeni();
            formYeni.Show();
            this.Hide();
        }

        private void FormAna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDSil_Click(object sender, EventArgs e)
        {
            FormGuncelle formGuncelle = new FormGuncelle();
            formGuncelle.Show();
            this.Hide();
        }
    }
}
