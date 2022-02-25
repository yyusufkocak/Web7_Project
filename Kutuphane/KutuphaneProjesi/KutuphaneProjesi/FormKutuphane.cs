using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WithClassSql_Crud2;

namespace KutuphaneProjesi
{
    public partial class FormKutuphane : Form
    {
        Veritabani vt = new Veritabani();
        public FormKutuphane()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tapKitaplar_Click(object sender, EventArgs e)
        {

        }

        private void txtMeslek_TextChanged(object sender, EventArgs e)
        {

        }

        private void tapOdunc_Click(object sender, EventArgs e)
        {

        }

        private void FormKutuphane_Load(object sender, EventArgs e)
        {
            vt.SorguCUmlesi = "Select * From tblUyeler";
            dgvKitapTurleri.DataSource = vt.Listele();
        }

        private void tapTurler_Click(object sender, EventArgs e)
        {

        }
    }
}
