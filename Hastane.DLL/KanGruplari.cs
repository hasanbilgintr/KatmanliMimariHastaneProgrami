//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hastane.DLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class KanGruplari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KanGruplari()
        {
            this.Doktorlar = new HashSet<Doktorlar>();
            this.Hastalar = new HashSet<Hastalar>();
            this.Personeller = new HashSet<Personeller>();
        }
    
        public int KanGruplariID { get; set; }
        public string KanGrubuAdi { get; set; }
        public Nullable<int> KullaniciID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doktorlar> Doktorlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hastalar> Hastalar { get; set; }
        public virtual Kullanicilar Kullanicilar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personeller> Personeller { get; set; }
    }
}