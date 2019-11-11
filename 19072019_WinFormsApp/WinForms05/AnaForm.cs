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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnArkaRenkDegistir_Click(object sender, EventArgs e)
        {
            //2.YOL - AnaForm'dan açılan ikinci formun class'ında yeni bir public properyi tanımlayarak
            //AnaForm'a geçirmek istediğimiz değeribu public property 
            //aracılığı ile ikinci formdan AnaForm'a taşırız.

            //AnaForm için yeni instance oluşturup, açılacak forma parametre olarak gönderirsek,
            //o an için aktif olan AnaForm instance'ını değil, yepyeni bir instance yollamış oluruz.

            //AnaForm frm19 = new AnaForm();
            //frm19.BackColor = Color.Aqua;
            //frm19.Text = "MAŞALLAH ÇOK ZEKİSİNİZ.";
            //frm19.Show();
            //RenkDegistirenForm frm = new RenkDegistirenForm(frm19);

            //1.YOL - AnaFor'un açılacak diğer forma constructer aracılığı ile referance olarak geçilmesi 

            //Açılan forma this parametresi yollamak, o an aktif olan instance'ı
            //(yani current instance'ı) referance vermiş oluruz.
            //Yeni açılacak formun constructer'ını da buna göre düzenlemeliyiz.
            RenkDegistirenForm frm = new RenkDegistirenForm(this);
            frm.ShowDialog();
            //this.BackColor = frm.newColor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RenkDegistirenForm frm = new RenkDegistirenForm(this);
            frm.ShowDialog();

            this.BackColor = frm.YeniRengiAl(BackColor);
        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10000;
            //timer ile çalıştığımızda alt satır açılmalı
            timer1.Start();
        }
    }
}