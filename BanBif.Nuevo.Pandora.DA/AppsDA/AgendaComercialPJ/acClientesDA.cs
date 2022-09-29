using System.Linq;
using BanBif.Nuevo.Pandora.BE.AppsBE.AgendaComercialPJ;
using BanBif.Nuevo.Pandora.DA.ModelApp;
using System.Collections.Generic;

namespace BanBif.Nuevo.Pandora.DA.AppsDA.AgendaComercialPJ
{
    public class acClientesDA
    {
       
        public acListaClientesBE ListarClientes() {
            using (var db = new agendapjEntities()) {

                var result = new acListaClientesBE();
                var clientes = db.TBL_mAGENDACOMERCIAL_CLIENTE.ToList();
                result.Lista = new List<acClienteBE>();

                foreach (var item in clientes) {
                    
                    result.Lista.Add(new acClienteBE {
                        CodigoCliente = item.CODIGOCLIENTE,
                        RAZONSOCIAL = item.RAZON_SOCIAL,
                        RUC = item.RUC,
                        CROSS = item.CROSS_CLIENTE,
                        FACTURACION = item.FACTURACION,
                        GIRONEGOCIO = item.GIRO_NEGOCIO,
                        SCORE = item.SCORE,
                        SEGMENTO = item.SEGMENTO
                    });
                }

                return result;
            }            
        }
    }
}
