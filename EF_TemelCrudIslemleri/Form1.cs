using EF_TemelCrudIslemleri.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            cmbKategori.DataSource = db.Categories
                .OrderBy(x => x.CategoryName)
                .Select(x => new CategoryViewModel() {
                    CategoryID = x.CategoryID,
                    CategoryName = x.CategoryName,
                    ProductCount = x.Products.Count
                })
                .ToList();
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
                    CategoryName = string.IsNullOrEmpty(txtKategoriAdi.Text)?null: txtKategoriAdi.Text, //boş kaydetmesin diye
                    Description = txtAciklama.Text
                });
                int sonuc = db.SaveChanges();
                MessageBox.Show($"{sonuc} kayit eklendi");
                KategorileriGetir();
            }
            catch(DbEntityValidationException ex)
            {
                foreach (var validationError in ex.EntityValidationErrors)
                {
                    foreach (var error in validationError.ValidationErrors)
                    {
                        if (error.PropertyName == "CategoryName")
                            ep1.SetError(txtKategoriAdi,error.ErrorMessage);
                    }
                }
                MessageBox.Show(EntityHelper.ValidationMessage(ex),"Bir hata olustu",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

            lstUrunler.DataSource = db.Categories
                .First(x => x.CategoryID == cat.CategoryID)
                .Products
                .Select(x=> new ProductViewModel() {
                    ProductID=x.ProductID,
                    ProductName=x.ProductName,
                    UnitPrice=x.UnitPrice
                })
                .OrderBy(x=>x.ProductName)
                .ToList();        // first yerine Where(x => x.CategoryID == cat.CategoryID).First() yazılabilir.

            
        }
    }
}
