//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoGamesMgmt
{
    using System;
    using System.Collections.Generic;
    
    public partial class videogamescategory
    {
        public int VGCat_ID { get; set; }
        public Nullable<int> VGCat_Game_ID { get; set; }
        public Nullable<int> VGCat_Category_ID { get; set; }
    
        public virtual categoriesmaster categoriesmaster { get; set; }
        public virtual videogame videogame { get; set; }
    }
}