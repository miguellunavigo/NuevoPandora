using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.BE
{
    public class NewPandoraRolBE
    {
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public Nullable<int> Orden { get; set; }
        public Nullable<bool> FlagEstado { get; set; }
    }
    public class NewPandoraRolResponse
    {
        public bool Result { get; set; } = false;
        public string Mensaje { get; set; } = String.Empty;
        public List<NewPandoraRolBE> Data { get; set; }
    }
    public class NewPandoraRolRequest
    {
        public int IdRol { get; set; }
    }

}
