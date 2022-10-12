using BanBif.Nuevo.Pandora.App.Util;
using BanBif.Nuevo.Pandora.BE;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BanBif.Nuevo.Pandora.App.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult ListarIndicador(NewPandoraIndicadorRequest request)
        {
            NewPandoraResponse<List<NewPandoraIndicadorGraficaBE>> experimentoIndicador = new NewPandoraResponse<List<NewPandoraIndicadorGraficaBE>>();
            try
            {
                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Dashboard/ListarIndicador";
                string response = WebApi<NewPandoraIndicadorRequest>.RequestWebApi(request, strURL);
                experimentoIndicador = JsonConvert.DeserializeObject<NewPandoraResponse<List<NewPandoraIndicadorGraficaBE>>>(response);
            }
            catch (Exception ex)
            {
                experimentoIndicador.Result = false;
            }

            return Json(experimentoIndicador);
        }

    }
}