using BanBif.Nuevo.Pandora.BE;
using BanBif.Nuevo.Pandora.DA.ModelApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.DA
{
    public class ExperimentoStatusDA
    {
        public NewPandoraResponse<List<NewPandoraExperimentoStatusBE>> Listar(NewPandoraExperimentoStatusRequest request)
        {
            NewPandoraResponse<List<NewPandoraExperimentoStatusBE>> response = new NewPandoraResponse<List<NewPandoraExperimentoStatusBE>>();
            try
            {
                using (panelEntities db = new panelEntities())
                {

                    var listRol = db.NewPandora_StatusExperimento.Where(p => p.FlagExperimento == request.FlagExperimento).OrderBy(p => p.Orden).ToList();
                    response.data = new List<NewPandoraExperimentoStatusBE>();
                    listRol.ForEach(p => { response.data.Add(new NewPandoraExperimentoStatusBE { IdStatusExperimento = p.IdStatusExperimento, Status = p.Status }); });
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }
    }
}
