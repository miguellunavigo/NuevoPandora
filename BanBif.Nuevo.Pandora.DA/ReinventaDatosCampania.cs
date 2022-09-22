//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanBif.Nuevo.Pandora.DA
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReinventaDatosCampania
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReinventaDatosCampania()
        {
            this.ReinventaDatosCampaniaCarrusel = new HashSet<ReinventaDatosCampaniaCarrusel>();
            this.ReinventaDatosCampaniaRegistro = new HashSet<ReinventaDatosCampaniaRegistro>();
        }
    
        public int IdCampania { get; set; }
        public Nullable<int> IdExperimento { get; set; }
        public string NombreCampania { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public string ColorCabecera { get; set; }
        public string ColorDetalle { get; set; }
        public string TextoPrimario { get; set; }
        public string TextoSecundario { get; set; }
        public string ImagenPrimario { get; set; }
        public Nullable<bool> FlagCarrusel { get; set; }
        public string ImagenSecundario { get; set; }
        public string TextoTerciario { get; set; }
        public string MasInformacion { get; set; }
        public string UrlCampania { get; set; }
        public string TextoFinal1 { get; set; }
        public string TextoFinal2 { get; set; }
        public string TextoFinalUrl { get; set; }
        public string ImagenFinal { get; set; }
        public string UsuarioCreacion { get; set; }
        public Nullable<int> Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReinventaDatosCampaniaCarrusel> ReinventaDatosCampaniaCarrusel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReinventaDatosCampaniaRegistro> ReinventaDatosCampaniaRegistro { get; set; }
    }
}
