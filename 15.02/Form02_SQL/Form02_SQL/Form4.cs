﻿using System;
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
    public partial class Form4 : Form
    {
        int sayac = 1;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lblMesaj.Text = "Lütfen giriş yapınız.";
        }
        void Login()
        {
            string uName = txtUserName.Text;
            string uPass = txtPassword.Text;
            string baglantiCumlesi = @"Server=DESKTOP-8M7D7GE\SQLEXPRESS; Database=Sirket50; User=sa;Pwd=123";
            string sorguCumlesi = $"SELECT * FROM tblUsers WHERE Username='{uName}' and UserPass='{uPass}'";
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            SqlCommand komut = new SqlCommand(sorguCumlesi,baglanti);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                lblMesaj.Text = "Kullanıcı Girişi Başarılı.";
                timer2.Start();

            }
            else
            {
                lblMesaj.Text = "Geçersiz Giriş!";
            }
            baglanti.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
            
        }

        void PBar()
        {
            lblMesaj.Text += ".";
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac<=5)
            {
                sayac++;
                PBar();
            }
            else
            {
                timer1.Stop();
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          
            timer2.Stop();
            lblMesaj.Text = "Yönlendirliyorsunuz";
            timer1.Start();
        }
    }
}
