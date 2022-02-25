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

        private void FormKutuphane_Load(object sender, EventArgs e)
        {
            //Ödünç İşlemleri gridimizi dolduruyor.
            vt.TableName = "tblOdunc";
            vt.Islem();
            dgvOdunc.DataSource = vt.dt;

            //Üye listemzi dolduruyor
            vt.TableName = "tblUyeler";
            vt.Islem();
            dgvOduncUye.DataSource = vt.dt;
            for (int i = 0; i < dgvOduncUye.ColumnCount; i++)
            {
                dgvOduncUye.Columns[i].Visible = false;
            }
            dgvOduncUye.Columns[1].Visible = true;
            dgvOduncUye.Columns[1].HeaderText = "Üye Adı";

            //Kitap Listemizi Doldurur
            vt.TableName = "tblKitaplar";
            vt.Islem();
            dgvOduncKitap.DataSource = vt.dt;
            for (int i = 0; i < dgvOduncKitap.ColumnCount; i++)
            {
                dgvOduncKitap.Columns[i].Visible = false;
            }
            dgvOduncKitap.Columns[1].Visible = true;
            dgvOduncKitap.Columns[1].HeaderText = "Kitap Adı";

            pnlOduncTeslimTarihi.Visible = false;

            dtpOduncTeslimETarihi.Text = dtpOduncTeslimETarihi.Value.AddDays(5).ToString();
        }

        private void dtpOduncVerilisTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtpOduncTeslimETarihi.Text = dtpOduncTeslimETarihi.Value.AddDays(5).ToString();
        }

        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            Odunc yeniOdunc = new Odunc();
            yeniOdunc.UyeID = Convert.ToInt32(dgvOduncUye.SelectedRows[0].Cells[0].Value.ToString());
            yeniOdunc.KitapISBN = dgvOduncKitap.SelectedRows[0].Cells[0].Value.ToString();
            yeniOdunc.VerilisTarihi = dtpOduncVerilisTarihi.Value;
            yeniOdunc.Durum = false; //yani bu kayıt silinmiş değil
            vt.Islem(yeniOdunc);
            //Ödünç İşlemleri gridimizi dolduruyor.
            vt.TableName = "tblOdunc";
            vt.Islem();
            dgvOdunc.DataSource = vt.dt;
        }

        private void btnOduncIptal_Click(object sender, EventArgs e)
        {
            Odunc iptalOdunc = new Odunc();
            string silinecekID = dgvOdunc.SelectedRows[0].Cells[0].Value.ToString();
            vt.TableName = "tblOdunc";
            vt.Islem(silinecekID);
            vt.Islem();
            dgvOdunc.DataSource = vt.dt;

        }
    }
}
