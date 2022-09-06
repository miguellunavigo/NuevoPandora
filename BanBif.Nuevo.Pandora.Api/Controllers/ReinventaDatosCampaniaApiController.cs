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
    public class ReinventaDatosCampaniaApiController : ApiController
    {
        [Route("api/ReinventaDatosCampania/Listar")]
        [HttpPost]
        public IHttpActionResult Listar(ReinventaDatosCampaniaRequest request)
        {
            var oBL = new ReinventaDatosCampaniaBL();
            return Json(oBL.Listar(request));
        }
        [Route("api/ReinventaDatosCampania/Obtener")]
        [HttpPost]
        public IHttpActionResult Obtener(ReinventaDatosCampaniaRequest request)
        {
            var oBL = new ReinventaDatosCampaniaBL();
            return Json(oBL.Obtener(request));
        }
        [Route("api/ReinventaDatosCampania/Crear")]
        [HttpPost]
        public IHttpActionResult Crear(ReinventaDatosCampaniaRequest request)
        {
            var oBL = new ReinventaDatosCampaniaBL();
            return Json(oBL.Crear(request));
        }
        [Route("api/ReinventaDatosCampania/Modificar")]
        [HttpPost]
        public IHttpActionResult Modificar(ReinventaDatosCampaniaRequest request)
        {
            var oBL = new ReinventaDatosCampaniaBL();
            return Json(oBL.Modificar(request));
        }
    }
}
