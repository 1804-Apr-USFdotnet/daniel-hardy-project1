//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public int rs_id { get; set; }
        public string Author { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public int rv_id { get; set; }
    
        public virtual Resturant Resturant { get; set; }
    }
}
