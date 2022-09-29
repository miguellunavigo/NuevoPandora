using BanBif.Nuevo.Pandora.BE.AppsBE.AgendaComercialPJ;
using BanBif.Nuevo.Pandora.BL.AppsBL.AgendaComercialPJ;
using System.Web.Http;

namespace BanBif.Nuevo.Pandora.Api.Controllers.AgendaComercialPJ
{
    public class acClienteController : ApiController
    {
        [Route("api/AgendaComercial/ListarClientes")]
        [HttpPost]
        public IHttpActionResult Listar(acListaClienteRequest request)
        {
            var oBL = new acClienteBL();
            return Json(oBL.ListarClientes(request));
        }
    }
}
