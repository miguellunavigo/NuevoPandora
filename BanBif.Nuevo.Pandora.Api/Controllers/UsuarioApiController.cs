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
    public class UsuarioApiController : ApiController
    {
        [Route("api/Usuario/Listar")]
        [HttpPost]
        public IHttpActionResult Listar(NewPandoraUsuarioRequest request)
        {
            var oBL = new UsuarioBL();
            return Json(oBL.Listar(request));
        }
        [Route("api/Usuario/Obtener")]
        [HttpPost]
        public IHttpActionResult Obtener(NewPandoraUsuarioRequest request)
        {
            var oBL = new UsuarioBL();
            return Json(oBL.Obtener(request));
        }
        [Route("api/Usuario/Crear")]
        [HttpPost]
        public IHttpActionResult Crear(NewPandoraUsuarioRequest request)
        {
            var oBL = new UsuarioBL();
            return Json(oBL.Crear(request));
        }
        [Route("api/Usuario/Modificar")]
        [HttpPost]
        public IHttpActionResult Modificar(NewPandoraUsuarioRequest request)
        {
            var oBL = new UsuarioBL();
            return Json(oBL.Modificar(request));
        }
    }
}
