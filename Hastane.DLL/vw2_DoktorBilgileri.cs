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
    
    public partial class vw2_DoktorBilgileri
    {
        public int DoktorBilgileriID { get; set; }
        public string DoktorAdi { get; set; }
        public System.DateTime GirisTarihi { get; set; }
        public Nullable<System.DateTime> CikisTarihi { get; set; }
        public bool AktifMi { get; set; }
        public string KullaniciAdi { get; set; }
    }
}