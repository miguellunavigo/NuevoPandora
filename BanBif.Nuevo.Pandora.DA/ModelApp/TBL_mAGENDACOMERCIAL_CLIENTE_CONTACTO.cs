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
    
    public partial class TBL_mAGENDACOMERCIAL_CLIENTE_CONTACTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_mAGENDACOMERCIAL_CLIENTE_CONTACTO()
        {
            this.TBL_mAGENDACOMERCIAL_CLIENTE_CONTACTO_COMENTARIOS = new HashSet<TBL_mAGENDACOMERCIAL_CLIENTE_CONTACTO_COMENTARIOS>();
        }
    
        public int CODIGOCONTACTO { get; set; }
        public Nullable<int> CODIGOCLIENTE { get; set; }
        public string NOMBRE_APELLIDO { get; set; }
        public string CARGO { get; set; }
        public string CORREO { get; set; }
        public string TELEFONO { get; set; }
    
        public virtual TBL_mAGENDACOMERCIAL_CLIENTE TBL_mAGENDACOMERCIAL_CLIENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_mAGENDACOMERCIAL_CLIENTE_CONTACTO_COMENTARIOS> TBL_mAGENDACOMERCIAL_CLIENTE_CONTACTO_COMENTARIOS { get; set; }
    }
}