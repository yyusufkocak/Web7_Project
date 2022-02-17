using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Form02_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = "";
                baglanti.ConnectionString = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=Sirket50; User=sa; Pwd=123";
                //üstteki satır Sql Server Authentication için kullanılır
                //baglanti.ConnectionString = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=Sirket50; Trusted_Connection=true";
                //üstteki satır windows Authentication için kullanılır
                baglanti.Open();

                baglanti.Close();
                MessageBox.Show("Bağlantı başarılı");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Olmadı Yar, su testisine dolmadı yar");
                //throw;
                MessageBox.Show(ex.Message);
            }

        }
    }
}
