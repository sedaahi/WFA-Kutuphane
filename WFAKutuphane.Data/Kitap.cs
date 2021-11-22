using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAKutuphane.Data
{
    public class Kitap

    {
        public Kitap()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public DateTime BasimYili { get; set; }
        public KitapTur KitapTur { get; set; }
        public string YazarAd { get; set; }
        public int SayfaSayisi { get; set; }
        public string Aciklama { get; set; }
        public DateTime? AlinmaTarihi { get; set; } = DateTime.Now;
    }
}
