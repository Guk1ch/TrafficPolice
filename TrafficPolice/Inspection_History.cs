//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrafficPolice
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inspection_History
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inspection_History()
        {
            this.Tech_inspect_car = new HashSet<Tech_inspect_car>();
        }
    
        public int ID_History { get; set; }
        public Nullable<System.DateTime> Date_of_Passage { get; set; }
        public string Result { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tech_inspect_car> Tech_inspect_car { get; set; }
    }
}