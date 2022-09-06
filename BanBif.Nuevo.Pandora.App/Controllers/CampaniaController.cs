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
    public class CampaniaController : Controller
    {
        // GET: Experimento
        public ActionResult Index()
        {
            var login = (NewPandoraLoginBE)Session["UsuarioAutentificado"];
            NewPandoraExperimentoResponse<List<NewPandoraExperimentoBE>> listExperimentoStatusResponse = new NewPandoraExperimentoResponse<List<NewPandoraExperimentoBE>>();
            NewPandoraExperimentoRequest request = new NewPandoraExperimentoRequest();
            try
            {
                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Experimento/Listar";
                string response = WebApi<NewPandoraExperimentoRequest>.RequestWebApi(request, strURL);
                listExperimentoStatusResponse = JsonConvert.DeserializeObject<NewPandoraExperimentoResponse<List<NewPandoraExperimentoBE>>>(response);
                ViewBag.ListaExperimento = listExperimentoStatusResponse.data;
            }
            catch (Exception ex)
            {
                listExperimentoStatusResponse.Result = false;
            }

            return View();
        }

        public ActionResult Listar()
        {
            ReinventaDatosCampaniaResponse<List<ReinventaDatosCampaniaBE>> ReinventaDatosCampaniaResponse = new ReinventaDatosCampaniaResponse<List<ReinventaDatosCampaniaBE>>();
            ReinventaDatosCampaniaRequest request = new ReinventaDatosCampaniaRequest();
            var login = (NewPandoraLoginBE)Session["UsuarioAutentificado"];
            //request.IdRol = login.IdRol.Value;
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/ReinventaDatosCampania/Listar";
                string response = WebApi<ReinventaDatosCampaniaRequest>.RequestWebApi(request, strURL);
                ReinventaDatosCampaniaResponse = JsonConvert.DeserializeObject<ReinventaDatosCampaniaResponse<List<ReinventaDatosCampaniaBE>>>(response);
            }
            catch (Exception ex)
            {
                ReinventaDatosCampaniaResponse.Result = false;
            }

            return Json(ReinventaDatosCampaniaResponse);
        }
        public ActionResult Obtener(ReinventaDatosCampaniaRequest request)
        {
            ReinventaDatosCampaniaResponse<ReinventaDatosCampaniaBE> ReinventaDatosCampaniaResponse = new ReinventaDatosCampaniaResponse<ReinventaDatosCampaniaBE>();
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/ReinventaDatosCampania/Obtener";
                string response = WebApi<ReinventaDatosCampaniaRequest>.RequestWebApi(request, strURL);
                ReinventaDatosCampaniaResponse = JsonConvert.DeserializeObject<ReinventaDatosCampaniaResponse<ReinventaDatosCampaniaBE>>(response);
            }
            catch (Exception ex)
            {
                ReinventaDatosCampaniaResponse.Result = false;
            }

            return Json(ReinventaDatosCampaniaResponse);
        }
        public ActionResult Crear(ReinventaDatosCampaniaRequest request)
        {
            ReinventaDatosCampaniaResponse<int> ReinventaDatosCampaniaResponse = new ReinventaDatosCampaniaResponse<int>();
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/ReinventaDatosCampania/Crear";
                string response = WebApi<ReinventaDatosCampaniaRequest>.RequestWebApi(request, strURL);
                ReinventaDatosCampaniaResponse = JsonConvert.DeserializeObject<ReinventaDatosCampaniaResponse<int>>(response);
            }
            catch (Exception ex)
            {
                ReinventaDatosCampaniaResponse.Result = false;
            }

            return Json(ReinventaDatosCampaniaResponse);
        }
        public ActionResult Modificar(ReinventaDatosCampaniaRequest request)
        {
            ReinventaDatosCampaniaResponse<int> ReinventaDatosCampaniaResponse = new ReinventaDatosCampaniaResponse<int>();
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/ReinventaDatosCampania/Modificar";
                string response = WebApi<ReinventaDatosCampaniaRequest>.RequestWebApi(request, strURL);
                ReinventaDatosCampaniaResponse = JsonConvert.DeserializeObject<ReinventaDatosCampaniaResponse<int>>(response);
            }
            catch (Exception ex)
            {
                ReinventaDatosCampaniaResponse.Result = false;
            }

            return Json(ReinventaDatosCampaniaResponse);
        }
    }
}