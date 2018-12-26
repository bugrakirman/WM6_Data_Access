using SiparisApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisApp
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
            var urunler = db.Products
                .OrderBy(x => x.ProductName)
                .Select(x => new ProductViewModel()
                {
                    ProductID = x.ProductID,
                    ProductName = x.ProductName,
                     UnitPrice = x.UnitPrice
                })
                .ToList();
            var musteriler = db.Customers
                .OrderBy(x => x.CompanyName)
                .Select(x => new CustomerViewModel()
                {
                    CustomerID = x.CustomerID,
                    CompanyName = x.CompanyName,
                    Adres = x.Address
                })
                .ToList();
            var nakliyeciler = db.Shippers
                .OrderBy(x => x.CompanyName)
                .Select(x => new ShipperViewModel()
                {
                    ShipperID = x.ShipperID,
                    CompanyName = x.CompanyName
                })
                .ToList();
            var calisanlar = db.Employees
               .OrderBy(x => x.FirstName)
               .Select(x => new EmployeesViewModel()
               {
                   EmployeeID = x.EmployeeID,
                   FirstName = x.FirstName,
                   LastName=x.LastName
               })
               .ToList();

            lstUrunler.DataSource = urunler;
            cmbMusteri.DataSource = musteriler;
            cmbNakliye.DataSource = nakliyeciler;
            cmbCalisan.DataSource = calisanlar;
            
        }

        private void cmbMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMusteri.SelectedItem == null) return;
            rtxtAdres.Text = (cmbMusteri.SelectedItem as CustomerViewModel).Adres;
        }
    }
}
