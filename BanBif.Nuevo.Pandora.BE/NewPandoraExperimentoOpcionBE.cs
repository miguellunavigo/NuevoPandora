using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.BE
{
    public class NewPandoraExperimentoOpcionBE
    {
        public int IdExperimentoOpcion { get; set; }
        public Nullable<int> IdOpcion { get; set; }
        public Nullable<int> IdExperimento { get; set; }
    }

    public class NewPandoraExperimentoOpcionRequest
    {
        public int IdExperimentoOpcion { get; set; }
        public Nullable<int> IdOpcion { get; set; }
        public Nullable<int> IdExperimento { get; set; }
    }
}
