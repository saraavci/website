//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace deneme_4
{
    using System;
    using System.Collections.Generic;
    
    public partial class kisi
    {
        public string tc { get; set; }
        public string ad { get; set; }
        public string iletisim { get; set; }
        public System.Data.Entity.Spatial.DbGeography location { get; set; }
        public Nullable<int> mekan_id { get; set; }
    
        public virtual mekan mekan { get; set; }
    }
}