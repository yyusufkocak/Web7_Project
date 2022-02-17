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
    public partial class Form4 : Form
    {
        Random rnd = new Random();
        int sayi = 0;
        byte oyunTuru = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi = rnd.Next(1,100);
            lblSayi.Text = sayi.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //MessageBox.Show(timer1.Enabled.ToString());
        }

        void KontrolEt()
        {
            if (rdbCift.Checked==true)
            {
                if (sayi % 2 == 0)
                {
                    lblSonuc.Text = "Bildin";
                    lstKazananlar.Items.Add(sayi);
                    if (lstKazananlar.Items.Count == 3)
                    {
                        lblSonuc.Text = "Tebrikler 3 kez bildin, 100 wissenCoin kazandın!";
                    }
                }
                else
                {
                    lblSonuc.Text = "Bu sefer olmadı tekrar denemek için kredi satın al";
                }
            }
            else
            {

            }
           
        }

        private void lblSayi_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Stop();
                KontrolEt();
            }
            else
            {
                timer1.Start();
            }
        }

        private void rdbCift_CheckedChanged(object sender, EventArgs e)
        {
            oyunTuru = 0;
        }

        private void rdbTek_CheckedChanged(object sender, EventArgs e)
        {
            oyunTuru = 1;

        }
    }
}
