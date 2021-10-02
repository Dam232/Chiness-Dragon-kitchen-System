using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChinessResturantAPIs.Models
{
    public class MenueViewModel
    {
        public string ItenNo { get; set; }
        public string desription { get; set; }
        public decimal pric { get; set; }

        public ICollection<OrderMenue> OrderMenues { get; set; }
    }
}