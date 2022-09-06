using BanBif.Nuevo.Pandora.BE;
//using BanBif.Nuevo.Pandora.BE.Conyugues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.DA
{
    public class RolDA
    {
        public NewPandoraRolResponse Listar(int IdOrdenSuperior)
        {
            NewPandoraRolResponse response = new NewPandoraRolResponse();
            try
            {
                using (panelEntities db = new panelEntities())
                {

                    var listRol = db.NewPandora_Rol.Where(p => p.Orden > IdOrdenSuperior || 1 == IdOrdenSuperior).ToList();
                    response.Data = new List<NewPandoraRolBE>();
                    listRol.ForEach(p => { response.Data.Add(new NewPandoraRolBE { IdRol = p.IdRol, NombreRol = p.NombreRol }); });
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }
    }
}
