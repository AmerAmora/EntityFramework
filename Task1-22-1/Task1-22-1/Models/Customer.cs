//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task1_22_1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public int customer_id { get; set; }
        public string customer_name { get; set; }
        public Nullable<int> customer_age { get; set; }
        public Nullable<int> city_id { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string photo { get; set; }
    
        public virtual City City { get; set; }
    }
}
