using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            pbGarfield.Left += rnd.Next(0, 15);
            pbPikachu.Left += rnd.Next(0, 30);

            // PictureBox'lardan herhangi birinin Right özelliği, bitiş panelinin solundan büyük veya eşit ise timer durdurulur.

            if (pbPikachu.Right >= pnlBitis.Left || pbGarfield.Right >= pnlBitis.Left)
            {
                timer1.Stop();
                string kazanan;
                if (pbPikachu.Right >= pbGarfield.Right)
                {
                    kazanan = "PIKACHU";
                }
                else
                {
                    kazanan = "GARFIELD";
                }
                //MessageBox.Show(string.Format("Kazanaaaaan {0} !!!", kazanan));

                DialogResult dr = MessageBox.Show(string.Format("Kazanaaaaan {0} !!! Yeniden başlamak istiyor musun?", kazanan), "Oyun Bitti!", MessageBoxButtons.YesNo);

                if (dr == DialogResult.No)
                {
                    return;
                }
                else
                {
                    //Form1 frm = new Form1();
                    //ShowDialog(frm);

                    Application.Restart();
                }
            }
        }
    }
}
