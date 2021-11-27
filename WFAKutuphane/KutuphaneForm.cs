using Newtonsoft.Json;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WFAKutuphane.Data;

namespace WFAKutuphane
{
    public partial class KutuphaneForm : Form
    {
        private readonly Kullanici kullanici;
        KutuphaneYoneticisi kutuphaneYoneticisi;

        public KutuphaneForm(Kullanici kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;
            VerileriOku();
            TurleriEkle();
            KitapArama();
        }
        private void TurleriEkle()
        {
            cmbTurler.Items.Add("Hepsi");
            foreach (var item in Enum.GetValues(typeof(KitapTur)))
            {
                cmbTurler.Items.Add(item);
            }
            cmbTurler.SelectedIndex = 0; //seçli olsun isternmiyorsa
            //cmbTurler.SelectedIndex = 1; Hepsi seçili olsun isteniyorsa

            //FOREACH YERINE hepsini teker tekerde yazdırabilirsin
            //cmbTurler.Items.Add(KitapTur.BilimKurgu);
            //cmbTurler.Items.Add(KitapTur.Biyografi);
            //cmbTurler.Items.Add(KitapTur.Egitim);
            //cmbTurler.Items.Add(KitapTur.Fantastik);
            //cmbTurler.Items.Add(KitapTur.Korku);
            //cmbTurler.Items.Add(KitapTur.Polisiye);
            //cmbTurler.Items.Add(KitapTur.Psikoloji);
            //cmbTurler.Items.Add(KitapTur.Roman);
            //cmbTurler.Items.Add(KitapTur.Tarih);

        }
        private void VerileriOku()
        {
            try//varsa oku
            {
                string jsonOkunan = File.ReadAllText("veriKutuphane.json");
                kutuphaneYoneticisi = JsonConvert.DeserializeObject<KutuphaneYoneticisi>(jsonOkunan);

            }
            catch (Exception)//okuyamazsa oluştur.
            {
                kutuphaneYoneticisi = new KutuphaneYoneticisi();
            }
        }
        private void tsmiCikisYap_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void tsmiKitapOduncAl_Click(object sender, EventArgs e)
        {
            //Kutuphaneden seçili kitabı kaldırıcam ve o an ki login olmuş kullanıcın ödünç aldığı kitaplara eklicem.
            //Ve o anki tarih bilgisini kitabın ödünç alınma tarihine yazıcam.
            if (dgvKitaplar.SelectedRows.Count > 0)
            {
                //1. adım seçili kitabı bulcam.
                Kitap arananKitap = (Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem;
                //2. adım bulduğum kitabı kullanıcının ödünç aldığı kitaplara eklicem.
                arananKitap.AlinmaTarihi = DateTime.Now;
                kullanici.OduncAlinanKitaplar.Add(arananKitap);
                //3. adım bulduğum kitabı kutuphanedeki kitaplardan silcem.
                kutuphaneYoneticisi.Kitaplar.Remove(arananKitap);
                KitapArama();
            }
        }
        private void dgvKitaplar_MouseClick(object sender, MouseEventArgs e)
        {
            //Sağ click olduğunda
            if (e.Button == MouseButtons.Right) //satırlarda sağ click oldugunda gostermek için.Gri alanda sağ clik olursa çalışmaycak
            {
                var position = dgvKitaplar.HitTest(e.X, e.Y).RowIndex;
                if (position >= 0)//sağ tık yazı varken çalışacak yokken çalışmayacak
                {
                    contexMenuStrip1.Show(dgvKitaplar, new Point(e.X, e.Y));
                    dgvKitaplar.Rows[position].Selected = true; //sağ tık yaptıgımız satırı seçer.
                }
            }
        }
        private void KutuphaneForm_FormClosing(object sender, FormClosingEventArgs e)//verilerin kaydı
        {

            string json = JsonConvert.SerializeObject(kutuphaneYoneticisi);
            File.WriteAllText("veriKutuphane.json", json);
        }
        private void tsmiHesabim_Click(object sender, EventArgs e)
        {
            HesabimForm hesabimForm = new HesabimForm(kullanici, kutuphaneYoneticisi);
            hesabimForm.ShowDialog();
            KitapArama();
        }
        private void tsmiBagisYap_Click(object sender, EventArgs e)
        {
            BagisForm bagisForm = new BagisForm(kutuphaneYoneticisi);
            bagisForm.ShowDialog();
            KitapArama();
        }
        private void cmbTurler_SelectedIndexChanged(object sender, EventArgs e)
        {
            KitapArama();
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            KitapArama();
        }
        private void KitapArama()
        {
            dgvKitaplar.DataSource = null;
            string aranan = txtArama.Text.ToLower().Trim();
            if (!string.IsNullOrEmpty(txtArama.Text) && cmbTurler.SelectedIndex != 0)
            {
                dgvKitaplar.DataSource = kutuphaneYoneticisi.Kitaplar
                    .Where(x => x.Ad.ToLower().Contains(aranan) && x.KitapTur == (KitapTur)cmbTurler.SelectedItem)
                    .ToList();
            }
            else if (cmbTurler.SelectedIndex != 0)
            {
                dgvKitaplar.DataSource = kutuphaneYoneticisi.Kitaplar
                    .Where(x => x.KitapTur == (KitapTur)cmbTurler.SelectedItem)
                    .ToList();
            }
            else if (!string.IsNullOrEmpty(txtArama.Text))
            {
                dgvKitaplar.DataSource = kutuphaneYoneticisi.Kitaplar
                    .Where(x => x.Ad.ToLower().Contains(aranan))
                    .ToList();
            }
            else
            {
                dgvKitaplar.DataSource = kutuphaneYoneticisi.Kitaplar.OrderBy(x => x.Ad).ToList();
            }
            dgvKitaplar.Columns[0].Visible = false;
            dgvKitaplar.Columns[7].Visible = false;
        }
        private void tsmiKitapImhaEt_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.SelectedRows.Count > 0)
            {
                Kitap silinecekKitap = (Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem;
                kutuphaneYoneticisi.KitapImhaEt(silinecekKitap);
                KitapArama();
            }
        }
    }
}
