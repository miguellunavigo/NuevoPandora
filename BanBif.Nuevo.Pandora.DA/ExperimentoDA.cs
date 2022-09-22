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
    public class ExperimentoDA
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public NewPandoraExperimentoResponse<List<NewPandoraExperimentoBE>> Listar(NewPandoraExperimentoRequest request)
        {
            NewPandoraExperimentoResponse<List<NewPandoraExperimentoBE>> response = new NewPandoraExperimentoResponse<List<NewPandoraExperimentoBE>>();
            try
            {
                using (panelEntities db = new panelEntities())
                {
                    var listUsuario = db.NewPandora_Experimento.Where(p => p.IdStatusExperimento == request.IdStatusExperimento || request.IdStatusExperimento == null).ToList();
                    response.data = new List<NewPandoraExperimentoBE>();
                    listUsuario.ForEach(p =>
                    {
                        response.data.Add(new NewPandoraExperimentoBE
                        {
                            IdExperimento = p.IdExperimento,
                            NombreExperimento = p.NombreExperimento,
                            Descripcion = p.Descripcion,
                            Tecnologia = p.Tecnologia,
                            DesarrolladoPor = p.DesarrolladoPor,
                            FechaSolicitud = p.FechaSolicitud,
                            FechaPublicacion = p.FechaPublicacion,
                            Url = p.Url,
                            IdUsuarioContacto = p.IdUsuarioContacto,
                            FlagPublico = p.FlagPublico,
                            IdStatusExperimento = p.IdStatusExperimento,
                            StatusExperimento = p.NewPandora_StatusExperimento.Status
                        });
                    });
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public NewPandoraExperimentoResponse<NewPandoraExperimentoBE> Obtener(NewPandoraExperimentoRequest request)
        {
            NewPandoraExperimentoResponse<NewPandoraExperimentoBE> response = new NewPandoraExperimentoResponse<NewPandoraExperimentoBE>();
            try
            {
                using (panelEntities db = new panelEntities())
                {

                    var objNewPandoraExperimento = db.NewPandora_Experimento.Where(p => p.IdExperimento == request.IdExperimento).FirstOrDefault();
                    response.data = new NewPandoraExperimentoBE();
                    response.data.IdExperimento = objNewPandoraExperimento.IdExperimento;
                    response.data.NombreExperimento = objNewPandoraExperimento.NombreExperimento;
                    response.data.Descripcion = objNewPandoraExperimento.Descripcion;
                    response.data.Tecnologia = objNewPandoraExperimento.Tecnologia;
                    response.data.DesarrolladoPor = objNewPandoraExperimento.DesarrolladoPor;
                    response.data.FechaSolicitud = objNewPandoraExperimento.FechaSolicitud;
                    response.data.FechaPublicacion = objNewPandoraExperimento.FechaPublicacion;
                    response.data.Url = objNewPandoraExperimento.Url;
                    response.data.IdUsuarioContacto = objNewPandoraExperimento.IdUsuarioContacto;
                    response.data.FlagPublico = objNewPandoraExperimento.FlagPublico;
                    response.data.IdStatusExperimento = objNewPandoraExperimento.IdStatusExperimento;
                    response.data.StatusExperimento = objNewPandoraExperimento.NewPandora_StatusExperimento.Status;
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public NewPandoraExperimentoResponse<int> Crear(NewPandoraExperimentoRequest request)
        {
            NewPandoraExperimentoResponse<int> response = new NewPandoraExperimentoResponse<int>();
            try
            {
                using (panelEntities db = new panelEntities())
                {
                    var NewPandora_Experimento = new NewPandora_Experimento();
                    NewPandora_Experimento.NombreExperimento = request.NombreExperimento;
                    NewPandora_Experimento.Descripcion = request.Descripcion;
                    NewPandora_Experimento.Tecnologia = request.Tecnologia;
                    NewPandora_Experimento.DesarrolladoPor = request.DesarrolladoPor;
                    NewPandora_Experimento.FechaSolicitud = request.FechaSolicitud;
                    NewPandora_Experimento.FechaPublicacion = request.FechaPublicacion;
                    NewPandora_Experimento.Url = request.Url;
                    NewPandora_Experimento.IdUsuarioContacto = request.IdUsuarioContacto;
                    NewPandora_Experimento.FlagPublico = request.FlagPublico;
                    NewPandora_Experimento.IdStatusExperimento = request.IdStatusExperimento;
                    db.NewPandora_Experimento.Add(NewPandora_Experimento);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public NewPandoraExperimentoResponse<int> Modificar(NewPandoraExperimentoRequest request)
        {
            NewPandoraExperimentoResponse<int> response = new NewPandoraExperimentoResponse<int>();
            try
            {
                using (panelEntities db = new panelEntities())
                {

                    var NewPandora_Experimento = db.NewPandora_Experimento.Where(p => p.IdExperimento == request.IdExperimento).FirstOrDefault();
                    NewPandora_Experimento.NombreExperimento = request.NombreExperimento;
                    NewPandora_Experimento.Descripcion = request.Descripcion;
                    NewPandora_Experimento.Tecnologia = request.Tecnologia;
                    NewPandora_Experimento.DesarrolladoPor = request.DesarrolladoPor;
                    //NewPandora_Experimento.Indicador = request.Indicador;
                    NewPandora_Experimento.FechaSolicitud = request.FechaSolicitud;
                    NewPandora_Experimento.FechaPublicacion = request.FechaPublicacion;
                    NewPandora_Experimento.Url = request.Url;
                    //NewPandora_Experimento.IdUsuarioContacto = request.IdUsuarioContacto;
                    NewPandora_Experimento.FlagPublico = request.FlagPublico;
                    NewPandora_Experimento.IdStatusExperimento = request.IdStatusExperimento;

                    db.Entry(NewPandora_Experimento).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }

        public NewPandoraIndicadorResponse<List<NewPandoraIndicadorGraficaBE>> Listar(NewPandoraIndicadorRequest request)
        {
            NewPandoraIndicadorResponse<List<NewPandoraIndicadorGraficaBE>> response = new NewPandoraIndicadorResponse<List<NewPandoraIndicadorGraficaBE>>();
            try
            {
                using (panelEntities db = new panelEntities())
                {
                    var list = (from m in db.NewPandora_Indicador
                                join n in db.NewPandora_IndicadorRegistro on m.IdIndicador equals n.IdIndicador
                                where m.IdExperimento == request.IdExperimento
                                group n by new { Indicador = m.Indicador, Anio = n.Fecha.Value.Year, Mes = n.Fecha.Value.Month } into g
                                orderby g.Key.Indicador, g.Key.Anio, g.Key.Mes
                                select new NewPandoraIndicadorGraficaBE
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
