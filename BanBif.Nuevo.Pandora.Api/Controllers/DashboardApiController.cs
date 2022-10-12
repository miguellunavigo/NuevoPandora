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
    public class DashboardApiController : ApiController
    {


        [Route("api/Dashboard/ListarIndicador")]
        [HttpPost]
        public IHttpActionResult ListarIndicador(NewPandoraIndicadorRequest request)
        {
            var oBL = new DashboardBL();
            return Json(oBL.ListarIndicadores(request));
        }
        [Route("api/Dashboard/ListarOrder")]
        [HttpPost]
        public IHttpActionResult ListarOrder(NewPandoraIndicadorRequest request)
        {
            var oBL = new DashboardBL();
            return Json(oBL.ListarOrder());
        }
        [Route("api/Dashboard/ListarPayments")]
        [HttpPost]
        public IHttpActionResult ListarPayments(NewPandoraIndicadorRequest request)
        {
            var oBL = new DashboardBL();
            return Json(oBL.ListarPayments());
        }
        [Route("api/Dashboard/ListarRevenue")]
        [HttpPost]
        public IHttpActionResult ListarRevenue(NewPandoraIndicadorRequest request)
        {
            var oBL = new DashboardBL();
            return Json(oBL.ListarRevenue());
        }
        [Route("api/Dashboard/ListarTotalRevenue")]
        [HttpPost]
        public IHttpActionResult ListarTotalRevenue(NewPandoraIndicadorRequest request)
        {
            var oBL = new DashboardBL();
            return Json(oBL.ListarTotalRevenue());
        }
        [Route("api/Dashboard/ListarTecnologia")]
        [HttpPost]
        public IHttpActionResult ListarTecnologia(NewPandoraIndicadorRequest request)
        {
            var oBL = new DashboardBL();
            return Json(oBL.ListarTecnologia());
        }

        [Route("api/Dashboard/ListarTransactions")]
        [HttpPost]
        public IHttpActionResult ListarTransactions(NewPandoraIndicadorRequest request)
        {
            var oBL = new DashboardBL();
            return Json(oBL.ListarTransactions());
        }

        [Route("api/Dashboard/ListarBrowser")]
        [HttpPost]
        public IHttpActionResult ListarBrowser(NewPandoraIndicadorRequest request)
        {
            var oBL = new DashboardBL();
            return Json(oBL.ListarBrowser());
        }
    }
}
