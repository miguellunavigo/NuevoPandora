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
    public class ExperimentoApiController : ApiController
    {
        [Route("api/Experimento/Listar")]
        [HttpPost]
        public IHttpActionResult Listar(NewPandoraExperimentoRequest request)
        {
            var oBL = new ExperimentoBL();
            return Json(oBL.Listar(request));
        }
        [Route("api/Experimento/Obtener")]
        [HttpPost]
        public IHttpActionResult Obtener(NewPandoraExperimentoRequest request)
        {
            var oBL = new ExperimentoBL();
            return Json(oBL.Obtener(request));
        }
        [Route("api/Experimento/Crear")]
        [HttpPost]
        public IHttpActionResult Crear(NewPandoraExperimentoRequest request)
        {
            var oBL = new ExperimentoBL();
            return Json(oBL.Crear(request));
        }
        [Route("api/Experimento/Modificar")]
        [HttpPost]
        public IHttpActionResult Modificar(NewPandoraExperimentoRequest request)
        {
            var oBL = new ExperimentoBL();
            return Json(oBL.Modificar(request));
        }

    }
}
