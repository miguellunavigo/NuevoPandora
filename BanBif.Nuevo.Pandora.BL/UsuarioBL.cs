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

        public NewPandoraUsuarioResponse<List<NewPandoraUsuarioBE>> Listar(NewPandoraUsuarioRequest request)
        {
            NewPandoraUsuarioResponse<List<NewPandoraUsuarioBE>> response = new NewPandoraUsuarioResponse<List<NewPandoraUsuarioBE>>();
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

        public NewPandoraUsuarioResponse<NewPandoraUsuarioBE> Obtener(NewPandoraUsuarioRequest request)
        {
            NewPandoraUsuarioResponse<NewPandoraUsuarioBE> response = new NewPandoraUsuarioResponse<NewPandoraUsuarioBE>();
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

        public NewPandoraUsuarioResponse<int> Crear(NewPandoraUsuarioRequest request)
        {
            NewPandoraUsuarioResponse<int> response = new NewPandoraUsuarioResponse<int>();
            try
            {
                var usuarioDA = new UsuarioDA();
                request.Contrasenia = BanBif.Comunes.Util.Seguridad.Encrypt("abcd1234");
                response = usuarioDA.Crear(request);
            }
            catch (Exception ex)
            {

                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }
        public NewPandoraUsuarioResponse<int> Modificar(NewPandoraUsuarioRequest request)
        {
            NewPandoraUsuarioResponse<int> response = new NewPandoraUsuarioResponse<int>();
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
