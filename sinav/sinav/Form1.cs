using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMiktar_Click(object sender, EventArgs e)
        {
            double abdDolar = 17, miktar = 1,hesapla=0;
            abdDolar = Convert.ToDouble(txtAbdDlr.Text);
            miktar = Convert.ToDouble(txtMiktar.Text);
            hesapla = (abdDolar * miktar);
            lblTlTutar.Text="TLTutariniz: "+hesapla.ToString();
        }
    }
}
