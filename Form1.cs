using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banka_kredileri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int anapara = Convert.ToInt32(txtAnapara.Text);
            float faizoranı = Convert.ToInt32(txtFaizoranı.Text);
            int vade = Convert.ToInt32(txtVade.Text);
            float hesapla = faizoranı = (anapara * faizoranı * vade) / 360;
            btnHesapla.Text = hesapla.ToString();
        }
    }
}
