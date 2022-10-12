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
        public bool FlagExperimento { get; set; }
        public int Orden { get; set; }
}

    public class NewPandoraExperimentoStatusRequest
    {
        public int? IdStatusExperimento { get; set; }
        public bool FlagExperimento { get; set; }
    }
}
