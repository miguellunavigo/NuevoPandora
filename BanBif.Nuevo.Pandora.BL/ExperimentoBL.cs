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
        public NewPandoraExperimentoResponse<List<NewPandoraExperimentoBE>> Listar(NewPandoraExperimentoRequest request)
        {
            NewPandoraExperimentoResponse<List<NewPandoraExperimentoBE>> response = new NewPandoraExperimentoResponse<List<NewPandoraExperimentoBE>>();
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
        public NewPandoraExperimentoResponse<NewPandoraExperimentoBE> Obtener(NewPandoraExperimentoRequest request)
        {
            NewPandoraExperimentoResponse<NewPandoraExperimentoBE> response = new NewPandoraExperimentoResponse<NewPandoraExperimentoBE>();
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
        public NewPandoraExperimentoResponse<int> Crear(NewPandoraExperimentoRequest request)
        {
            NewPandoraExperimentoResponse<int> response = new NewPandoraExperimentoResponse<int>();
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
        public NewPandoraExperimentoResponse<int> Modificar(NewPandoraExperimentoRequest request)
        {
            NewPandoraExperimentoResponse<int> response = new NewPandoraExperimentoResponse<int>();
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

        public NewPandoraIndicadorResponse<List<NewPandoraIndicadorGraficaBE>> Listar(NewPandoraIndicadorRequest request)
        {
            NewPandoraIndicadorResponse<List<NewPandoraIndicadorGraficaBE>> response = new NewPandoraIndicadorResponse<List<NewPandoraIndicadorGraficaBE>>();
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
    }
}
