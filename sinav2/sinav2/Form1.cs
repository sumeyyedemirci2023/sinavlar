using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbTaksitSay_Scroll(object sender, EventArgs e)
        {
            double adet = 0, bFiyat = 50, taksitSay = 6,hesapla;
            adet=Convert.ToDouble(txtAdet.Text);
            bFiyat=Convert.ToDouble(txtBfiyat.Text);
            hesapla = (adet * bFiyat) / taksitSay;
            lblTakTut.Text = "Taksit Tutarınız: " + hesapla.ToString();

        }

        private void lblTakTut_Click(object sender, EventArgs e)
        {
           // double adet = 0, bFiyat = 50, taksitSay = 6, hesapla;
           // adet = Convert.ToDouble(txtAdet.Text);
           // bFiyat = Convert.ToDouble(txtBfiyat.Text);
            //taksitSay = Convert.ToDouble(tbTaksitSay.Text);
           // hesapla = (adet * bFiyat) / taksitSay;
            //lblTakTut.Text = "Taksit Tutarınız: " + hesapla.ToString
        }
    }
}
