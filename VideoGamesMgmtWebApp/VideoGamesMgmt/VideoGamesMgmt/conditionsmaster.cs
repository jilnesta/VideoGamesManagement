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
    
    public partial class conditionsmaster
    {
        public conditionsmaster()
        {
            this.gamecontents = new HashSet<gamecontent>();
        }
    
        public int Condition_ID { get; set; }
        public string Condition_Name { get; set; }
    
        public virtual ICollection<gamecontent> gamecontents { get; set; }
    }
}
