using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms01
{
    public partial class FrmDonguler : Form
    {
        //Project1 : Döngüler
        int[] dizi = { 10, 20, 25, 28, 34 };
        int toplam;
        public FrmDonguler()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            //Temizle();
            //ForDongu();

            Temizle();

            listBoxFor.Items.Clear();

            for (int i = 0; i < dizi.Length; i++)
            {
                toplam = toplam + dizi[i];
                //Toplam += Dizi[i];
                listBoxFor.Items.Add(dizi[i]);
            }
            listBoxFor.Items.Add("Toplam Değer = " + toplam);
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            Temizle();

            listBoxForeach.Items.Clear();

            for (int i = 0; i < dizi.Length; i++)
            {
                toplam = toplam + dizi[i];
                //Toplam += Dizi[i];
                listBoxForeach.Items.Add(dizi[i]);
            }
            listBoxForeach.Items.Add("Toplam Değer = " + toplam);
        }
        public void Temizle()
        {
            toplam = 0;
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int i = 0;
            Temizle();
            while (dizi.Length > i)
            {
                listBoxWhile.Items.Add(dizi[i]);
                toplam += dizi[i];
                i++;
            }
            listBoxWhile.Items.Add("Toplam = " + toplam);
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            Temizle();

            listBoxDoWhile.Items.Clear();
            int i = 0;
            do
            {
                listBoxDoWhile.Items.Add(dizi[i]);
                toplam += dizi[i];
                i++;
            }
            while (dizi.Length > i);
            {
                listBoxDoWhile.Items.Add("Toplam = " + toplam);
            }
        }

        private void btnEnum_Click(object sender, EventArgs e)
        {
            Temizle();
            IEnumDongu();
        }
        public void IEnumDongu()
        {
            listBoxIEnum.Items.Clear();
            IEnumerator IEnum = dizi.GetEnumerator();
            while (IEnum.MoveNext())
            {
                listBoxIEnum.Items.Add(IEnum.Current);
                //toplam += dizi[i];
                //i++;
                toplam += (int)IEnum.Current;
            }
            listBoxIEnum.Items.Add("Toplam = " + toplam);
        }

        private void FrmDonguler_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba ilk form uygulamama hoşgeldiniz! :)");
        }
    }   
}
