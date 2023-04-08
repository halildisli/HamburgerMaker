using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci.Models
{
    public class Menu //5
    {
        public string MenuAdi { get; set; }
        public decimal MenuFiyati { get; set; }

        public override string ToString() //5.1 burada örnek olarak Whooper siparişi verdiğimde "Whooper menü" şeklinde gelmesini istediğim için override ettik.
        {
            return MenuAdi + " Menü";
        }
    }
}
