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
    
    public partial class NewPandora_ExperimentoCorreo
    {
        public int IdExperimentoCorreo { get; set; }
        public Nullable<int> IdExperimento { get; set; }
        public string AsuntoCorreo { get; set; }
        public Nullable<bool> Estado { get; set; }
    
        public virtual NewPandora_Experimento NewPandora_Experimento { get; set; }
    }
}
