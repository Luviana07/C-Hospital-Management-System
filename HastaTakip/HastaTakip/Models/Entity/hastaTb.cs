//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HastaTakip.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class hastaTb
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hastaTb()
        {
            this.sikayetTb = new HashSet<sikayetTb>();
        }
    
        public int hastaId { get; set; }
        public string hastaAd { get; set; }
        public string hastaSoyad { get; set; }
        public Nullable<System.DateTime> hastaDogtar { get; set; }
        public string hastaTelefon { get; set; }
        public string hastaAdres { get; set; }
        public Nullable<int> fotoId { get; set; }
        public string sikayet { get; set; }
        public string teshis { get; set; }
        public Nullable<System.DateTime> hastaGiris { get; set; }
        public Nullable<System.DateTime> hastaCikis { get; set; }
        public string fotografPath { get; set; }
    
        public virtual fotoTb fotoTb { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sikayetTb> sikayetTb { get; set; }
    }
}