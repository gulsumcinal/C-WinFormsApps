using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" && txtAd.Text == "" && txtSoyad.Text == "")
                MessageBox.Show("Lütfen eklemek istediğiniz değerleri giriniz");
            else
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = txtId.Text;
                lvi.SubItems.Add(txtAd.Text);
                lvi.SubItems.Add(txtSoyad.Text);

                listView1.Items.Add(lvi);
            }
            txtId.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = txtId.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txtAd.Text;
                listView1.SelectedItems[0].SubItems[2].Text = txtSoyad.Text;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].Remove();

                txtId.Clear();
                txtAd.Clear();
                txtSoyad.Clear();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtId.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }
        }
    }
}
