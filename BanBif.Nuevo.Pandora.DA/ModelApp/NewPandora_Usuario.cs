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
    
    public partial class NewPandora_Usuario
    {
        public int IdUsuario { get; set; }
        public Nullable<int> IdRol { get; set; }
        public string UsuarioWindows { get; set; }
        public string Contrasenia { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public Nullable<bool> FlagEstado { get; set; }
    
        public virtual NewPandora_Rol NewPandora_Rol { get; set; }
    }
}