using BanBif.Nuevo.Pandora.BE;
using BanBif.Nuevo.Pandora.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.BL
{
    public class LoginBL
    {

        public NewPandoraLoginResponse Autenticacion(string usUsuarioWindows, string password)
        {
            NewPandoraLoginResponse response = new NewPandoraLoginResponse();
            try
            {
                var loginDA = new LoginDA();
                response = loginDA.Autenticacion(usUsuarioWindows, password);
            }
            catch (Exception ex)
            {

                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }

    }
}
