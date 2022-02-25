using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithClassSql_Crud2
{
    class Veritabani
    {
        private string sorguCumlesi;

        public string SorguCUmlesi
        {
            get { return sorguCumlesi; }
            set { sorguCumlesi = value; }
        }
        public Veritabani()
        {
            baglanti = Baglan();
        }
        public Veritabani(string sorguCumlesi)
        {
            baglanti = Baglan();
            this.sorguCumlesi = sorguCumlesi;
        }

        SqlConnection baglanti;
        SqlConnection Baglan()
        {
            string dbServer = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS";
            string dbName = "aKutuphane";
            string dUserName = "sa";
            string dPassword = "123";
            string baglantiCumlesi = $@"{dbServer};Database={dbName};User={dUserName};Pwd={dPassword};";
            baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            return baglanti;
        }
        void Kapat()
        {
            baglanti.Close();
        }
        public DataTable Listele()
        {

            SqlDataAdapter adapter = new SqlDataAdapter(sorguCumlesi, Baglan());

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
        public void Islem(string sorguCümlesi)
        {
            SqlCommand komut = new SqlCommand(sorguCümlesi, baglanti);
            komut.ExecuteNonQuery();
            Kapat();
           
            
        }
        public string TableName { get; set; }
        /// <summary>
        /// Bu kullanım şekli, SELECT işlemi içindir.
        /// </summary>
        public void Sorgu()
        //Bu overload
        {
            sorguCumlesi = $"SELECT * FROM {TableName}";
        }
        /// <summary>
        ///  BU kullanım şekli, DELETE işlemi içindir.
        /// </summary>
        /// <param name="kosul"></param>
        public void Sorgu(string condition)
        {
            sorguCumlesi = $"DELETE FROM {TableName} WHERE {condition}";
            Islem(sorguCumlesi);

        }
        /// <summary>
        /// Bu Kullanım şekli, GUNCELLEME işlemi içindir.
        /// </summary>
        /// <param name="columnNames"></param>
        /// <param name="columnValues"></param>
        /// <param name="condition"></param>
        public void Sorgu(List<string> columnNames, List<string> columnValues, string condition)
        {
            string text = "";
            for (int i = 0; i < columnNames.Count; i++)
            {
                text += columnNames[i] + "='" + columnValues[i] + "',";
            }
            text = text.Substring(0, text.Length - 1);
            sorguCumlesi =
                $"UPDATE {TableName} SET {text} WHERE {condition}";
            Islem(sorguCumlesi);
        }
        public void Sorgu(List<string> columnNames, List<string> columnValues) 
        {
            string text = "";
            string text2 = "";
            for (int i = 0; i < columnNames.Count; i++)
            {
                text += columnNames[i]+ ",";
                text2 += columnNames[i] + "='" + columnValues[i] + "',";

            }
            text = text.Substring(0, text.Length - 1);
            sorguCumlesi =
                $"INSERT INTO {TableName}({text})VALUES ({text2}) ";
            Islem(sorguCumlesi);

        }

    }
}
