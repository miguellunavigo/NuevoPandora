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
    public class PropuestaApiController : ApiController
    {
        [Route("api/Propuesta/Listar")]
        [HttpPost]
        public IHttpActionResult Listar(NewPandoraPropuestaExperimentoRequest request)
        {
            var oBL = new PropuestaBL();
            return Json(oBL.Listar(request));
        }
        [Route("api/Propuesta/Obtener")]
        [HttpPost]
        public IHttpActionResult Obtener(NewPandoraPropuestaExperimentoRequest request)
        {
            var oBL = new PropuestaBL();
            return Json(oBL.Obtener(request));
        }
        [Route("api/Propuesta/Crear")]
        [HttpPost]
        public IHttpActionResult Crear(NewPandoraPropuestaExperimentoRequest request)
        {
            var oBL = new PropuestaBL();
            return Json(oBL.Crear(request));
        }
        [Route("api/Propuesta/Modificar")]
        [HttpPost]
        public IHttpActionResult Modificar(NewPandoraPropuestaExperimentoRequest request)
        {
            var oBL = new PropuestaBL();
            return Json(oBL.Modificar(request));
        }
    }
}
