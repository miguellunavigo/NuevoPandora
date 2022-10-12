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
        public NewPandoraResponse<List<ReinventaDatosCampaniaBE>> Listar(ReinventaDatosCampaniaRequest request)
        {
            NewPandoraResponse<List<ReinventaDatosCampaniaBE>> response = new NewPandoraResponse<List<ReinventaDatosCampaniaBE>>();
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
        public NewPandoraResponse<ReinventaDatosCampaniaBE> Obtener(ReinventaDatosCampaniaRequest request)
        {
            NewPandoraResponse<ReinventaDatosCampaniaBE> response = new NewPandoraResponse<ReinventaDatosCampaniaBE>();
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
        public NewPandoraResponse<int> Crear(ReinventaDatosCampaniaRequest request)
        {
            NewPandoraResponse<int> response = new NewPandoraResponse<int>();
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
        public NewPandoraResponse<int> Modificar(ReinventaDatosCampaniaRequest request)
        {
            NewPandoraResponse<int> response = new NewPandoraResponse<int>();
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
