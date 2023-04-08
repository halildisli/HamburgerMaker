using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci.Models
{
    public class Siparis //8
    {
        public Menu SeciliMenusu { get; set; }
        public List<EkstraMalzeme> EkstraMalzemeleri { get; set; } //8.1 ekstra malzeme birden fazla seçilebileceği için list olarak tanımladık.
        public BoyutEnum Boyutu { get; set; }
        public int Adedi { get; set; }
        public decimal ToplamTutar { get; set; }
        public void Hesapla() //8.2 bir siparişinin toplam tutarını hesaplayacak.
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenusu.MenuFiyati;

            switch (Boyutu) //8.3 seçilen boyut üzerinden fiyat artışı yapma
            {
                
                case BoyutEnum.Orta:
                    ToplamTutar += ToplamTutar * 0.1m;
                    //ToplamTutar = ToplamTutar+ ToplamTutar * 0.1m;
                    break;
                case BoyutEnum.Buyuk:
                    ToplamTutar += ToplamTutar * 0.2m;
                    break;                
                    break;
            }

            ToplamTutar *= Adedi; //8.4 burada önce menünün kaç adet alındığı ile çarpılıp sonra aşağıda ekstra malzemelerin fiyatlarını eklemek istedik.Eğer menü kadar ekstra malzeme alınacaksa foreach kısmı bi yukarıda tanımlamamız gerekli olacaktı.

            foreach (EkstraMalzeme item in EkstraMalzemeleri)
            {
                ToplamTutar += item.EkstraFiyati;
            }
        }
        public override string ToString() // 8.5 sipariş ekle tıkladıktan sonra listbox a seçilen müneleri yazdırma
        {
            if (EkstraMalzemeleri.Count<1) //8.6 ekstra malzemesi yoksa 
            {
                return String.Format($"{SeciliMenusu.MenuAdi} Menü x {Adedi} Adet, {Boyutu} Boy, Toplam: {ToplamTutar.ToString("C2")}");
            }
            else
            {
                string ekstraMalzemeler = null;
                foreach (EkstraMalzeme item in EkstraMalzemeleri)
                {
                    ekstraMalzemeler += item.EkstraAdi + " ";                                     
                }
                // "Ketçap,Mayonez,Hardal," gibi birşey oluşacağından dolayı sondaki virgülü kaldırmak için;
                ekstraMalzemeler = ekstraMalzemeler.Trim(',');
                return String.Format($"{SeciliMenusu.MenuAdi} Menü x {Adedi} Adet, {Boyutu} Boy,({ekstraMalzemeler}) Toplam: {ToplamTutar.ToString("C2")}");
            }
        }


    }
}
