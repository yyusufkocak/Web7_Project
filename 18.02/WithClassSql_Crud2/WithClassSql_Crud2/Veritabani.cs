using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithClassSql_Crud2
{
    public class Veritabani
    {
        SqlConnection baglanti;
        SqlConnection Baglan()
        {
            string dbName = "aHastane";
            string dUserName = "sa";
            string dPassword = "123";
            string baglantiCumlesi = $@"Server=DESKTOP-8M7D7GE\SQLEXPRESS;Database={dbName};User={dUserName};Pwd={dPassword};";
            baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            return baglanti;
        }
        void Kapat()
        {
            baglanti.Close();
        }
        public DataTable Listele(string sorguCümlesi)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sorguCümlesi,Baglan());
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
        public void Islem(string sorguCümlesi)
        {
            SqlCommand komut = new SqlCommand(sorguCümlesi,Baglan());
            komut.ExecuteNonQuery();
            Kapat();
        }
    }
}
