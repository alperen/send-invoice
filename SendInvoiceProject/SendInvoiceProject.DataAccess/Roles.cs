//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SendInvoiceProject.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Roles
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int company_id { get; set; }
        public string type { get; set; }
    
        public virtual Companies Companies { get; set; }
        public virtual Users Users { get; set; }
    }
}
