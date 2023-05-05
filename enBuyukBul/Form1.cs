using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enBuyukBul
{
    public partial class FormEnBüyükSayi : Form
    {
        public FormEnBüyükSayi()
        {
            InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3;
            sayi1 = Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);
            sayi3 = Convert.ToInt32(txtSayi3.Text);

            if (sayi1 >= sayi2 && sayi1 >= sayi3)
            {
                lblSonuc.Text = "En Büyük Sayı : " + sayi1;
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                lblSonuc.Text = "En Büyük Sayı : " + sayi2;
            }
            else
            {
                lblSonuc.Text = "En Büyük Sayı : " + sayi3;
            }
        }
    }
}
