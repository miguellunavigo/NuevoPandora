using BanBif.Nuevo.Pandora.BE;
//using BanBif.Nuevo.Pandora.BE.Conyugues;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.DA
{
    public class ExperimentoIndicadorDA
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public NewPandoraIndicadorResponse<List<NewPandoraIndicadorBE>> Listar(NewPandoraIndicadorRequest request)
        {
            NewPandoraIndicadorResponse<List<NewPandoraIndicadorBE>> response = new NewPandoraIndicadorResponse<List<NewPandoraIndicadorBE>>();
            try
            {
                using (panelEntities db = new panelEntities())
                {
                    //var listUsuario = db.NewPandora_Indicador.Where(p => p.IdExperimento == request.IdExperimento).ToList();
                    //response.data = new List<NewPandoraIndicadorBE>();
                    //listUsuario.ForEach(p =>
                    //{
                    //    response.data.Add(new NewPandoraIndicadorBE
                    //    {
                    //        IdExperimento = p.IdExperimento,
                    //        IdIndicador = p.IdIndicador,
                    //        Indicador = p.Indicador,

                    //        //Fecha=p.NewPandora_IndicadorRegistro.
                    //    });
                    //});


                    var list = (from m in db.NewPandora_Indicador
                                join n in db.NewPandora_IndicadorRegistro on m.IdIndicador equals n.IdIndicador
                                where m.IdExperimento == request.IdExperimento
                                group n by new { Indicador = m.Indicador, Anio = n.Fecha.Value.Year, Mes = n.Fecha.Value.Month } into g
                                select new NewPandoraIndicadorBE
                                {
                                    Indicador = g.Key.Indicador,
                                    Contador = g.Count(),
                                    Anio = g.Key.Anio,
                                    Mes = g.Key.Mes,
                                }).ToList();

                    response.data = list;
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
