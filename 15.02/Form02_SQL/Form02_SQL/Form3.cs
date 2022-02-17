using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form02_SQL
{
    public partial class Form3 : Form
    {
        string sorguCumlesı;
        SqlConnection baglanti;
        string baglantiCumlesi = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=Sirket50; User=sa; Pwd=123;";
        SqlDataAdapter adapter;
        DataTable dt;
        public Form3()
        {
            InitializeComponent();
        }
        void VerileriCek()
        {
            //tblPersonel tablosundaki dataları getirecek 
            sorguCumlesı = "SELECT * FROM tblPersonel";
            baglanti = new SqlConnection(baglantiCumlesi);
            adapter = new SqlDataAdapter(sorguCumlesı,baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvPersonel.DataSource = dt;
            dgvPersonel.Columns[0].Visible = false;
            dgvPersonel.Columns["IlceId"].Visible = false;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            VerileriCek();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
