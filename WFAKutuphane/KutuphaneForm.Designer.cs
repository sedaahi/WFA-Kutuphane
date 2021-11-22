
namespace WFAKutuphane
{
    partial class KutuphaneForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiHesabim = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBagisYap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCikisYap = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.lblArama = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.cmbTurler = new System.Windows.Forms.ComboBox();
            this.Türler = new System.Windows.Forms.Label();
            this.contexMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiKitapOduncAl = new System.Windows.Forms.ToolStripMenuItem();
            this.kitabıİmhaEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            this.contexMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHesabim,
            this.tsmiBagisYap,
            this.tsmiCikisYap});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiHesabim
            // 
            this.tsmiHesabim.Name = "tsmiHesabim";
            this.tsmiHesabim.Size = new System.Drawing.Size(66, 20);
            this.tsmiHesabim.Text = "Hesabım";
            this.tsmiHesabim.Click += new System.EventHandler(this.tsmiHesabim_Click);
            // 
            // tsmiBagisYap
            // 
            this.tsmiBagisYap.Name = "tsmiBagisYap";
            this.tsmiBagisYap.Size = new System.Drawing.Size(69, 20);
            this.tsmiBagisYap.Text = "Bağış Yap";
            this.tsmiBagisYap.Click += new System.EventHandler(this.tsmiBagisYap_Click);
            // 
            // tsmiCikisYap
            // 
            this.tsmiCikisYap.Name = "tsmiCikisYap";
            this.tsmiCikisYap.Size = new System.Drawing.Size(66, 20);
            this.tsmiCikisYap.Text = "Çıkış Yap";
            this.tsmiCikisYap.Click += new System.EventHandler(this.tsmiCikisYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kütüphane";
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Location = new System.Drawing.Point(12, 55);
            this.dgvKitaplar.MultiSelect = false;
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.ReadOnly = true;
            this.dgvKitaplar.RowHeadersVisible = false;
            this.dgvKitaplar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitaplar.Size = new System.Drawing.Size(698, 389);
            this.dgvKitaplar.TabIndex = 2;
            this.dgvKitaplar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvKitaplar_MouseClick);
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Location = new System.Drawing.Point(328, 31);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(37, 13);
            this.lblArama.TabIndex = 3;
            this.lblArama.Text = "Arama";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(371, 28);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(128, 20);
            this.txtArama.TabIndex = 4;
            // 
            // cmbTurler
            // 
            this.cmbTurler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurler.FormattingEnabled = true;
            this.cmbTurler.Location = new System.Drawing.Point(581, 28);
            this.cmbTurler.Name = "cmbTurler";
            this.cmbTurler.Size = new System.Drawing.Size(129, 21);
            this.cmbTurler.TabIndex = 5;
            // 
            // Türler
            // 
            this.Türler.AutoSize = true;
            this.Türler.Location = new System.Drawing.Point(541, 31);
            this.Türler.Name = "Türler";
            this.Türler.Size = new System.Drawing.Size(34, 13);
            this.Türler.TabIndex = 6;
            this.Türler.Text = "Türler";
            // 
            // contexMenuStrip1
            // 
            this.contexMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKitapOduncAl,
            this.kitabıİmhaEtToolStripMenuItem});
            this.contexMenuStrip1.Name = "contexMenuStrip1";
            this.contexMenuStrip1.Size = new System.Drawing.Size(155, 48);
            // 
            // tsmiKitapOduncAl
            // 
            this.tsmiKitapOduncAl.Name = "tsmiKitapOduncAl";
            this.tsmiKitapOduncAl.Size = new System.Drawing.Size(154, 22);
            this.tsmiKitapOduncAl.Text = "Kitap Ödünç Al";
            this.tsmiKitapOduncAl.Click += new System.EventHandler(this.tsmiKitapOduncAl_Click);
            // 
            // kitabıİmhaEtToolStripMenuItem
            // 
            this.kitabıİmhaEtToolStripMenuItem.Name = "kitabıİmhaEtToolStripMenuItem";
            this.kitabıİmhaEtToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.kitabıİmhaEtToolStripMenuItem.Text = "Kitabı İmha Et";
            // 
            // KutuphaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 456);
            this.Controls.Add(this.Türler);
            this.Controls.Add(this.cmbTurler);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.lblArama);
            this.Controls.Add(this.dgvKitaplar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KutuphaneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KutuphaneForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KutuphaneForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            this.contexMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiHesabim;
        private System.Windows.Forms.ToolStripMenuItem tsmiBagisYap;
        private System.Windows.Forms.ToolStripMenuItem tsmiCikisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ComboBox cmbTurler;
        private System.Windows.Forms.Label Türler;
        private System.Windows.Forms.ContextMenuStrip contexMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiKitapOduncAl;
        private System.Windows.Forms.ToolStripMenuItem kitabıİmhaEtToolStripMenuItem;
    }
}