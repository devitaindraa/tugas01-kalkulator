using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Penambahan(int nilaiA, int nilaiB)
        {
            return nilaiA + nilaiB;
        }

        private int Pengurangan(int nilaiA, int nilaiB)
        {
            return nilaiA - nilaiB;
        }

        private int Perkalian(int nilaiA, int nilaiB)
        {
            return nilaiA * nilaiB;
        }

        private int Pembagian(int nilaiA, int nilaiB)
        {
            return nilaiA / nilaiB;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            double nilaiA, nilaiB, hasil;

            if (cmbOperasi.SelectedIndex == 0)
            {
                nilaiA = Double.Parse(txtNilaiA.Text);
                nilaiB = Double.Parse(txtNilaiB.Text);
                hasil = nilaiA + nilaiB;
                txtHasil.Text = hasil.ToString();
            }
            else if (cmbOperasi.SelectedIndex == 1)
            {
                nilaiA = Double.Parse(txtNilaiA.Text);
                nilaiB = Double.Parse(txtNilaiB.Text);
                hasil = nilaiA - nilaiB;
                txtHasil.Text = hasil.ToString();
            }
            else if (cmbOperasi.SelectedIndex == 2)
            {
                nilaiA = Double.Parse(txtNilaiA.Text);
                nilaiB = Double.Parse(txtNilaiB.Text);
                hasil = nilaiA * nilaiB;
                txtHasil.Text = hasil.ToString();
            }
            else if (cmbOperasi.SelectedIndex == 3)
            {
                nilaiA = Double.Parse(txtNilaiA.Text);
                nilaiB = Double.Parse(txtNilaiB.Text);
                hasil = nilaiA / nilaiB;
                txtHasil.Text = hasil.ToString();
            }
        }
    }
}
