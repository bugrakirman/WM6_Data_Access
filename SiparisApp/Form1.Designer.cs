namespace SiparisApp
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
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.cmbNakliye = new System.Windows.Forms.ComboBox();
            this.cmbCalisan = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.txtNakliyeUcreti = new System.Windows.Forms.TextBox();
            this.rtxtAdres = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.nudIndirim = new System.Windows.Forms.NumericUpDown();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndirim)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(13, 49);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(140, 251);
            this.lstUrunler.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(140, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(251, 49);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(200, 21);
            this.cmbMusteri.TabIndex = 2;
            this.cmbMusteri.SelectedIndexChanged += new System.EventHandler(this.cmbMusteri_SelectedIndexChanged);
            // 
            // cmbNakliye
            // 
            this.cmbNakliye.FormattingEnabled = true;
            this.cmbNakliye.Location = new System.Drawing.Point(251, 79);
            this.cmbNakliye.Name = "cmbNakliye";
            this.cmbNakliye.Size = new System.Drawing.Size(200, 21);
            this.cmbNakliye.TabIndex = 3;
            // 
            // cmbCalisan
            // 
            this.cmbCalisan.FormattingEnabled = true;
            this.cmbCalisan.Location = new System.Drawing.Point(251, 109);
            this.cmbCalisan.Name = "cmbCalisan";
            this.cmbCalisan.Size = new System.Drawing.Size(200, 21);
            this.cmbCalisan.TabIndex = 4;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(251, 139);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 5;
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(471, 49);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(140, 251);
            this.lstSepet.TabIndex = 6;
            // 
            // txtNakliyeUcreti
            // 
            this.txtNakliyeUcreti.Location = new System.Drawing.Point(251, 168);
            this.txtNakliyeUcreti.Name = "txtNakliyeUcreti";
            this.txtNakliyeUcreti.Size = new System.Drawing.Size(200, 20);
            this.txtNakliyeUcreti.TabIndex = 7;
            // 
            // rtxtAdres
            // 
            this.rtxtAdres.Location = new System.Drawing.Point(251, 197);
            this.rtxtAdres.Name = "rtxtAdres";
            this.rtxtAdres.Size = new System.Drawing.Size(200, 71);
            this.rtxtAdres.TabIndex = 8;
            this.rtxtAdres.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.nudIndirim);
            this.groupBox1.Controls.Add(this.nudAdet);
            this.groupBox1.Location = new System.Drawing.Point(633, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 175);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Urun Bilgileri";
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(78, 20);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(120, 20);
            this.nudAdet.TabIndex = 0;
            // 
            // nudIndirim
            // 
            this.nudIndirim.Location = new System.Drawing.Point(78, 65);
            this.nudIndirim.Name = "nudIndirim";
            this.nudIndirim.Size = new System.Drawing.Size(120, 20);
            this.nudIndirim.TabIndex = 1;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(78, 110);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(120, 23);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Musteri";
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(251, 272);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(200, 28);
            this.btnSepeteEkle.TabIndex = 12;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nakliye";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Calisan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nakliye Ucreti";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Adres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 326);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtxtAdres);
            this.Controls.Add(this.txtNakliyeUcreti);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbCalisan);
            this.Controls.Add(this.cmbNakliye);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstUrunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndirim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox cmbNakliye;
        private System.Windows.Forms.ComboBox cmbCalisan;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.TextBox txtNakliyeUcreti;
        private System.Windows.Forms.RichTextBox rtxtAdres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.NumericUpDown nudIndirim;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

