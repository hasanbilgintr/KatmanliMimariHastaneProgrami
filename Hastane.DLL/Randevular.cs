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
    
    public partial class Randevular
    {
        public int RandevularID { get; set; }
        public int HastaID { get; set; }
        public int KlinikID { get; set; }
        public int DoktorID { get; set; }
        public System.DateTime RandevuTarihi { get; set; }
        public string RandevuSaati { get; set; }
        public string Aciklama { get; set; }
        public int KullaniciID { get; set; }
    }
}