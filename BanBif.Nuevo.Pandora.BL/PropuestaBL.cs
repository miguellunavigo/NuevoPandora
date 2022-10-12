using BanBif.Nuevo.Pandora.BE;
using BanBif.Nuevo.Pandora.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.BL
{
    /// <summary>
    /// 
    /// </summary>
    public class PropuestaBL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public NewPandoraResponse<List<NewPandoraPropuestaExperimentoBE>> Listar(NewPandoraPropuestaExperimentoRequest request)
        {
            NewPandoraResponse<List<NewPandoraPropuestaExperimentoBE>> response = new NewPandoraResponse<List<NewPandoraPropuestaExperimentoBE>>();
            try
            {
                var PropuestaDA = new PropuestaDA();
                response = PropuestaDA.Listar(request);
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public NewPandoraResponse<NewPandoraPropuestaExperimentoBE> Obtener(NewPandoraPropuestaExperimentoRequest request)
        {
            NewPandoraResponse<NewPandoraPropuestaExperimentoBE> response = new NewPandoraResponse<NewPandoraPropuestaExperimentoBE>();
            try
            {
                var PropuestaDA = new PropuestaDA();
                response = PropuestaDA.Obtener(request);
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public NewPandoraResponse<int> Crear(NewPandoraPropuestaExperimentoRequest request)
        {
            NewPandoraResponse<int> response = new NewPandoraResponse<int>();
            try
            {
                var PropuestaDA = new PropuestaDA();
                response = PropuestaDA.Crear(request);
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public NewPandoraResponse<int> Modificar(NewPandoraPropuestaExperimentoRequest request)
        {
            NewPandoraResponse<int> response = new NewPandoraResponse<int>();
            try
            {
                var PropuestaDA = new PropuestaDA();
                response = PropuestaDA.Modificar(request);
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }
    }
}
