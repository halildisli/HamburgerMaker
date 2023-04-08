using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci.Models
{
    public static class Metotlar //8 burada instance almadan metotları çağıracağımızdan dolayı static oluşturduk.
    {
        public static void Temizle(Control.ControlCollection gelenKontrolller) //8.1 eğer bu control textbox ise içine temizle, eğer bu control combobox ise sıfırıncı combobox ı işaretle gibi işlem yapacak.
        {
            foreach (Control item in gelenKontrolller) 
            {

            }
        }
    }
}
