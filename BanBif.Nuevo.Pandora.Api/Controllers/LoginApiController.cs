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
    public class LoginApiController : ApiController
    {
        [Route("api/Login/Autenticacion")]
        [HttpPost]
        public IHttpActionResult Autenticacion(NewPandoraLoginRequest request)
        {
            var oBL = new LoginBL();
            return Json(oBL.Autenticacion(request.Username, request.Password));
        }        
    }
}
