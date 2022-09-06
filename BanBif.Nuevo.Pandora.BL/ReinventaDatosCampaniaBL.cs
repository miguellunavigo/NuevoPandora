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
    public class ReinventaDatosCampaniaBL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ReinventaDatosCampaniaResponse<List<ReinventaDatosCampaniaBE>> Listar(ReinventaDatosCampaniaRequest request)
        {
            ReinventaDatosCampaniaResponse<List<ReinventaDatosCampaniaBE>> response = new ReinventaDatosCampaniaResponse<List<ReinventaDatosCampaniaBE>>();
            try
            {
                var ReinventaDatosCampaniaDA = new ReinventaDatosCampaniaDA();
                response = ReinventaDatosCampaniaDA.Listar(request);
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
        public ReinventaDatosCampaniaResponse<ReinventaDatosCampaniaBE> Obtener(ReinventaDatosCampaniaRequest request)
        {
            ReinventaDatosCampaniaResponse<ReinventaDatosCampaniaBE> response = new ReinventaDatosCampaniaResponse<ReinventaDatosCampaniaBE>();
            try
            {
                var ReinventaDatosCampaniaDA = new ReinventaDatosCampaniaDA();
                response = ReinventaDatosCampaniaDA.Obtener(request);
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
        public ReinventaDatosCampaniaResponse<int> Crear(ReinventaDatosCampaniaRequest request)
        {
            ReinventaDatosCampaniaResponse<int> response = new ReinventaDatosCampaniaResponse<int>();
            try
            {
                var ReinventaDatosCampaniaDA = new ReinventaDatosCampaniaDA();
                response = ReinventaDatosCampaniaDA.Crear(request);
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
        public ReinventaDatosCampaniaResponse<int> Modificar(ReinventaDatosCampaniaRequest request)
        {
            ReinventaDatosCampaniaResponse<int> response = new ReinventaDatosCampaniaResponse<int>();
            try
            {
                var ReinventaDatosCampaniaDA = new ReinventaDatosCampaniaDA();
                response = ReinventaDatosCampaniaDA.Modificar(request);
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }
    }
}
