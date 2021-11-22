using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAKutuphane.Data
{
    public class Kullanici
    {
        public Kullanici()
        {
            Id = Guid.NewGuid();
            OduncAlinanKitaplar = new List<Kitap>();
        }
        public Guid Id { get; set; }
        public string AdSoyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public List<Kitap> OduncAlinanKitaplar { get; set; } = new List<Kitap> { };

    }
}
