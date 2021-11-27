using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAKutuphane.Data
{
    public class KutuphaneYoneticisi
    {
        public KutuphaneYoneticisi()
        {
            //Kitaplar = new List<Kitap>(); //otomatik eklensin bir kitap diye aşağıdaki gibi yaptık boş olsun elle ekleyelim deseydik böyle bırakırdık.
            Kitaplar = new List<Kitap>()
            {
                new Kitap()
                {
                    Aciklama = "Biyografi Kitabı",
                    Ad = "Tesla",
                    BasimYili = DateTime.Now,
                    KitapTur = KitapTur.Biyografi,
                    SayfaSayisi = 100,
                    YazarAd = "Tesla"
                }
            };
        }
        public List<Kitap> Kitaplar { get; set; }
        public void KitapBagisi(Kitap kitap, int adet) 
        {
            for (int i = 1; i <= adet; i++)
            {
                Kitaplar.Add(kitap);
            }
        }
        public void KitapTeslimEtme (Kitap kitap) 
        {
            //Teslim ederken oduncalinmaTarihi null yapılabilir.
            Kitaplar.Add(kitap);
        }
        public void KitapImhaEt(Kitap kitap)
        {
            Kitaplar.Remove(kitap);
        }

    }
}
