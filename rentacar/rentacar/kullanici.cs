//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rentacar
{
    using System;
    using System.Collections.Generic;
    
    public partial class kullanici
    {
        public int kullaniciId { get; set; }
        public string kullaniciAd { get; set; }
        public string sifre { get; set; }
        public Nullable<int> rolId { get; set; }
        public string rolAd { get; set; }
    
        public virtual roller roller { get; set; }
    }
}
