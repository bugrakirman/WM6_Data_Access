namespace EF_TemelCrudIslemleri
{
    partial class Form1
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
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.btnKategoriKaydet = new System.Windows.Forms.Button();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.cmbUrunKategori = new System.Windows.Forms.ComboBox();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.gbUrun = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            this.gbUrun.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(12, 12);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori.TabIndex = 0;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(12, 50);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(121, 20);
            this.txtKategoriAdi.TabIndex = 1;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(12, 87);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(121, 96);
            this.txtAciklama.TabIndex = 2;
            this.txtAciklama.Text = "";
            // 
            // btnKategoriKaydet
            // 
            this.btnKategoriKaydet.Location = new System.Drawing.Point(12, 200);
            this.btnKategoriKaydet.Name = "btnKategoriKaydet";
            this.btnKategoriKaydet.Size = new System.Drawing.Size(121, 21);
            this.btnKategoriKaydet.TabIndex = 3;
            this.btnKategoriKaydet.Text = "insert";
            this.btnKategoriKaydet.UseVisualStyleBackColor = true;
            this.btnKategoriKaydet.Click += new System.EventHandler(this.btnKategoriKaydet_Click);
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(6, 19);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(263, 173);
            this.lstUrunler.TabIndex = 4;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(276, 19);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(127, 20);
            this.txtUrunAdi.TabIndex = 5;
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(276, 46);
            this.nudFiyat.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(127, 20);
            this.nudFiyat.TabIndex = 6;
            // 
            // cmbUrunKategori
            // 
            this.cmbUrunKategori.FormattingEnabled = true;
            this.cmbUrunKategori.Location = new System.Drawing.Point(276, 73);
            this.cmbUrunKategori.Name = "cmbUrunKategori";
            this.cmbUrunKategori.Size = new System.Drawing.Size(127, 21);
            this.cmbUrunKategori.TabIndex = 7;
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(276, 101);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(127, 23);
            this.btnUrunGuncelle.TabIndex = 8;
            this.btnUrunGuncelle.Text = "update";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // gbUrun
            // 
            this.gbUrun.Controls.Add(this.lstUrunler);
            this.gbUrun.Controls.Add(this.btnUrunGuncelle);
            this.gbUrun.Controls.Add(this.txtUrunAdi);
            this.gbUrun.Controls.Add(this.cmbUrunKategori);
            this.gbUrun.Controls.Add(this.nudFiyat);
            this.gbUrun.Location = new System.Drawing.Point(139, 12);
            this.gbUrun.Name = "gbUrun";
            this.gbUrun.Size = new System.Drawing.Size(420, 209);
            this.gbUrun.TabIndex = 9;
            this.gbUrun.TabStop = false;
            this.gbUrun.Text = "Urun";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbUrun);
            this.Controls.Add(this.btnKategoriKaydet);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.cmbKategori);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            this.gbUrun.ResumeLayout(false);
            this.gbUrun.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.Button btnKategoriKaydet;
        private System.Windows.Forms.ErrorProvider ep1;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.ComboBox cmbUrunKategori;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.GroupBox gbUrun;
    }
}

