using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChinessResturantAPIs.Models
{
    public class DragonDataViewMode
    {
        public string OrdeRreference { get; set; }
        public string OrderThrough { get; set; }
        public string OrderType { get; set; }
        public string Status { get; set; }
        public System.DateTime OrderDate { get; set; }
        public OrderViewModel OrderMenues {
            get; set;
        }



    }
}