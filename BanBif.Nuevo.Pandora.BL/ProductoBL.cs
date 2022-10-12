using BanBif.Nuevo.Pandora.BE;
using BanBif.Nuevo.Pandora.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.BL
{
    public class ProductoBL
    {

        public NewPandoraResponse<List<NewPandoraProductoBE>> Listar()
        {
            NewPandoraResponse<List<NewPandoraProductoBE>> response = new NewPandoraResponse<List<NewPandoraProductoBE>>();
            try
            {
                var rolDA = new ProductoDA();
                response = rolDA.Listar();
            }
            catch (Exception ex)
            {

                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }

    }
}
