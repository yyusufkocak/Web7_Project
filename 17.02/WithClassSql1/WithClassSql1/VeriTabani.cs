using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithClassSql1
{
    class VeriTabani
    {
        SqlConnection baglanti;
        string sorguCümlesi;
        SqlCommand komut;

        //Kodlarımızı (metotlar,propertyler...) burada yazacağız.
        public SqlConnection Baglan()
        {
            string baglantiCumlesi = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=aHastane; User=sa;Pwd=123";
            baglanti = new SqlConnection(baglantiCumlesi);

            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();

            }

            return baglanti;
        }
        public void Kapat()
        {
            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Close();

            }
        }
        public DataTable HastalariListele()
        {
            sorguCümlesi = $"SELECT * FROM tblHastalar";
            SqlDataAdapter adapter = new SqlDataAdapter(sorguCümlesi,Baglan());
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
        public void Ekle(string tcNo,string ad, string soyad,string cinsiyet, string adres, string tel, string mail)
        {
            sorguCümlesi = $"INSERT INTO tblHastalar VALUES ('{tcNo}','{ad}','{soyad}','{cinsiyet}','{adres}','{tel}','{mail}')";
            komut = new SqlCommand(sorguCümlesi,Baglan());
            komut.ExecuteNonQuery();
            Kapat();
        }
        public void Guncelle(string id,string tcNo, string ad, string soyad, string cinsiyet, string adres, string tel, string mail)
        {
            sorguCümlesi = 
                $"UPDATE tblHastalar SET  TcNo='{tcNo}',ad='{ad}'," +
                $"soyad='{soyad}',cinsiyet='{cinsiyet}',adres='{adres}'," +
                $"telefon='{tel}',mail='{mail}' WHERE ID='{id}' ";
            komut = new SqlCommand(sorguCümlesi, Baglan());
            komut.ExecuteNonQuery();
            Kapat();         
        }
        public void Sil(string id)
        {
            sorguCümlesi =
              $"DELETE FROM tblHastalar ID='{id}'";
            komut = new SqlCommand(sorguCümlesi, Baglan());
            komut.ExecuteNonQuery();
            Kapat();
        }
    }
}
