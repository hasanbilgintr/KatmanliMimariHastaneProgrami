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
    
    public partial class DoktorUnvanlari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DoktorUnvanlari()
        {
            this.Doktorlar = new HashSet<Doktorlar>();
        }
    
        public int DoktorUnvanlariID { get; set; }
        public string UnvanAdi { get; set; }
        public int BransID { get; set; }
        public string DiplomaNumarasi { get; set; }
        public Nullable<int> KullaniciID { get; set; }
    
        public virtual Branslar Branslar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doktorlar> Doktorlar { get; set; }
        public virtual Kullanicilar Kullanicilar { get; set; }
    }
}