using BanBif.Nuevo.Pandora.BE;
//using BanBif.Nuevo.Pandora.BE.Conyugues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.DA
{
    public class ExperimentoStatusDA
    {
        public NewPandoraExperimentoStatusResponse Listar()
        {
            NewPandoraExperimentoStatusResponse response = new NewPandoraExperimentoStatusResponse();
            try
            {
                using (panelEntities db = new panelEntities())
                {

                    var listRol = db.NewPandora_StatusExperimento.ToList();
                    response.Data = new List<NewPandoraExperimentoStatusBE>();
                    listRol.ForEach(p => { response.Data.Add(new NewPandoraExperimentoStatusBE { IdStatusExperimento = p.IdStatusExperimento, Status = p.Status }); });
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
