using BanBif.Nuevo.Pandora.BE;
using BanBif.Nuevo.Pandora.DA.ModelApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.DA
{
    public class ProductoDA
    {
        public NewPandoraResponse<List<NewPandoraProductoBE>> Listar()
        {
            NewPandoraResponse<List<NewPandoraProductoBE>> response = new NewPandoraResponse<List<NewPandoraProductoBE>>();
            try
            {
                using (panelEntities db = new panelEntities())
                {

                    var listRol = db.NewPandora_Productos.Where(p => p.Estado == true).ToList();
                    response.data = new List<NewPandoraProductoBE>();
                    listRol.ForEach(p => { response.data.Add(new NewPandoraProductoBE { IdProducto = p.IdProducto, Nombre = p.Nombre }); });
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
