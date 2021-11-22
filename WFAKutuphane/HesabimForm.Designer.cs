
namespace WFAKutuphane
{
    partial class HesabimForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOdunAlinanKitaplar = new System.Windows.Forms.DataGridView();
            this.dtpSonTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblSonTeslimTarihi = new System.Windows.Forms.Label();
            this.btnKitapTeslimEt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdunAlinanKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblParola);
            this.groupBox1.Controls.Add(this.lblKullaniciAdi);
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Location = new System.Drawing.Point(18, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(18, 64);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(73, 17);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(18, 103);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(88, 17);
            this.lblKullaniciAdi.TabIndex = 2;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParola.Location = new System.Drawing.Point(18, 143);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(53, 17);
            this.lblParola.TabIndex = 3;
            this.lblParola.Text = "Parola:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKitapTeslimEt);
            this.groupBox2.Controls.Add(this.lblSonTeslimTarihi);
            this.groupBox2.Controls.Add(this.dtpSonTeslimTarihi);
            this.groupBox2.Controls.Add(this.dgvOdunAlinanKitaplar);
            this.groupBox2.Location = new System.Drawing.Point(389, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ödünç Alınan Kitaplar";
            // 
            // dgvOdunAlinanKitaplar
            // 
            this.dgvOdunAlinanKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdunAlinanKitaplar.Location = new System.Drawing.Point(6, 19);
            this.dgvOdunAlinanKitaplar.Name = "dgvOdunAlinanKitaplar";
            this.dgvOdunAlinanKitaplar.Size = new System.Drawing.Size(411, 159);
            this.dgvOdunAlinanKitaplar.TabIndex = 0;
            // 
            // dtpSonTeslimTarihi
            // 
            this.dtpSonTeslimTarihi.Location = new System.Drawing.Point(104, 189);
            this.dtpSonTeslimTarihi.Name = "dtpSonTeslimTarihi";
            this.dtpSonTeslimTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpSonTeslimTarihi.TabIndex = 1;
            // 
            // lblSonTeslimTarihi
            // 
            this.lblSonTeslimTarihi.AutoSize = true;
            this.lblSonTeslimTarihi.Location = new System.Drawing.Point(7, 195);
            this.lblSonTeslimTarihi.Name = "lblSonTeslimTarihi";
            this.lblSonTeslimTarihi.Size = new System.Drawing.Size(91, 13);
            this.lblSonTeslimTarihi.TabIndex = 2;
            this.lblSonTeslimTarihi.Text = "Son Teslim Tarihi:";
            // 
            // btnKitapTeslimEt
            // 
            this.btnKitapTeslimEt.Location = new System.Drawing.Point(318, 186);
            this.btnKitapTeslimEt.Name = "btnKitapTeslimEt";
            this.btnKitapTeslimEt.Size = new System.Drawing.Size(99, 23);
            this.btnKitapTeslimEt.TabIndex = 3;
            this.btnKitapTeslimEt.Text = "Kitap Teslim Et";
            this.btnKitapTeslimEt.UseVisualStyleBackColor = true;
            // 
            // HesabimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HesabimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HesabimForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdunAlinanKitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvOdunAlinanKitaplar;
        private System.Windows.Forms.Button btnKitapTeslimEt;
        private System.Windows.Forms.Label lblSonTeslimTarihi;
        private System.Windows.Forms.DateTimePicker dtpSonTeslimTarihi;
    }
}