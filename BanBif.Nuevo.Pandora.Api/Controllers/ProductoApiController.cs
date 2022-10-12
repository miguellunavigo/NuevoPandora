using BanBif.Nuevo.Pandora.BE;
using BanBif.Nuevo.Pandora.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BanBif.Nuevo.Pandora.Api.Controllers
{
    public class ProductoApiController : ApiController
    {
        [Route("api/Producto/Listar")]
        [HttpPost]
        public IHttpActionResult Listar(NewPandoraProductoRequest request)
        {
            var oBL = new ProductoBL();
            return Json(oBL.Listar());
        }        
    }
}
