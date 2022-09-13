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
        public NewPandoraPropuestaExperimentoResponse<List<NewPandoraPropuestaExperimentoBE>> Listar(NewPandoraPropuestaExperimentoRequest request)
        {
            NewPandoraPropuestaExperimentoResponse<List<NewPandoraPropuestaExperimentoBE>> response = new NewPandoraPropuestaExperimentoResponse<List<NewPandoraPropuestaExperimentoBE>>();
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
        public NewPandoraPropuestaExperimentoResponse<NewPandoraPropuestaExperimentoBE> Obtener(NewPandoraPropuestaExperimentoRequest request)
        {
            NewPandoraPropuestaExperimentoResponse<NewPandoraPropuestaExperimentoBE> response = new NewPandoraPropuestaExperimentoResponse<NewPandoraPropuestaExperimentoBE>();
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
        public NewPandoraPropuestaExperimentoResponse<int> Crear(NewPandoraPropuestaExperimentoRequest request)
        {
            NewPandoraPropuestaExperimentoResponse<int> response = new NewPandoraPropuestaExperimentoResponse<int>();
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
        public NewPandoraPropuestaExperimentoResponse<int> Modificar(NewPandoraPropuestaExperimentoRequest request)
        {
            NewPandoraPropuestaExperimentoResponse<int> response = new NewPandoraPropuestaExperimentoResponse<int>();
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
