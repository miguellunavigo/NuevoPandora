//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanBif.Nuevo.Pandora.DA.ModelApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class NewPandora_Rol
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NewPandora_Rol()
        {
            this.NewPandora_RolOpcion = new HashSet<NewPandora_RolOpcion>();
            this.NewPandora_Usuario = new HashSet<NewPandora_Usuario>();
        }
    
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public Nullable<int> Orden { get; set; }
        public Nullable<bool> FlagEstado { get; set; }
        public Nullable<int> IdVp { get; set; }
    
        public virtual NewPandora_VP NewPandora_VP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewPandora_RolOpcion> NewPandora_RolOpcion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewPandora_Usuario> NewPandora_Usuario { get; set; }
    }
}
