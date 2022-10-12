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
    public class ExperimentoBL
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
                var ExperimentoDA = new ExperimentoDA();
                response = ExperimentoDA.Listar(request);
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
        public NewPandoraResponse<NewPandoraExperimentoBE> Obtener(NewPandoraExperimentoRequest request)
        {
            NewPandoraResponse<NewPandoraExperimentoBE> response = new NewPandoraResponse<NewPandoraExperimentoBE>();
            try
            {
                var ExperimentoDA = new ExperimentoDA();
                response = ExperimentoDA.Obtener(request);
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
        public NewPandoraResponse<int> Crear(NewPandoraExperimentoRequest request)
        {
            NewPandoraResponse<int> response = new NewPandoraResponse<int>();
            try
            {
                var ExperimentoDA = new ExperimentoDA();
                response = ExperimentoDA.Crear(request);
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
        public NewPandoraResponse<int> Modificar(NewPandoraExperimentoRequest request)
        {
            NewPandoraResponse<int> response = new NewPandoraResponse<int>();
            try
            {
                var ExperimentoDA = new ExperimentoDA();
                response = ExperimentoDA.Modificar(request);
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }
    }
}
