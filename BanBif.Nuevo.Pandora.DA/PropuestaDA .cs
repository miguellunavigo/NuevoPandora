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
    public class PropuestaDA
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public NewPandoraPropuestaExperimentoResponse<List<NewPandoraPropuestaExperimentoBE>> Listar(NewPandoraPropuestaExperimentoRequest request)
        {
            NewPandoraPropuestaExperimentoResponse<List<NewPandoraPropuestaExperimentoBE>> response = new NewPandoraPropuestaExperimentoResponse<List<NewPandoraPropuestaExperimentoBE>>();
            try
            {
                using (panelEntities db = new panelEntities())
                {
                    var listUsuario = db.NewPandora_PropuestaExperimento.ToList();
                    response.data = new List<NewPandoraPropuestaExperimentoBE>();
                    listUsuario.ForEach(p =>
                    {
                        response.data.Add(new NewPandoraPropuestaExperimentoBE
                        {
                            IdPropuestaExperimento = p.IdPropuestaExperimento,
                            NombrePropuestaExperimento = p.NombrePropuestaExperimento,
                            Descripcion = p.Descripcion,
                            Tecnologia = p.Tecnologia,
                            Indicador = p.Indicador,
                            FechaSolicitud = p.FechaSolicitud,
                            IdUsuarioContacto = p.IdUsuarioContacto,
                            FlagPublico = p.FlagPublico,
                            IdStatusExperimento = p.IdStatusExperimento
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
        public NewPandoraPropuestaExperimentoResponse<NewPandoraPropuestaExperimentoBE> Obtener(NewPandoraPropuestaExperimentoRequest request)
        {
            NewPandoraPropuestaExperimentoResponse<NewPandoraPropuestaExperimentoBE> response = new NewPandoraPropuestaExperimentoResponse<NewPandoraPropuestaExperimentoBE>();
            try
            {
                using (panelEntities db = new panelEntities())
                {

                    var objNewPandoraPropuestaExperimento = db.NewPandora_PropuestaExperimento.Where(p => p.IdPropuestaExperimento == request.IdPropuestaExperimento).FirstOrDefault();
                    response.data = new NewPandoraPropuestaExperimentoBE();
                    response.data.IdPropuestaExperimento = objNewPandoraPropuestaExperimento.IdPropuestaExperimento;
                    response.data.NombrePropuestaExperimento = objNewPandoraPropuestaExperimento.NombrePropuestaExperimento;
                    response.data.Descripcion = objNewPandoraPropuestaExperimento.Descripcion;
                    response.data.Tecnologia = objNewPandoraPropuestaExperimento.Tecnologia;
                    response.data.Indicador = objNewPandoraPropuestaExperimento.Indicador;
                    response.data.FechaSolicitud = objNewPandoraPropuestaExperimento.FechaSolicitud;
                    response.data.IdUsuarioContacto = objNewPandoraPropuestaExperimento.IdUsuarioContacto;
                    response.data.FlagPublico = objNewPandoraPropuestaExperimento.FlagPublico;
                    response.data.IdStatusExperimento = objNewPandoraPropuestaExperimento.IdStatusExperimento;
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
        public NewPandoraPropuestaExperimentoResponse<int> Crear(NewPandoraPropuestaExperimentoRequest request)
        {
            NewPandoraPropuestaExperimentoResponse<int> response = new NewPandoraPropuestaExperimentoResponse<int>();
            try
            {
                using (panelEntities db = new panelEntities())
                {
                    var NewPandora_PropuestaExperimento = new NewPandora_PropuestaExperimento();
                    NewPandora_PropuestaExperimento.IdPropuestaExperimento = request.IdPropuestaExperimento;
                    NewPandora_PropuestaExperimento.NombrePropuestaExperimento = request.NombrePropuestaExperimento;
                    NewPandora_PropuestaExperimento.Descripcion = request.Descripcion;
                    NewPandora_PropuestaExperimento.Tecnologia = request.Tecnologia;
                    NewPandora_PropuestaExperimento.Indicador = request.Indicador;
                    NewPandora_PropuestaExperimento.FechaSolicitud = request.FechaSolicitud;
                    NewPandora_PropuestaExperimento.IdUsuarioContacto = request.IdUsuarioContacto;
                    NewPandora_PropuestaExperimento.FlagPublico = request.FlagPublico;
                    NewPandora_PropuestaExperimento.IdStatusExperimento = request.IdStatusExperimento;
                    db.NewPandora_PropuestaExperimento.Add(NewPandora_PropuestaExperimento);
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
        public NewPandoraPropuestaExperimentoResponse<int> Modificar(NewPandoraPropuestaExperimentoRequest request)
        {
            NewPandoraPropuestaExperimentoResponse<int> response = new NewPandoraPropuestaExperimentoResponse<int>();
            try
            {
                using (panelEntities db = new panelEntities())
                {

                    var NewPandora_PropuestaExperimento = db.NewPandora_PropuestaExperimento.Where(p => p.IdPropuestaExperimento == request.IdPropuestaExperimento).FirstOrDefault();
                    NewPandora_PropuestaExperimento.IdPropuestaExperimento = request.IdPropuestaExperimento;
                    NewPandora_PropuestaExperimento.NombrePropuestaExperimento = request.NombrePropuestaExperimento;
                    NewPandora_PropuestaExperimento.Descripcion = request.Descripcion;
                    NewPandora_PropuestaExperimento.Tecnologia = request.Tecnologia;
                    NewPandora_PropuestaExperimento.Indicador = request.Indicador;
                    NewPandora_PropuestaExperimento.FechaSolicitud = request.FechaSolicitud;
                    NewPandora_PropuestaExperimento.IdUsuarioContacto = request.IdUsuarioContacto;
                    NewPandora_PropuestaExperimento.FlagPublico = request.FlagPublico;
                    NewPandora_PropuestaExperimento.IdStatusExperimento = request.IdStatusExperimento;
                    db.Entry(NewPandora_PropuestaExperimento).State = EntityState.Modified;
                    db.SaveChanges();
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
