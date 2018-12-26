using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisApp.ViewModels
{
    public class ShipperViewModel
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public override string ToString() => $"{CompanyName}";
    }
}
