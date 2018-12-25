using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDBFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // tum urunleri listeleyelim
            NorthwindsabahEntities db = new NorthwindsabahEntities();
            //product uzerinden ilerlendigi icin tum productlar gozukmeli yani left join
            var sorgu1 = db.Products
                .Select(x=> new {
                    x.ProductName,
                    x.UnitPrice,
                    x.Category.CategoryName
                })
                .ToList();
            //dgvTest.DataSource = sorgu1;
            //burada iliski kuruldugu icin iliskideki kurala gore inner join
            var sorgu2 = from p in db.Products
                         join cat in db.Categories on p.CategoryID equals cat.CategoryID
                         select new
                         {
                             UrunAdi = p.ProductName,
                             Fiyat = p.UnitPrice,
                             Kategori = cat.CategoryName
                         };

            //dgvTest.DataSource = sorgu2.ToList() ;

            //calisalari email adresi ile listeleyin
            var sorgu3 = db.Employees
                .Select(x => new
                {
                    Ad = x.FirstName,
                    Soyad = x.LastName,
                    Email = (x.FirstName.Substring(0, 1) + x.LastName + "@northwind.com").ToLower()
                }).ToList();
            //dgvTest.DataSource = sorgu3;

            //

            var sorgu4 = from emp in db.Employees
                         select new
                         {
                             emp.FirstName,
                             emp.LastName,
                             email = (emp.FirstName.Substring(0, 1) + emp.LastName + "northwind.com").ToLower()
                         };
            //dgvTest.DataSource = sorgu4.ToList();

            //this.Text = $"{db.Products.Average(x=>x.UnitPrice):c2}";

            var sorgu5 = db.Products
                .Where(x => x.UnitPrice >= db.Products.Average(y => y.UnitPrice))
                .Select(x => new
                {
                    x.ProductName,
                    fiyat = x.UnitPrice,
                    x.Category.CategoryName
                })
                .OrderByDescending(x => x.fiyat)
                .ToList();
            //dgvTest.DataSource = sorgu5;

            var sorgu6 = from p in db.Products
                         where p.UnitPrice >= db.Products.Average(x => x.UnitPrice)
                         orderby p.UnitPrice descending
                         select new
                         {
                             p.ProductName,
                             fiyat = p.UnitPrice,
                             p.Category.CategoryName
                         };
            //dgvTest.DataSource = sorgu6.ToList();

            // hangi kategoriden kac tane urunum var

            var sorgu7 = db.Products
                .Where(x => x.CategoryID.HasValue)
                .GroupBy(x => new { x.Category.CategoryName, x.Supplier.CompanyName })//x.Category.CategoryName)
                .Select(x => new
                {
                    Kategori = x.Key.CategoryName,
                    Company = x.Key.CompanyName,
                    Total = x.Count()
                })
                .OrderByDescending(x=>x.Kategori)
                .ThenBy(x=>x.Company)
                .ToList();
            //gvTest.DataSource = sorgu7;

            var sorgu8 = from product in db.Products
                         join category in db.Categories on product.CategoryID equals category.CategoryID
                         join supp in db.Suppliers on product.SupplierID equals supp.SupplierID
                         group new
                         {
                             category,
                             supp
                         }
                         by new
                         {
                             category.CategoryName,
                             supp.CompanyName
                         } into gp
                         orderby gp.Key.CategoryName ascending,gp.Key.CompanyName descending
                         select new
                         {
                             CategoryName = gp.Key.CategoryName,
                             CompanyName = gp.Key.CompanyName,
                             Total = gp.Count()
                         };
            //dgvTest.DataSource = sorgu8.ToList();

            //hangi urunumden ne kadarlik siparis verildi

            var sorgu9 = db.Order_Details
                .Join(db.Products,
                od => od.ProductID,
                Product => Product.ProductID,
                (od, product) => new { od, product })
                .GroupBy(x => x.product.ProductName)
                .OrderBy(x => x.Key)
                .ToList()//kaldırıp hatayı gör sql e convert i gönderemiyor
                .Select(x => new
                {
                    x.Key,
                    Total = x.Sum(y => y.od.UnitPrice * y.od.Quantity*Convert.ToDecimal((1-y.od.Discount)))
                });
            //dgvTest.DataSource = sorgu9.ToList();

            var sorgu10 = from prod in db.Products
                          join od in db.Order_Details on prod.ProductID equals od.ProductID
                          group new
                          {
                              prod,
                              od
                          }
                          by new
                          {
                              prod.ProductName
                          } 
                          into gp
                          orderby gp.Key.ProductName
                          select new
                          {
                              gp.Key.ProductName,

                              //Total = gp.Sum(x => x.od.UnitPrice * x.od.Quantity*Convert.ToDecimal(1-x.od.Discount)) aynı hata
                          };

            //var data = sorgu10.ToList();
            //dgvTest.DataSource=data.GroupBy(x => x.ProductName)
            //    .Select(x=> new {
            //        ProductName=x.Key,
            //        Total = gp.Sum(x => x.od.UnitPrice * x.od.Quantity * Convert.ToDecimal(1 - x.od.Discount))
            //    }).tolist()   veriyi çektikten sonra işliyoruz hatayı düzeltmek için

           // dgvTest.DataSource = sorgu10.ToList();

            //calisanlarim kac tane siparis almis 

            var sorgu11 = from emp in db.Employees
                          join o in db.Orders on emp.EmployeeID equals o.EmployeeID
                          join od in db.Order_Details on o.OrderID equals od.OrderID
                           group new
                          {
                              emp,
                              od
                          }
                          by new
                          {
                              emp.FirstName,
                              emp.LastName
                          } 
                          into gp
                          select new
                          {
                              Employee = gp.Key.FirstName+" "+gp.Key.LastName,
                              total = gp.Sum(x=>x.od.Quantity)
                          };
            //dgvTest.DataSource = sorgu11.OrderByDescending(x=>x.total).ToList();

            var sorgu12 = db.Order_Details
                .Join(db.Orders,
                od => od.OrderID,
                o => o.OrderID,
                (od, o) => new { od, o })
                .Join(db.Employees,
                gg => gg.o.EmployeeID,
                emp => emp.EmployeeID,
                (gg, emp) => new { gg, emp })
                .GroupBy(x => x.emp.FirstName + " " + x.emp.LastName)
                .Select(x => new {
                    employee = x.Key,
                    total = x.Sum(y => y.gg.od.Quantity)
                })
                .OrderByDescending(x => x.total)
                .ToList();
            //dgvTest.DataSource = sorgu12;


            //hangi kategoriden toplam kac adet siiparisim var

            var sorgu13 = from c in db.Categories
                          join p in db.Products on c.CategoryID equals p.CategoryID
                          join od in db.Order_Details on p.ProductID equals od.ProductID
                          group new
                          {
                              c,
                              od
                          }
                         by new
                         {
                             c.CategoryName,
                         }
                          into gp
                          select new
                          {
                              Kategori = gp.Key.CategoryName,
                              total = gp.Sum(x => x.od.Quantity)
                          };
            //dgvTest.DataSource = sorgu13.OrderByDescending(x=>x.total).ToList();

            //siparis no- toplam siparis tutari
            var sorgu14=from od in db.Order_Details
                        group new
                        {
                            od
                        }
                        by new
                        {
                            od.OrderID
                        }
                        into gp
                        select new{
                            gp.Key.OrderID,
                            total = gp.Sum(x=>x.od.UnitPrice*x.od.Quantity)
                        };
            //dgvTest.DataSource = sorgu14.ToList();

            var sorgu15 = db.Order_Details
                .GroupBy(x => x.OrderID)
                .ToList()
                .Select(x => new
                {
                    x.Key,
                    total = x.Sum(y => y.Quantity * y.UnitPrice * Convert.ToDecimal((1 - y.Discount)))
                });
            //dgvTest.DataSource = sorgu15;


            //calisanlarim hangi kategoriden kac adet siparis vermistir 2 key olacak -- ödev

        }
    }
}
