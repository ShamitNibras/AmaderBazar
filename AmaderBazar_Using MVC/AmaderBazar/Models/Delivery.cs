//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AmaderBazar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Delivery
    {
        public int ID { get; set; }
        public string UID { get; set; }
        public string Status { get; set; }
        public int NumOfOrders { get; set; }
        public double DeliveryCharge { get; set; }
        public double Balance { get; set; }
    
        public virtual User User { get; set; }
    }
}
