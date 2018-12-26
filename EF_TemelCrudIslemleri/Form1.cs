using EF_TemelCrudIslemleri.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_TemelCrudIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
        }

        private void KategorileriGetir()
        {
            NorthwindsabahEntities db = new NorthwindsabahEntities();
            var kategoriler1 = db.Categories
                .OrderBy(x => x.CategoryName)
                .Select(x => new CategoryViewModel()
                {
                    CategoryID = x.CategoryID,
                    CategoryName = x.CategoryName,
                    ProductCount = x.Products.Count
                })
                .ToList();
            var kategoriler2 = db.Categories
                .OrderBy(x => x.CategoryName)
                .Select(x => new CategoryViewModel()
                {
                    CategoryID = x.CategoryID,
                    CategoryName = x.CategoryName,
                    ProductCount = x.Products.Count
                })
                .ToList();
            cmbUrunKategori.DataSource = kategoriler2;
            cmbKategori.DataSource = kategoriler1;

            //cmbKategori.DisplayMember = "CategoryName";
            //cmbKategori.ValueMember = "CategoryID";    tostringi ezince gerek kalmadı
        }

        private void btnKategoriKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                ep1.Clear();
                NorthwindsabahEntities db = new NorthwindsabahEntities();
                db.Categories.Add(new Category()
                {
                    CategoryName = string.IsNullOrEmpty(txtKategoriAdi.Text) ? null : txtKategoriAdi.Text, //boş kaydetmesin diye
                    Description = txtAciklama.Text
                });
                int sonuc = db.SaveChanges();
                MessageBox.Show($"{sonuc} kayit eklendi");
                KategorileriGetir();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationError in ex.EntityValidationErrors)
                {
                    foreach (var error in validationError.ValidationErrors)
                    {
                        if (error.PropertyName == "CategoryName")
                            ep1.SetError(txtKategoriAdi, error.ErrorMessage);
                    }
                }
                MessageBox.Show(EntityHelper.ValidationMessage(ex), "Bir hata olustu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedItem == null) return;
            CategoryViewModel cat = cmbKategori.SelectedItem as CategoryViewModel;
            NorthwindsabahEntities db = new NorthwindsabahEntities();

            //lstUrunler.DataSource = db.Products
            //    .Where(x => x.CategoryID == cat.CategoryID)
            //    .OrderBy(x => x.ProductName)
            //    .ToList(); ya da 
            //lstUrunler.DisplayMember = "ProductName";
            var sorgu = db.Categories
                .First(x => x.CategoryID == cat.CategoryID)
                .Products
                .Select(x => new ProductViewModel()
                {
                    ProductID = x.ProductID,
                    ProductName = x.ProductName,
                    UnitPrice = x.UnitPrice
                })
                .OrderBy(x => x.ProductName)
                .ToList();   // first yerine Where(x => x.CategoryID == cat.CategoryID).First() yazılabilir.

            lstUrunler.DataSource = sorgu;
            gbUrun.Visible = sorgu.Count > 0;


        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;

            var seciliUrun = lstUrunler.SelectedItem as ProductViewModel;
            NorthwindsabahEntities db = new NorthwindsabahEntities();
            var urun = db.Products.Find(seciliUrun.ProductID); //sadece primary key üzerinden çalışır
            txtUrunAdi.Text = urun.ProductName;
            //nudFiyat.Value = urun.UnitPrice.HasValue?urun.UnitPrice.Value:0; uzun yöntem nullable decimali decimale çeviremedi
            //nudFiyat.Value = urun.UnitPrice.GetValueOrDefault();  ya da 
            nudFiyat.Value = urun.UnitPrice ?? 0;

            var uruncatlist = cmbUrunKategori.DataSource as List<CategoryViewModel>;
            foreach (var item in uruncatlist)
            {
                if (item.CategoryID == urun.CategoryID)
                {
                    cmbUrunKategori.SelectedItem = item;
                    break;
                }
            }
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                ep1.Clear();
                NorthwindsabahEntities db = new NorthwindsabahEntities();
                var seciliUrun = lstUrunler.SelectedItem as ProductViewModel;
                var urun = db.Products.Find(seciliUrun.ProductID); // referans tipindeki urunun propertylerini değiştirip savechange ile değişiklikleri sql e aktarıyor
                urun.ProductName = txtUrunAdi.Text;
                urun.UnitPrice = nudFiyat.Value;
                urun.CategoryID = (cmbUrunKategori.SelectedItem as CategoryViewModel).CategoryID;
                int sonuc = db.SaveChanges();
                KategorileriGetir();
                MessageBox.Show($"{sonuc} urun guncellendi");
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationError in ex.EntityValidationErrors)
                {
                    foreach (var error in validationError.ValidationErrors)
                    {
                        if (error.PropertyName == "ProductName")
                            ep1.SetError(txtUrunAdi, error.ErrorMessage);

                        MessageBox.Show(EntityHelper.ValidationMessage(ex), "Bir hata olustu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;

            var urunID = (lstUrunler.SelectedItem as ProductViewModel).ProductID;
            var cevap = MessageBox.Show("secili ürünü silmek istiyor musunuz ?", "Urun Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes) return;

            try
            {
                NorthwindsabahEntities db = new NorthwindsabahEntities();
                var urun = db.Products.Find(urunID);
                db.Products.Remove(urun);
                MessageBox.Show($"{db.SaveChanges()} kayit silindi");
                KategorileriGetir();
            }
            catch(DbUpdateException ex)
            {
                MessageBox.Show("silmek istediğiniz akyit baska tabloda kullanildigi icin silemezsiniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
