using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithClassSql_Crud2
{
    public partial class FormBolumler : Form
    {
        Veritabani vt = new Veritabani();
        public FormBolumler()
        {
            InitializeComponent();
        }
        void Aktar()
        {
            txtBolum.Text = dgvBolumler.CurrentRow.Cells[1].Value.ToString();
        }
        void BolumTazele()
        {
            string sorguCumlesi = "SELECT * FROM tblBolumler";
            dgvBolumler.DataSource = vt.Listele(sorguCumlesi);
        }
        void Guncelle()
        {
            string id = dgvBolumler.CurrentRow.Cells[0].Value.ToString();
            string sorguCumlesi = $@"UPDATE tblBolumler SET
                    BolumAd='{txtBolum.Text}' 
                    WHERE ID={id}
                    ";
            vt.Islem(sorguCumlesi);
            BolumTazele();
        }
        void Kaydet()
        {
            btnYeni.Text = "Yeni";
            string sorguCumlesi = $@"INSERT INTO tblBolumler VALUES
                    (
                        '{txtBolum.Text}' )";
            vt.Islem(sorguCumlesi);
            BolumTazele();
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }
        void Yeni()
        {
            btnYeni.Text = "Kaydet";
            txtBolum.Clear();
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
      
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            if (btnYeni.Text == "Yeni")
            {
                Yeni();

            }
            else
            {
                Kaydet();
            }
        }

        private void FormBolumler_Load(object sender, EventArgs e)
        {
            BolumTazele();
        }

        private void dgvBolumler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Guncelle();
        }
    }
}
