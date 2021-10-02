using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChinessResturantAPIs.Models
{
    public class OrderViewModel
    {

        public string OrdeRreference { get; set; }
        public string ItenNo { get; set; }
        public string qty { get; set; }

        public ICollection<OrderViewModel> Order { get; set; }

    }
}