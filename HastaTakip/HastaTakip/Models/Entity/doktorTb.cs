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
    
    public partial class doktorTb
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public doktorTb()
        {
            this.sikayetTb = new HashSet<sikayetTb>();
        }
    
        public int doktorId { get; set; }
        public string doktorKullanici { get; set; }
        public string doktorSifre { get; set; }
        public string doktorAd { get; set; }
        public string doktorSoyad { get; set; }
        public string doktorBolum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sikayetTb> sikayetTb { get; set; }
    }
}
