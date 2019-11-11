using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms08
{
    public partial class Form1 : Form
    {
        private int hamleSayisi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHedef_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Tebrikler {hamleSayisi} hamlede tıkladın."); //string interpolation
            MessageBox.Show(string.Format("Tebrikler {0} hamlede tıkladın.", hamleSayisi));  //string format
            hamleSayisi = 0;
            Text = hamleSayisi.ToString();
        }

        private void btnHedef_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            btnHedef.Left = rnd.Next(0, this.ClientSize.Width - btnHedef.Width);
            btnHedef.Top = rnd.Next(0, this.ClientSize.Height - btnHedef.Height);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            hamleSayisi++;
            Text = hamleSayisi.ToString();
        }
    }
}
