//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChinessResturantAPIs
{
    using System;
    using System.Collections.Generic;
    
    public partial class Menue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Menue()
        {
            this.OrderMenues = new HashSet<OrderMenue>();
        }
    
        public string ItenNo { get; set; }
        public string desription { get; set; }
        public decimal pric { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderMenue> OrderMenues { get; set; }
    }
}
