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
    public class ExperimentoStatusApiController : ApiController
    {
        [Route("api/ExperimentoStatus/Listar")]
        [HttpPost]
        public IHttpActionResult Listar(NewPandoraExperimentoStatusRequest request)
        {
            var oBL = new ExperimentoStatusBL();
            return Json(oBL.Listar());
        }        
    }
}
