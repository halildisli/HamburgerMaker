using OOP_Hamburgerci.Models;

namespace OOP_Hamburgerci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static List<Menu> menuler = new List<Menu>() // 9.1 burada Menu ctrl+. ya bas�p using model i ekliyoruz.static yapmam�z�n nedeni di�er formlarda Form1.menuler. dedi�imiz zaman gelmesi i�in.
        {
            new Menu{MenuAdi="Big King", MenuFiyati=50.75m},
            new Menu{MenuAdi="Double King Chicken", MenuFiyati=49.75m},
            new Menu{MenuAdi="Big Royal", MenuFiyati=55.75m},
            new Menu{MenuAdi="Chicken Royal", MenuFiyati=37.75m},
            new Menu{MenuAdi="K�fteburger", MenuFiyati=40.75m}

        };
        public static List<EkstraMalzeme> ekstralar = new List<EkstraMalzeme>
        {
            new EkstraMalzeme{EkstraAdi="Ket�ap" , EkstraFiyati=1.00m},
            new EkstraMalzeme{EkstraAdi="Mayonez" , EkstraFiyati=1.00m},
            new EkstraMalzeme{EkstraAdi="Ranch Sos" , EkstraFiyati=2.00m},
            new EkstraMalzeme{EkstraAdi="BBQ Sos" , EkstraFiyati=2.00m},
            new EkstraMalzeme{EkstraAdi="Hardal Sos" , EkstraFiyati=2.00m}
        };
        public static List<Siparis> tumSiparisler = new List<Siparis>();//Form4 te de g�rece�imiz listemiz. 
        public static List<Siparis> mevcutSiparisler = new List<Siparis>(); //Form1 de ge�ici olan listemiz.


        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Menu item in menuler) //11.1
            {
                cmbMenuler.Items.Add(item); //Tostring() override edildi�i i�in ... Men� �eklinde gelecektir.
            }
            foreach (EkstraMalzeme item in ekstralar) //11.2
            {
                flpEkstralar.Controls.Add(new CheckBox() { Text = item.EkstraAdi, Tag = item }); //Runtime'da FLP nin i�ine CheckBox'lar ile ekstra malzemeleri control olarak ekledik.Checkbox lar se�ildi�inde se�ilen ekstra malzeme nesnesini yakalayabilmek i�in Tag propperty sinde ilgili ekstra malzeme nesnesini bir kopyas�n� saklad�k.
            }
            foreach (Siparis item in mevcutSiparisler)
            {
                lbxSiparisler.Items.Add(item); // 11.3 ToString() metodu siparis class'�nda override edildi�i i�in e�er forn a��ld���nda mevcut sipari� var ise ListBox'a override edilen yerdeki formatla gelecektir.
            }
            rdoKucuk.Checked = true; // 11.4 A��l��ta k���k boy se�ili olsun.
            cmbMenuler.SelectedIndex = 0; //11.5 comboboxta ilk �ge se�ili gelsin.

            TutarHesapla(); //12 listede yer alan sipari�ler oldu�unda bu sipari�lerin toplam tutar�n� hesaplamas� i�in ilgili metodu �a��rd�k.
        }

        private decimal TutarHesapla() //12.1
        {
            decimal ToplamTutar = 0;
            for (int i = 0; i < lbxSiparisler.Items.Count; i++)
            {
                Siparis s�radakisiparis =(Siparis)lbxSiparisler.Items[i];
                ToplamTutar += s�radakisiparis.ToplamTutar;
            }
            lblToplamTutar.Text = ToplamTutar.ToString("C2");
            return ToplamTutar; //herhangi bir yerde metod �a��rd���m�zda geriye de�er d�nd�rebilmek i�in return ifadesini yazabiliriz.O sebeple d�n�� tipi de vod de�il toplamtutar'�n tipi olan decimal olarak ayarland�.
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e) //13
        {
            //sipari�in men�s�
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenusu =(Menu) cmbMenuler.SelectedItem;
            //siparisin boyutu
            if (rdoKucuk.Checked) //rdo.checked==true anlam�na gelir.
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
                    yeniSiparis.EkstraMalzemeleri.Add((EkstraMalzeme)kontrol.Tag); //FLP ninkontrollerinden her birinin Tag property sinde tutulan EkstraMalzeme nesnesinin bir kopyas�n� ald�k ve Siparis nesnesini olu�turdu�umuz EkstraMalzdmeleri listesine ekledik.
                }
            }
            //Sipari�in Adedi
            yeniSiparis.Adedi =Convert.ToInt32(nmrAdet.Value);
            yeniSiparis.Hesapla(); //eklenen yeni sipari�in tutar�n� ilgili class taki (public olarak i�aretlenmi� ) Hesapla() metodu ile hesapl�yoruz.

            mevcutSiparisler.Add(yeniSiparis);
            lbxSiparisler.Items.Add(yeniSiparis);

            TutarHesapla(); // ilgili label'da listede bulunan sipari�lerin toplam tutar�n� hesaplamak i�in ilgili metodu �a��r�yoruz.

            //TODO: metotlar.Temile() metodunuz tamamlay�n�z.
            Metotlar.Temizle(this.Controls); //bu formun controllerini, sipari� eklendi�inde temizlesin.
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}