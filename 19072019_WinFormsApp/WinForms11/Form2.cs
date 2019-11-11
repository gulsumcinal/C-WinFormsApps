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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" && txtAd.Text == "" && txtSoyad.Text == "")
                MessageBox.Show("Lütfen eklemek istediğiniz değerleri giriniz");
            else
            {
                listBox1.ValueMember = txtId.Text;
                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                listBox1.DisplayMember = ad + " " + soyad;
                listBox1.Items.Add(listBox1.ValueMember + " " + listBox1.DisplayMember);
            }
            txtId.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItems.Count != -1)
            {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.");
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                txtId.Text = listBox1.ValueMember;
                txtAd.Text = listBox1.DisplayMember.Substring(0, listBox1.DisplayMember.IndexOf(" "));
                txtSoyad.Text = listBox1.DisplayMember.Substring(listBox1.DisplayMember.IndexOf(" "), listBox1.DisplayMember.Length);
            }
        }
    }
}
