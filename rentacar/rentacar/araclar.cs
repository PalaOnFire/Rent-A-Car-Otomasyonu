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
    
    public partial class araclar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public araclar()
        {
            this.satis = new HashSet<sati>();
        }
    
        public int aracId { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public string seri { get; set; }
        public string mYılı { get; set; }
        public string km { get; set; }
        public string yakıt { get; set; }
        public string vites { get; set; }
        public string kasatipi { get; set; }
        public string klima { get; set; }
        public string plaka { get; set; }
        public byte[] Resim { get; set; }
        public string aracfiyat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sati> satis { get; set; }
    }
}