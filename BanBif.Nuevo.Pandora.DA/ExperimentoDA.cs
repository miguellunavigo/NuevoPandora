using BanBif.Nuevo.Pandora.BE;
using BanBif.Nuevo.Pandora.DA.ModelApp;
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
        public NewPandoraResponse<List<NewPandoraExperimentoBE>> Listar(NewPandoraExperimentoRequest request)
        {
            NewPandoraResponse<List<NewPandoraExperimentoBE>> response = new NewPandoraResponse<List<NewPandoraExperimentoBE>>();
            try
            {
                using (panelEntities db = new panelEntities())
                {
                    var listUsuario = db.NewPandora_Experimento.Where(p => p.IdStatusExperimento == request.IdStatusExperimento || request.IdStatusExperimento == null && p.NewPandora_StatusExperimento.FlagExperimento == true).ToList();
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
                            StatusExperimento = p.NewPandora_StatusExperimento.Status,
                            StatusOrden = p.NewPandora_StatusExperimento.Orden.Value
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
        public NewPandoraResponse<NewPandoraExperimentoBE> Obtener(NewPandoraExperimentoRequest request)
        {
            NewPandoraResponse<NewPandoraExperimentoBE> response = new NewPandoraResponse<NewPandoraExperimentoBE>();
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
                    response.data.FechaLanzamiento = objNewPandoraExperimento.FechaLanzamiento;
                    response.data.IdProducto = objNewPandoraExperimento.IdProducto;
                    response.data.FechaInicioCronograma = objNewPandoraExperimento.FechaInicioCronograma;
                    response.data.FechaFinCronograma = objNewPandoraExperimento.FechaFinCronograma;
                    response.data.FlagExitosRapidos = objNewPandoraExperimento.FlagExitosRapidos;
                    response.data.Plantilla = objNewPandoraExperimento.Plantilla;
                    response.data.TipoUsuario = objNewPandoraExperimento.TipoUsuario;
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
        public NewPandoraResponse<int> Crear(NewPandoraExperimentoRequest request)
        {
            NewPandoraResponse<int> response = new NewPandoraResponse<int>();
            try
            {
                using (panelEntities db = new panelEntities())
                {
                    var newPandoraExperimento = new NewPandora_Experimento();
                    newPandoraExperimento.NombreExperimento = request.NombreExperimento;
                    newPandoraExperimento.Descripcion = request.Descripcion;
                    newPandoraExperimento.Tecnologia = request.Tecnologia;
                    newPandoraExperimento.DesarrolladoPor = request.DesarrolladoPor;
                    newPandoraExperimento.FechaSolicitud = request.FechaSolicitud;
                    newPandoraExperimento.FechaPublicacion = request.FechaPublicacion;
                    newPandoraExperimento.Url = request.Url;
                    newPandoraExperimento.IdUsuarioContacto = request.IdUsuarioContacto;
                    newPandoraExperimento.FlagPublico = request.FlagPublico;
                    newPandoraExperimento.IdStatusExperimento = request.IdStatusExperimento;

                    newPandoraExperimento.FechaLanzamiento = request.FechaLanzamiento;
                    newPandoraExperimento.IdProducto = request.IdProducto;
                    newPandoraExperimento.FechaInicioCronograma = request.FechaInicioCronograma;
                    newPandoraExperimento.FechaFinCronograma = request.FechaFinCronograma;
                    newPandoraExperimento.FlagExitosRapidos = request.FlagExitosRapidos;
                    newPandoraExperimento.Plantilla = request.Plantilla;
                    newPandoraExperimento.TipoUsuario = request.TipoUsuario;
                    db.NewPandora_Experimento.Add(newPandoraExperimento);
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
        public NewPandoraResponse<int> Modificar(NewPandoraExperimentoRequest request)
        {
            NewPandoraResponse<int> response = new NewPandoraResponse<int>();
            try
            {
                using (panelEntities db = new panelEntities())
                {

                    var newPandoraExperimento = db.NewPandora_Experimento.Where(p => p.IdExperimento == request.IdExperimento).FirstOrDefault();
                    newPandoraExperimento.NombreExperimento = request.NombreExperimento;
                    newPandoraExperimento.Descripcion = request.Descripcion;
                    newPandoraExperimento.Tecnologia = request.Tecnologia;
                    newPandoraExperimento.DesarrolladoPor = request.DesarrolladoPor;                  
                    newPandoraExperimento.FechaSolicitud = request.FechaSolicitud;
                    newPandoraExperimento.FechaPublicacion = request.FechaPublicacion;
                    newPandoraExperimento.Url = request.Url;                    
                    newPandoraExperimento.FlagPublico = request.FlagPublico;
                    newPandoraExperimento.IdStatusExperimento = request.IdStatusExperimento;
                    newPandoraExperimento.FechaLanzamiento = request.FechaLanzamiento;
                    newPandoraExperimento.IdProducto = request.IdProducto;
                    newPandoraExperimento.FechaInicioCronograma = request.FechaInicioCronograma;
                    newPandoraExperimento.FechaFinCronograma = request.FechaFinCronograma;
                    newPandoraExperimento.FlagExitosRapidos = request.FlagExitosRapidos;
                    newPandoraExperimento.Plantilla = request.Plantilla;
                    newPandoraExperimento.TipoUsuario = request.TipoUsuario;
                    db.Entry(newPandoraExperimento).State = EntityState.Modified;
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
