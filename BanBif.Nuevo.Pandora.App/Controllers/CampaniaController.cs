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
            NewPandoraResponse<List<NewPandoraExperimentoBE>> listExperimentoStatusResponse = new NewPandoraResponse<List<NewPandoraExperimentoBE>>();
            NewPandoraExperimentoRequest request = new NewPandoraExperimentoRequest();
            try
            {
                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Experimento/Listar";
                string response = WebApi<NewPandoraExperimentoRequest>.RequestWebApi(request, strURL);
                listExperimentoStatusResponse = JsonConvert.DeserializeObject<NewPandoraResponse<List<NewPandoraExperimentoBE>>>(response);
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
            NewPandoraResponse<List<ReinventaDatosCampaniaBE>> NewPandoraResponse = new NewPandoraResponse<List<ReinventaDatosCampaniaBE>>();
            ReinventaDatosCampaniaRequest request = new ReinventaDatosCampaniaRequest();
            var login = (NewPandoraLoginBE)Session["UsuarioAutentificado"];
            //request.IdRol = login.IdRol.Value;
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/ReinventaDatosCampania/Listar";
                string response = WebApi<ReinventaDatosCampaniaRequest>.RequestWebApi(request, strURL);
                NewPandoraResponse = JsonConvert.DeserializeObject<NewPandoraResponse<List<ReinventaDatosCampaniaBE>>>(response);
            }
            catch (Exception ex)
            {
                NewPandoraResponse.Result = false;
            }

            return Json(NewPandoraResponse);
        }
        public ActionResult Obtener(ReinventaDatosCampaniaRequest request)
        {
            NewPandoraResponse<ReinventaDatosCampaniaBE> NewPandoraResponse = new NewPandoraResponse<ReinventaDatosCampaniaBE>();
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/ReinventaDatosCampania/Obtener";
                string response = WebApi<ReinventaDatosCampaniaRequest>.RequestWebApi(request, strURL);
                NewPandoraResponse = JsonConvert.DeserializeObject<NewPandoraResponse<ReinventaDatosCampaniaBE>>(response);
            }
            catch (Exception ex)
            {
                NewPandoraResponse.Result = false;
            }

            return Json(NewPandoraResponse);
        }
        public ActionResult Crear(ReinventaDatosCampaniaRequest request)
        {
            NewPandoraResponse<int> NewPandoraResponse = new NewPandoraResponse<int>();
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/ReinventaDatosCampania/Crear";
                string response = WebApi<ReinventaDatosCampaniaRequest>.RequestWebApi(request, strURL);
                NewPandoraResponse = JsonConvert.DeserializeObject<NewPandoraResponse<int>>(response);
            }
            catch (Exception ex)
            {
                NewPandoraResponse.Result = false;
            }

            return Json(NewPandoraResponse);
        }
        public ActionResult Modificar(ReinventaDatosCampaniaRequest request)
        {
            NewPandoraResponse<int> NewPandoraResponse = new NewPandoraResponse<int>();
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/ReinventaDatosCampania/Modificar";
                string response = WebApi<ReinventaDatosCampaniaRequest>.RequestWebApi(request, strURL);
                NewPandoraResponse = JsonConvert.DeserializeObject<NewPandoraResponse<int>>(response);
            }
            catch (Exception ex)
            {
                NewPandoraResponse.Result = false;
            }

            return Json(NewPandoraResponse);
        }
    }
}