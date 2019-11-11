using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRenkAyarla_Click(object sender, EventArgs e)
        {
            DialogResult btnRenkAyarla;
            btnRenkAyarla = colorDialog1.ShowDialog();
            txtAdi.ForeColor = colorDialog1.Color;
            txtSoyadi.ForeColor = colorDialog1.Color;
            txtAciklama.ForeColor = colorDialog1.Color;
        }

        private void btnFormAyarla_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            txtAdi.Font = fontDialog1.Font;
            txtSoyadi.Font = fontDialog1.Font;
            txtAciklama.Font = fontDialog1.Font;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtAciklama.Clear();

            txtAdi.Font = DefaultFont;
            txtAdi.ForeColor = DefaultForeColor;
            txtSoyadi.Font = DefaultFont;
            txtSoyadi.ForeColor = DefaultForeColor;
            txtAciklama.Font = DefaultFont;
            txtAciklama.ForeColor = DefaultForeColor;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.label4.Text = txtAdi.Text;
            frm.label5.Text = txtSoyadi.Text;
            frm.label6.Text = txtAciklama.Text;
            frm.label4.ForeColor = txtAdi.ForeColor;
            frm.label5.ForeColor = txtSoyadi.ForeColor;
            frm.label6.ForeColor = txtAciklama.ForeColor;
            frm.label4.Font = txtAdi.Font;
            frm.label5.Font = txtSoyadi.Font;
            frm.label6.Font = txtAciklama.Font;
            frm.Show();
        }
    }
}