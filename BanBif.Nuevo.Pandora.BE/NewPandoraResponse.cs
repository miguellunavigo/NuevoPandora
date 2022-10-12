using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.BE
{
    public class NewPandoraResponse<T>
    {
        public bool Result { get; set; }
        public string Mensaje { get; set; }
        public T data { get; set; }

    }
}
