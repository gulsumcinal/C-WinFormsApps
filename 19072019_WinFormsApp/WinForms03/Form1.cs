using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms03
{
    public partial class Form1 : Form
    {
        //Project3 : Event otder for Keys
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBoxOlay_KeyDown(object sender, KeyEventArgs e)
        {
            Yaz("KeyDown oldu.");
        }
        private void Yaz(string OlayAdi)
        {
            //String Concatenation kullanarak yapalım
            string str = DateTime.Now + " " + OlayAdi;
            lstBoxOlay.Items.Add(str);

            //String Interpolation kullanarak yapalım
            //string s2 = $"{DateTime.Now} {OlayAdi,}";
            //lstBoxOlay.Items.Add(s2);

            //String class'ının Format method'unu kullanarak yapalım
            //lstBoxOlay.Items.Add(string.Format(OlayAdi + DateTime.Now));
        }
        private void txtBoxOlay_KeyPress(object sender, KeyPressEventArgs e)
        {
            Yaz("KeyPress oldu.");
        }

        private void txtBoxOlay_KeyUp(object sender, KeyEventArgs e)
        {
            Yaz("KeyUp oldu.");
        }

        private void btnTemizle_click(object sender, EventArgs e)
        {
            lstBoxOlay.Items.Clear();
        }
    }
}
