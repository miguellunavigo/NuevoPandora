using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.BE
{
    public class NewPandoraLoginBE
    {
        public int IdUsuario { get; set; }
        public Nullable<int> IdRol { get; set; }
        public string UsuarioWindows { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public Nullable<bool> FlagEstado { get; set; }
    }
    public class NewPandoraLoginResponse
    {
        public bool Result { get; set; } = false;
        public string Mensaje { get; set; } = String.Empty;
        public NewPandoraLoginBE Data { get; set; }
    }
    public class NewPandoraLoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

}
