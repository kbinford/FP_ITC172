//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonContact
    {
        public int ContactKey { get; set; }
        public string ContactInfo { get; set; }
        public Nullable<int> PersonKey { get; set; }
        public Nullable<int> ContactTypeKey { get; set; }
    
        public virtual ContactType ContactType { get; set; }
        public virtual Person Person { get; set; }
    }
}
