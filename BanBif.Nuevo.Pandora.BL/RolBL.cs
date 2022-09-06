using BanBif.Nuevo.Pandora.BE;
using BanBif.Nuevo.Pandora.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.BL
{
    public class RolBL
    {

        public NewPandoraRolResponse Listar(int IdOrdenSuperior)
        {
            NewPandoraRolResponse response = new NewPandoraRolResponse();
            try
            {
                var rolDA = new RolDA();
                response = rolDA.Listar(IdOrdenSuperior);
            }
            catch (Exception ex)
            {

                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }

    }
}
