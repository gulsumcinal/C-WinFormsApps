using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms04
{
    public partial class Form1 : Form
    {
        //Project4 : Event Orders for Mouse movements

        public string strButtonTemizleText;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string s)
        {
            InitializeComponent();
            btnTemizle.Text = s;
        }

        private void pnlOlay_MouseDown(object sender, MouseEventArgs e)
        {
            //Mouse Down evet'i gerçekleştiğinde bu method tetiklenecek
            //Bu nilgi Form1.Designer.cs dosyasında belirtiliyor.
            //Bu method kendi içerisinde Yaz methodunu çağırıyor.
            //Yaz method'u tek parametre alıyor ( bir adet string tipinde parametre alıyor)
            Yaz("MouseDown");
            //Yaz("MouseDown" + e.Button.ToString());
        }
        private void Yaz(string EventAdi)
        {
            lstBoxOlay.Items.Add(string.Format("{1} {0}", EventAdi, DateTime.Now));
            this.lstBoxOlay.SelectedIndex = this.lstBoxOlay.Items.Count - 1;
        }

        private void pnlOlay_MouseEnter(object sender, EventArgs e)
        {
            Yaz("MouseEnter");
        }

        private void pnlOlay_MouseHover(object sender, EventArgs e)
        {
            Yaz("MouseHover");
        }

        private void pnlOlay_MouseLeave(object sender, EventArgs e)
        {
            Yaz("MouseLeave");
            
        }

        private void pnlOlay_MouseMove(object sender, MouseEventArgs e)
        {
            Yaz("MouseMove");
        }

        private void pnlOlay_MouseUp(object sender, MouseEventArgs e)
        {
            Yaz("MouseUp");
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstBoxOlay.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //btnTemizle.Text = strButtonTemizleText;
        }
    }
}
