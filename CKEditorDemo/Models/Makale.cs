//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CKEditorDemo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Makale
    {
        public int Id { get; set; }
        public string baslik { get; set; }
        public string icerik { get; set; }
        public System.DateTime tarih { get; set; }
        public Nullable<int> kategori_Id { get; set; }
    
        public virtual kategori kategori { get; set; }
    }
}
