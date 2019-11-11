using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms02
{
    public partial class Form1 : Form
    {
        //Project2 : Textbox'a yalnız sayı ya da yalnız karakter girme.
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_YalnizKarakter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);

            if (e.KeyChar == '1')
            {
                txt_YalnizKarakter.Text += "bir";
            }
            if (e.KeyChar == 'a')
            {
                txt_YalnizKarakter.Text += "a'ya bastınız.";
            }
            
            //((TextBox)sender).Text += "bir";
        }

        private void txt_YalnizSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txt_CharacterCasingToUpper_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
            txt_CharacterCasingToUpper.CharacterCasing = CharacterCasing.Upper;
        }

        private void txt_CharacterToLower_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
            txt_CharacterToLower.CharacterCasing = CharacterCasing.Lower;
        }

        private void txt_YalnizKarakter_MouseEnter(object sender, EventArgs e)
        {
            //defaultBackColor = txt_YalnizKarakter.BackColor;
            txt_YalnizKarakter.BackColor = Color.DarkRed;
            //txt_YalnizKarakter.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void txt_YalnizKarakter_MouseLeave(object sender, EventArgs e)
        {
            txt_YalnizKarakter.BackColor = DefaultBackColor;
        }
    }
}
