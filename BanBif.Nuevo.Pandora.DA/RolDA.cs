using BanBif.Nuevo.Pandora.BE;
using BanBif.Nuevo.Pandora.DA.ModelApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.DA
{
    public class RolDA
    {
        public NewPandoraResponse<List<NewPandoraRolBE>> Listar(int IdOrdenSuperior)
        {
            NewPandoraResponse<List<NewPandoraRolBE>> response = new NewPandoraResponse<List<NewPandoraRolBE>>();
            try
            {
                using (panelEntities db = new panelEntities())
                {

                    var listRol = db.NewPandora_Rol.Where(p => p.Orden > IdOrdenSuperior || 1 == IdOrdenSuperior).ToList();
                    response.data = new List<NewPandoraRolBE>();
                    listRol.ForEach(p => { response.data.Add(new NewPandoraRolBE { IdRol = p.IdRol, NombreRol = p.NombreRol }); });
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
