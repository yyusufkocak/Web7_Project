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
    public partial class FormDoktorlar : Form
    {
        Veritabani vt = new Veritabani();
        string sorguCümlesi;
        public FormDoktorlar()
        {
            InitializeComponent();
        }
        void DoktorlarıListele()
        {
            sorguCümlesi = $"SELECT * FROM tblDoktorlar";
            dgvDoktorlar.DataSource = vt.Listele(sorguCümlesi);
        }
        private void FormDoktorlar_Load(object sender, EventArgs e)
        {
            DoktorlarıListele();
            cmbBolum.DataSource = vt.Listele("SELECT * FROM tblBolumler");
            cmbBolum.DisplayMember = "BolumAd";
            cmbBolum.ValueMember = "ID";
        }
    }
}
