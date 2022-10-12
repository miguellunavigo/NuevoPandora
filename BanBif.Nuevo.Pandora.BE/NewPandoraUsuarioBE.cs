using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.BE
{
    public class NewPandoraUsuarioBE
    {
        public int IdUsuario { get; set; }
        public Nullable<int> IdRol { get; set; }
        public string Rol { get; set; }
        public string UsuarioWindows { get; set; }

        public string Nombre { get; set; }
        public string Correo { get; set; }
        public Nullable<bool> FlagEstado { get; set; }
    }

    public class NewPandoraUsuarioRequest
    {
        public int IdUsuario { get; set; }
        public Nullable<int> IdRol { get; set; }
        public string UsuarioWindows { get; set; }
        public string Contrasenia { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
    }

}
