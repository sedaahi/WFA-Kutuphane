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
            Kitaplar = new List<Kitap>();
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

    }
}
