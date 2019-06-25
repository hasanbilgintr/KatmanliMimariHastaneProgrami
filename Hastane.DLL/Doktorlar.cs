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
    
    public partial class Doktorlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doktorlar()
        {
            this.DoktorBilgileri = new HashSet<DoktorBilgileri>();
        }
    
        public int DoktorlarID { get; set; }
        public string DoktorTC { get; set; }
        public string DoktorAdi { get; set; }
        public string DoktorSoyadi { get; set; }
        public string DoktorCinsiyet { get; set; }
        public string DoktorTelefon { get; set; }
        public string Email { get; set; }
        public string MedeniHali { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public Nullable<int> DogumYeriID { get; set; }
        public Nullable<int> KanGrubuID { get; set; }
        public Nullable<int> DoktorUnvanID { get; set; }
        public string Adres { get; set; }
        public Nullable<int> KullaniciID { get; set; }
        public Nullable<int> KlinikID { get; set; }
        public string Resim { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoktorBilgileri> DoktorBilgileri { get; set; }
        public virtual DoktorUnvanlari DoktorUnvanlari { get; set; }
        public virtual iller iller { get; set; }
        public virtual KanGruplari KanGruplari { get; set; }
        public virtual Kullanicilar Kullanicilar { get; set; }
        public virtual Klinikler Klinikler { get; set; }
    }
}
