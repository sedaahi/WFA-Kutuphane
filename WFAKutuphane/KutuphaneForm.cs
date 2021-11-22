using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAKutuphane.Data;

namespace WFAKutuphane
{
    public partial class KutuphaneForm : Form
    {
        KutuphaneYoneticisi kutuphaneYoneticisi;
        private readonly Kullanici kullanici;

        public KutuphaneForm(Kullanici kullanici)
        {
            InitializeComponent();
            VerileriOku();
            this.kullanici = kullanici;
            TurleriEkle();
            DataGuncelle();//Bagıs yaptıktan/ kitap ödünç aldıktan sonra DataGuncelle metodunu kullanıcam kod tekrarı yapmamak için metot olarakk tanımladık
        }

        private void DataGuncelle()
        {
            dgvKitaplar.DataSource = null;
            dgvKitaplar.DataSource = kutuphaneYoneticisi.Kitaplar;
            dgvKitaplar.Columns[0].Visible = false;
            dgvKitaplar.Columns[7].Visible = false;

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
            //Kütüphaneden seçili kitabı kaldırıcam ve o an ki login olmuş kullanıcının ödünç aldığı kitaplara ekliycem
            //Ve o an ki tarih bilgisini kitabın ödünç alınma tarihine yazıcam
            // 1. adım seçili kitabı bul
            //2. adım buldugum kitabı kullanıcının ödünç aldıgı kitaplardan silicem
            //3.adım buldugum kitbı kutuphanedeki kitaplardan silicem
            DataGuncelle();
            
        }
        private void dgvKitaplar_MouseClick(object sender, MouseEventArgs e)
        {
                //Sağ click olduğunda
            if (e.Button==MouseButtons.Right) //satırlarda sağ click oldugunda gostermek için.Gri alanda sağ clik olursa çalışmaycak
            {
                var position = dgvKitaplar.HitTest(e.X, e.Y).RowIndex;
                if (position>=0)//sağ tık yazı varken çalışacak yokken çalışmayacak
                {
                contexMenuStrip1.Show(dgvKitaplar, new Point(e.X, e.Y));

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
            HesabimForm hesabimForm = new HesabimForm(kullanici,kutuphaneYoneticisi);
            hesabimForm.ShowDialog();
        }

        private void tsmiBagisYap_Click(object sender, EventArgs e)
        {
            BagisForm bagisForm = new BagisForm(kutuphaneYoneticisi);
            bagisForm.ShowDialog();
            DataGuncelle();

        }
    }
}
