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
    public class ExperimentoController : Controller
    {
        // GET: Experimento
        public ActionResult Index()
        {
            var login = (NewPandoraLoginBE)Session["UsuarioAutentificado"];
            NewPandoraExperimentoStatusResponse listExperimentoStatusResponse = new NewPandoraExperimentoStatusResponse();
            NewPandoraExperimentoStatusRequest request = new NewPandoraExperimentoStatusRequest();
            //request.IdRol = login.IdRol.Value;
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/ExperimentoStatus/Listar";
                string response = WebApi<NewPandoraExperimentoStatusRequest>.RequestWebApi(request, strURL);
                listExperimentoStatusResponse = JsonConvert.DeserializeObject<NewPandoraExperimentoStatusResponse>(response);
                ViewBag.ListaStatus = listExperimentoStatusResponse.Data;

                NewPandoraExperimentoResponse<List<NewPandoraExperimentoBE>> usuarioResponse1 = new NewPandoraExperimentoResponse<List<NewPandoraExperimentoBE>>();
                NewPandoraExperimentoRequest request1 = new NewPandoraExperimentoRequest();                
                string strURL1 = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Experimento/Listar";
                string response1 = WebApi<NewPandoraExperimentoRequest>.RequestWebApi(request1, strURL1);
                usuarioResponse1 = JsonConvert.DeserializeObject<NewPandoraExperimentoResponse<List<NewPandoraExperimentoBE>>>(response1);
                ViewBag.ListaExperimento = usuarioResponse1.data;

            }
            catch (Exception ex)
            {
                listExperimentoStatusResponse.Result = false;
            }

            return View();
        }

        public ActionResult Listar(NewPandoraExperimentoRequest request)
        {
            NewPandoraExperimentoResponse<List<NewPandoraExperimentoBE>> ExperimentoResponse = new NewPandoraExperimentoResponse<List<NewPandoraExperimentoBE>>();
            //NewPandoraExperimentoRequest request = new NewPandoraExperimentoRequest();
            var login = (NewPandoraLoginBE)Session["UsuarioAutentificado"];
            //request.IdRol = login.IdRol.Value;
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Experimento/Listar";
                string response = WebApi<NewPandoraExperimentoRequest>.RequestWebApi(request, strURL);
                ExperimentoResponse = JsonConvert.DeserializeObject<NewPandoraExperimentoResponse<List<NewPandoraExperimentoBE>>>(response);
            }
            catch (Exception ex)
            {
                ExperimentoResponse.Result = false;
            }

            return Json(ExperimentoResponse);
        }

        public ActionResult ListarIndicador(NewPandoraIndicadorRequest request)
        {
            NewPandoraIndicadorResponse<List<NewPandoraIndicadorGraficaBE>> experimentoIndicador = new NewPandoraIndicadorResponse<List<NewPandoraIndicadorGraficaBE>>();            
            try
            {                
                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Experimento/ListarIndicador";
                string response = WebApi<NewPandoraIndicadorRequest>.RequestWebApi(request, strURL);
                experimentoIndicador = JsonConvert.DeserializeObject<NewPandoraIndicadorResponse<List<NewPandoraIndicadorGraficaBE>>>(response);
            }
            catch (Exception ex)
            {
                experimentoIndicador.Result = false;
            }

            return Json(experimentoIndicador);
        }
        public ActionResult Obtener(NewPandoraExperimentoRequest request)
        {
            NewPandoraExperimentoResponse<NewPandoraExperimentoBE> ExperimentoResponse = new NewPandoraExperimentoResponse<NewPandoraExperimentoBE>();
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Experimento/Obtener";
                string response = WebApi<NewPandoraExperimentoRequest>.RequestWebApi(request, strURL);
                ExperimentoResponse = JsonConvert.DeserializeObject<NewPandoraExperimentoResponse<NewPandoraExperimentoBE>>(response);
            }
            catch (Exception ex)
            {
                ExperimentoResponse.Result = false;
            }

            return Json(ExperimentoResponse);
        }
        public ActionResult Crear(NewPandoraExperimentoRequest request)
        {
            NewPandoraExperimentoResponse<int> ExperimentoResponse = new NewPandoraExperimentoResponse<int>();
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Experimento/Crear";
                string response = WebApi<NewPandoraExperimentoRequest>.RequestWebApi(request, strURL);
                ExperimentoResponse = JsonConvert.DeserializeObject<NewPandoraExperimentoResponse<int>>(response);
            }
            catch (Exception ex)
            {
                ExperimentoResponse.Result = false;
            }

            return Json(ExperimentoResponse);
        }
        public ActionResult Modificar(NewPandoraExperimentoRequest request)
        {
            NewPandoraExperimentoResponse<int> ExperimentoResponse = new NewPandoraExperimentoResponse<int>();
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Experimento/Modificar";
                string response = WebApi<NewPandoraExperimentoRequest>.RequestWebApi(request, strURL);
                ExperimentoResponse = JsonConvert.DeserializeObject<NewPandoraExperimentoResponse<int>>(response);
            }
            catch (Exception ex)
            {
                ExperimentoResponse.Result = false;
            }

            return Json(ExperimentoResponse);
        }
    }
}