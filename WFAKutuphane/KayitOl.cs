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
    public partial class KayitOl : Form
    {
        private readonly KullaniciYoneticisi kullaniciYoneticisi;

        public KayitOl(KullaniciYoneticisi kullaniciYöneticisi)
        {
            InitializeComponent();
            this.kullaniciYoneticisi = kullaniciYöneticisi;
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string adiniz = txtAdiniz.Text;
            string kullaniciAdi = txtKullaniciAdi.Text;
            string parola = txtParola.Text;
            string parolaTekrar = txtParolaTekrar.Text;

            if (adiniz==""|| kullaniciAdi==""||geçerliParola())
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }
            kullaniciYoneticisi.KayitOlma(adiniz, kullaniciAdi, parola);
            MessageBox.Show("Kayıt Başarılı.");
            Close();

        }
    
        private bool geçerliParola()
        {
            return (txtParola.Text != txtParolaTekrar.Text|| string.IsNullOrEmpty(txtParola.Text)||string.IsNullOrEmpty(txtParolaTekrar.Text));
        }

        private void txtParola_TextChanged(object sender, EventArgs e)
        {
            if (geçerliParola())
            {
                lblCheck.Text="Parola eşleşmiyor!";
                lblCheck.ForeColor = Color.Red;
            }
            else
            {
                lblCheck.Text = "Parola başarılı";
                lblCheck.ForeColor = Color.Green;
            }
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

            if (kullaniciYoneticisi.KullaniciVarmi(txtKullaniciAdi.Text.Trim()) || string.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                lblCheck.Text = "Kullanıcı Adı Uygun Değil!";
                lblCheck.ForeColor = Color.Red;
            }
            else
            {
                lblCheck.Text = "Kullanıcı Adı Uygun!";
                lblCheck.ForeColor = Color.Green;
            }
        }
        
    }
}
