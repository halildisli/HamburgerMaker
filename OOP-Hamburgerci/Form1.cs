using OOP_Hamburgerci.Models;

namespace OOP_Hamburgerci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static List<Menu> menuler = new List<Menu>() // 9.1 burada Menu ctrl+. ya basýp using model i ekliyoruz.static yapmamýzýn nedeni diðer formlarda Form1.menuler. dediðimiz zaman gelmesi için.
        {
            new Menu{MenuAdi="Big King", MenuFiyati=50.75m},
            new Menu{MenuAdi="Double King Chicken", MenuFiyati=49.75m},
            new Menu{MenuAdi="Big Royal", MenuFiyati=55.75m},
            new Menu{MenuAdi="Chicken Royal", MenuFiyati=37.75m},
            new Menu{MenuAdi="Köfteburger", MenuFiyati=40.75m}

        };
        public static List<EkstraMalzeme> ekstralar = new List<EkstraMalzeme>
        {
            new EkstraMalzeme{EkstraAdi="Ketçap" , EkstraFiyati=1.00m},
            new EkstraMalzeme{EkstraAdi="Mayonez" , EkstraFiyati=1.00m},
            new EkstraMalzeme{EkstraAdi="Ranch Sos" , EkstraFiyati=2.00m},
            new EkstraMalzeme{EkstraAdi="BBQ Sos" , EkstraFiyati=2.00m},
            new EkstraMalzeme{EkstraAdi="Hardal Sos" , EkstraFiyati=2.00m}
        };
        public static List<Siparis> tumSiparisler = new List<Siparis>();//Form4 te de göreceðimiz listemiz. 
        public static List<Siparis> mevcutSiparisler = new List<Siparis>(); //Form1 de geçici olan listemiz.


        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Menu item in menuler) //11.1
            {
                cmbMenuler.Items.Add(item); //Tostring() override edildiði için ... Menü þeklinde gelecektir.
            }
            foreach (EkstraMalzeme item in ekstralar) //11.2
            {
                flpEkstralar.Controls.Add(new CheckBox() { Text = item.EkstraAdi, Tag = item }); //Runtime'da FLP nin içine CheckBox'lar ile ekstra malzemeleri control olarak ekledik.Checkbox lar seçildiðinde seçilen ekstra malzeme nesnesini yakalayabilmek için Tag propperty sinde ilgili ekstra malzeme nesnesini bir kopyasýný sakladýk.
            }
            foreach (Siparis item in mevcutSiparisler)
            {
                lbxSiparisler.Items.Add(item); // 11.3 ToString() metodu siparis class'ýnda override edildiði için eðer forn açýldýðýnda mevcut sipariþ var ise ListBox'a override edilen yerdeki formatla gelecektir.
            }
            rdoKucuk.Checked = true; // 11.4 Açýlýþta küçük boy seçili olsun.
            cmbMenuler.SelectedIndex = 0; //11.5 comboboxta ilk öge seçili gelsin.

            TutarHesapla(); //12 listede yer alan sipariþler olduðunda bu sipariþlerin toplam tutarýný hesaplamasý için ilgili metodu çaðýrdýk.
        }

        private decimal TutarHesapla() //12.1
        {
            decimal ToplamTutar = 0;
            for (int i = 0; i < lbxSiparisler.Items.Count; i++)
            {
                Siparis sýradakisiparis =(Siparis)lbxSiparisler.Items[i];
                ToplamTutar += sýradakisiparis.ToplamTutar;
            }
            lblToplamTutar.Text = ToplamTutar.ToString("C2");
            return ToplamTutar; //herhangi bir yerde metod çaðýrdýðýmýzda geriye deðer döndürebilmek için return ifadesini yazabiliriz.O sebeple dönüþ tipi de vod deðil toplamtutar'ýn tipi olan decimal olarak ayarlandý.
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e) //13
        {
            //sipariþin menüsü
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenusu =(Menu) cmbMenuler.SelectedItem;
            //siparisin boyutu
            if (rdoKucuk.Checked) //rdo.checked==true anlamýna gelir.
            {
                yeniSiparis.Boyutu = BoyutEnum.Kucuk;
            }
            else if (rdoOrta.Checked)
            {
                yeniSiparis.Boyutu = BoyutEnum.Orta;
            }
            else
            {
                yeniSiparis.Boyutu = BoyutEnum.Buyuk;
            }
            //siparisin ekstra malzemesi
            yeniSiparis.EkstraMalzemeleri = new List<EkstraMalzeme>();
            foreach (CheckBox kontrol in flpEkstralar.Controls)
            {
                if (kontrol.Checked)
                {
                    yeniSiparis.EkstraMalzemeleri.Add((EkstraMalzeme)kontrol.Tag); //FLP ninkontrollerinden her birinin Tag property sinde tutulan EkstraMalzeme nesnesinin bir kopyasýný aldýk ve Siparis nesnesini oluþturduðumuz EkstraMalzdmeleri listesine ekledik.
                }
            }
            //Sipariþin Adedi
            yeniSiparis.Adedi =Convert.ToInt32(nmrAdet.Value);
            yeniSiparis.Hesapla(); //eklenen yeni sipariþin tutarýný ilgili class taki (public olarak iþaretlenmiþ ) Hesapla() metodu ile hesaplýyoruz.

            mevcutSiparisler.Add(yeniSiparis);
            lbxSiparisler.Items.Add(yeniSiparis);

            TutarHesapla(); // ilgili label'da listede bulunan sipariþlerin toplam tutarýný hesaplamak için ilgili metodu çaðýrýyoruz.

            //TODO: metotlar.Temile() metodunuz tamamlayýnýz.
            Metotlar.Temizle(this.Controls); //bu formun controllerini, sipariþ eklendiðinde temizlesin.
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}