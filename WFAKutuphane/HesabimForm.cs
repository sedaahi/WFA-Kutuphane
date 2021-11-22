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
        private KutuphaneYoneticisi kutuphaneYoneticisi;
        private readonly Kullanici kullanici;

        public HesabimForm(Data.Kullanici kullanici)
        {
            InitializeComponent();
        }

        public HesabimForm(Kullanici kullanici, KutuphaneYoneticisi kutuphaneYoneticisi) : this(kullanici)
        {
            
            this.kutuphaneYoneticisi = kutuphaneYoneticisi;
        }
    }
}
