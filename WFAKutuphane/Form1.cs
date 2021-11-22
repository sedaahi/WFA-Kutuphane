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
    public partial class Form1 : Form
    {
        //kullanic yönteicisini jsonda varsa new le demek istediğimiz için burada newlemedik
        KullaniciYoneticisi kullaniciYoneticisi;
        public Form1()
        {
            InitializeComponent();
            VerileriOku();
        }
        private void VerileriYaz()
        {
            string json = JsonConvert.SerializeObject(kullaniciYoneticisi);
            File.WriteAllText("veri.json", json);
        }
        private void VerileriOku()
        {
            try 
            {
            string json = File.ReadAllText("veri.json");
            kullaniciYoneticisi = JsonConvert.DeserializeObject<KullaniciYoneticisi>(json);
            }
            catch (Exception)
            {
                kullaniciYoneticisi = new KullaniciYoneticisi();
            }
            txtKullaniciAdi.Text = "sedaahi"; //hergirişte tekrar yazmamak için şimdilik yazdık sonra silinmeli
            txtParola.Text = "123456";
        }

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl kayitOlForm = new KayitOl(kullaniciYoneticisi);
            kayitOlForm.ShowDialog();

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Kullanici girisYapan = kullaniciYoneticisi.OturumAcma(txtKullaniciAdi.Text, txtParola.Text);
            if (girisYapan==null)
            {
                MessageBox.Show("Kullanıcı adı yada şifre hatalı!");
            }
            else
            {
                MessageBox.Show($"Hoşgeldiniz {girisYapan.AdSoyad}");
                KutuphaneForm kutuphaneForm = new KutuphaneForm(girisYapan);
                kutuphaneForm.ShowDialog();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriYaz();
        }
    }
}
