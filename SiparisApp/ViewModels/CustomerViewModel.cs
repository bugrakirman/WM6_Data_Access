using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisApp.ViewModels
{
    public class CustomerViewModel
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string Adres { get; set; }
        public override string ToString() => $"{CompanyName}";
    }
}
