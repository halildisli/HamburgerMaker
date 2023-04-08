using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public partial class MyMDIForm : Form
    {
        public MyMDIForm()
        {
            InitializeComponent();
        }
        void ChildForm(Form childForm)//1
        {
            this.Width = childForm.Width + 25;//1.1
            this.Height = childForm.Height + 70;//1.2

            bool durum = false;//1.3

            foreach (Form form in MdiChildren)//2 
            {
                if (form.Text==childForm.Text)
                {
                    durum = true;
                    form.Activate();//2.1 eğer açılan menuler kısmı tekrar açılırsa var olan menu ksımını aktive etmesini sağlayacak.
                }
                else
                {
                    form.Close();//2.2 eğer farklı bir menuye tıklandığında o anda var olan menuyu kapatmasını sağlayacak.
                }
            }
            if (durum==false) //3
            {
                childForm.MdiParent = this;
                childForm.Show();

            }
            //5 formlarda kenarlar gözükmesin diye her formun propertylerinden FormBorderStyle ı none ,ve tam olarak yerleşebilmesi için startPosition ı manual olarak işaretlememiz gerekli.
        }

        private void tsmSiparisOlustur_Click(object sender, EventArgs e)
        {
            ChildForm(new Form1());//4 menulere tıkladığımızda açılmasını sağlayacak.
        }

        private void tsmTumSiparisler_Click(object sender, EventArgs e)
        {
            ChildForm(new Form4());//4.1
        }

        

        private void tsmEkstraEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new Form3());//4.2
        }

        private void tsmMenuEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new Form2());//4.3
        }
        private void ürünYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
