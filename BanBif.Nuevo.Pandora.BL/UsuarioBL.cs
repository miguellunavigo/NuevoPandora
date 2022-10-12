using BanBif.Nuevo.Pandora.BE;
using BanBif.Nuevo.Pandora.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.BL
{
    public class UsuarioBL
    {

        public NewPandoraResponse<List<NewPandoraUsuarioBE>> Listar(NewPandoraUsuarioRequest request)
        {
            NewPandoraResponse<List<NewPandoraUsuarioBE>> response = new NewPandoraResponse<List<NewPandoraUsuarioBE>>();
            try
            {
                var usuarioDA = new UsuarioDA();
                response = usuarioDA.Listar(request);
            }
            catch (Exception ex)
            {

                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }

        public NewPandoraResponse<NewPandoraUsuarioBE> Obtener(NewPandoraUsuarioRequest request)
        {
            NewPandoraResponse<NewPandoraUsuarioBE> response = new NewPandoraResponse<NewPandoraUsuarioBE>();
            try
            {
                var usuarioDA = new UsuarioDA();
                response = usuarioDA.Obtener(request);
            }
            catch (Exception ex)
            {

                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }

        public NewPandoraResponse<int> Crear(NewPandoraUsuarioRequest request)
        {
            NewPandoraResponse<int> response = new NewPandoraResponse<int>();
            try
            {
                var usuarioDA = new UsuarioDA();
                request.Contrasenia = BanBif.Comunes.Util.Seguridad.Encrypt("123456");
                response = usuarioDA.Crear(request);
            }
            catch (Exception ex)
            {

                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }
        public NewPandoraResponse<int> Modificar(NewPandoraUsuarioRequest request)
        {
            NewPandoraResponse<int> response = new NewPandoraResponse<int>();
            try
            {
                var usuarioDA = new UsuarioDA();
                response = usuarioDA.Modificar(request);
            }
            catch (Exception ex)
            {

                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }
    }
}
