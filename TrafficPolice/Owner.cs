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
    
    public partial class Owner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Owner()
        {
            this.Tech_inspect_car = new HashSet<Tech_inspect_car>();
            this.Technical_Passport = new HashSet<Technical_Passport>();
        }
    
        public int ID_Owner { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Place_of_Residence { get; set; }
        public Nullable<System.DateTime> Year_of_Birth { get; set; }
        public Nullable<bool> Gender { get; set; }
        public string ImgOwner { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tech_inspect_car> Tech_inspect_car { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Technical_Passport> Technical_Passport { get; set; }
    }
}
