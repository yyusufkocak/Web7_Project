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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            rdbKadin.Checked = true;
            lblMesaj.Text = "";
        }
        string CinsiyetBelirleme()
        {
            if (rdbKadin.Checked==true)
            {
                return "Kadın";
            }
            else
            {
                return "Erkek";
            }
           
        }
        void Ekle()
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = txtAdSoyad.Text;//Text,lvi'nin 1.kolonu demektir.
            lvi.SubItems.Add(CinsiyetBelirleme());//SubItems.Add 1.kolandan sonraki kolonlar için kullanılır
            lvi.SubItems.Add("Wissen Akademie");
            lstKisiler.Items.Add(lvi);
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = txtAranan.Text.ToUpper();
            ListViewItem[] lviSonuc = lstKisiler.Items.Find(aranan, true);
            MessageBox.Show(lviSonuc.Length.ToString());
            lstKisiler.Clear();
            lstKisiler.Items.AddRange(lviSonuc);
        }
    }
}
