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
        [Route("api/AgendaComercial/ObtenerClientes")]
        [HttpPost]
        public IHttpActionResult OBtener(acListaClienteRequest request)
        {
            var oBL = new acClienteBL();
            return Json(oBL.ObtenerClientes(request));
        }

        [Route("api/AgendaComercial/CrearClientesContacto")]
        [HttpPost]
        public IHttpActionResult Crear(acListaClienteContactoRequest request)
        {
            var oBL = new acClienteBL();
            return Json(oBL.CrearClientesContacto(request));
        }
        [Route("api/AgendaComercial/ListarClientesContacto")]
        [HttpPost]
        public IHttpActionResult ListarClientesContacto(acListaClienteContactoRequest request)
        {
            var oBL = new acClienteBL();
            return Json(oBL.ListarClientesContacto(request));
        }
        [Route("api/AgendaComercial/ObtenerClientesContacto")]
        [HttpPost]
        public IHttpActionResult ObtenerClientesContacto(acListaClienteContactoRequest request)
        {
            var oBL = new acClienteBL();
            return Json(oBL.ObtenerClientesContacto(request));
        }
        [Route("api/AgendaComercial/ListarClienteContactoComentarios")]
        [HttpPost]
        public IHttpActionResult ListarClienteContactoComentarios(acListaClienteContactoComentarioRequest request)
        {
            var oBL = new acClienteBL();
            return Json(oBL.ListarClienteContactoComentarios(request));
        }
    }
}
