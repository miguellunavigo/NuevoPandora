using BanBif.Nuevo.Pandora.BE;
using BanBif.Nuevo.Pandora.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.BL
{
    public class ExperimentoStatusBL
    {

        public NewPandoraExperimentoStatusResponse Listar()
        {
            NewPandoraExperimentoStatusResponse response = new NewPandoraExperimentoStatusResponse();
            try
            {
                var experimentoStatusDA = new ExperimentoStatusDA();
                response = experimentoStatusDA.Listar();
            }
            catch (Exception ex)
            {

                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }

    }
}
