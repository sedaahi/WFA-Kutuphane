using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAKutuphane.Data;

namespace WFAKutuphane
{
    public partial class HesabimForm : Form
    {
        private readonly Kullanici _kullanici;
        private readonly KutuphaneYoneticisi _kutuphaneYoneticisi;

        public HesabimForm(Kullanici kullanici, KutuphaneYoneticisi kutuphaneYoneticisi)
        {
            InitializeComponent();
            _kullanici = kullanici;
            _kutuphaneYoneticisi = kutuphaneYoneticisi;
            DataGuncelle();
            BilgileriGoster();
        }
        private void BilgileriGoster()
        {
            lblAdSoyad.Text = $"Ad Soyad: {_kullanici.AdSoyad}";
            lblID.Text = $"ID: {_kullanici.Id}";
            lblKullaniciAdi.Text = $"Kullanıcı Adı: {_kullanici.KullaniciAdi}";
            lblParola.Text = $"Parola: {_kullanici.Parola}";
        }
        private void DataGuncelle()
        {
            dgvOduncAlinanKitaplar.DataSource = null;
            dgvOduncAlinanKitaplar.DataSource = _kullanici.OduncAlinanKitaplar;
            dgvOduncAlinanKitaplar.Columns[0].Visible = false;
            dgvOduncAlinanKitaplar.Columns[2].Visible = false;
            dgvOduncAlinanKitaplar.Columns[4].Visible = false;
            dgvOduncAlinanKitaplar.Columns[5].Visible = false;
            dgvOduncAlinanKitaplar.Columns[6].Visible = false; 
        }
        private void btnKitapTeslimEt_Click(object sender, EventArgs e)
        {
            if (dgvOduncAlinanKitaplar.SelectedRows.Count > 0)
            {
                Kitap kitap = (Kitap)dgvOduncAlinanKitaplar.SelectedRows[0].DataBoundItem;
                _kullanici.OduncAlinanKitaplar.Remove(kitap);
                _kutuphaneYoneticisi.KitapTeslimEtme(kitap);
                DataGuncelle();
            }
        }

        private void dgvOduncAlinanKitaplar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOduncAlinanKitaplar.SelectedRows.Count > 0)
            {
                Kitap kitap = (Kitap)dgvOduncAlinanKitaplar.SelectedRows[0].DataBoundItem;
                dtpSonTeslimTarihi.Value = ((DateTime)kitap.AlinmaTarihi).AddDays(14);
            }
        }
    }
}
