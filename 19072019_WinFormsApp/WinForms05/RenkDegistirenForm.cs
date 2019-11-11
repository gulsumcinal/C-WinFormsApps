using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms05
{
    public partial class RenkDegistirenForm : Form
    {
        //1.YOL içintanımlandı
        public AnaForm BaglananAnaForm;

        //2.YOL içintanımlandı
        public Color newColor { get; private set; }

        public RenkDegistirenForm(AnaForm p)
        {
            InitializeComponent();
            BaglananAnaForm = p;
        }
        public RenkDegistirenForm()
        {
            InitializeComponent();
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            //1.YOL için yazıldı (AnaForm'a ikinci formdan ulaşılması


            BaglananAnaForm.BackColor = YeniRengiAl(BaglananAnaForm.BackColor);

            //2.YOL için yazıldı ( Anaform'a, ikinci formdan public property ile değer gönderilmesi.

            //Color oldColor = Color.LightGray;
            //newColor = YeniRengiAl(OncekiRek: oldColor);

            Hide();
        }
        public Color RenkKodunaCevir(string RenkMetni)
        {
            switch (RenkMetni.ToLower())
            {
                case "kırmızı":
                    return Color.Red;
                case "mavi":
                    return Color.Blue;
                case "yeşil":
                    return Color.Green;
                default:
                    throw new NotImplementedException();
            }
        }
        public Color YeniRengiAl(Color OncekiRenk)
        {
            try
            {
                return RenkKodunaCevir(txtRenkGirisi.Text);
            }
            catch
            {
                MessageBox.Show("Girilen renk tanımlı değil. Önceki renk ");
                return OncekiRenk;
            }
        }
    }
}