using OOP_Hamburgerci.Models;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Menu yeniMenu = new Menu(); //10.1 burada da Menu yazdığımız zaman menu ye tıklayıp ctrl+. ya basıp using yapmamız gerekli
            yeniMenu.MenuAdi = txtMenuAdı.Text;
            yeniMenu.MenuFiyati = nmrMenuFiyati.Value;

            Form1.menuler.Add(yeniMenu);

        }
    }
}
