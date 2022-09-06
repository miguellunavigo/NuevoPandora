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
    public class RolApiController : ApiController
    {
        [Route("api/Rol/Listar")]
        [HttpPost]
        public IHttpActionResult Listar(NewPandoraRolRequest request)
        {
            var oBL = new RolBL();
            return Json(oBL.Listar(request.IdRol));
        }        
    }
}
