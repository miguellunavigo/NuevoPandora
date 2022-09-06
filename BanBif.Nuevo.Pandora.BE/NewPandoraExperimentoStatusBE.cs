using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.BE
{
    public class NewPandoraExperimentoStatusBE
    {
        public int IdStatusExperimento { get; set; }
        public string Status { get; set; }
    }
    public class NewPandoraExperimentoStatusResponse
    {
        public bool Result { get; set; } = false;
        public string Mensaje { get; set; } = String.Empty;
        public List<NewPandoraExperimentoStatusBE> Data { get; set; }
    }
    public class NewPandoraExperimentoStatusRequest
    {
        public int IdStatusExperimento { get; set; }
    }

}
