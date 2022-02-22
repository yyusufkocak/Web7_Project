using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Kisi
        {
            public string adSoyad;
            public short yas;
            public string cinsiyet;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Kisi yeniKisi = new Kisi();
            yeniKisi.adSoyad = "Engin";
            yeniKisi.yas = 78;
            yeniKisi.cinsiyet = "E";
        }
    }
}
