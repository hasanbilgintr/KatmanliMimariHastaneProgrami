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
    
    public partial class Branslar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Branslar()
        {
            this.DoktorUnvanlari = new HashSet<DoktorUnvanlari>();
        }
    
        public int BranslarID { get; set; }
        public string BransAdi { get; set; }
        public Nullable<int> KullaniciID { get; set; }
    
        public virtual Kullanicilar Kullanicilar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoktorUnvanlari> DoktorUnvanlari { get; set; }
    }
}
