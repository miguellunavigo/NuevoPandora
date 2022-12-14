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

        public NewPandoraResponse<List<NewPandoraExperimentoStatusBE>> Listar(NewPandoraExperimentoStatusRequest request)
        {
            NewPandoraResponse<List<NewPandoraExperimentoStatusBE>> response = new NewPandoraResponse<List<NewPandoraExperimentoStatusBE>>();
            try
            {
                var experimentoStatusDA = new ExperimentoStatusDA();
                response = experimentoStatusDA.Listar(request);
            }
            catch (Exception ex)
            {

                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }

    }
}
