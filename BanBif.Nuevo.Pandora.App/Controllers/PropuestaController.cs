using BanBif.Nuevo.Pandora.App.Seguridad;
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
    [AppAuthorizeAttribute]
    public class PropuestaController : Controller
    {
        // GET: Experimento
        public ActionResult Index()
        {
            try
            {
                string response = WebApi<NewPandoraExperimentoStatusRequest>.RequestWebApi(new NewPandoraExperimentoStatusRequest() {  FlagExperimento=false}, ConfigurationManager.AppSettings["BaseUrlService"] + "api/ExperimentoStatus/Listar");
                var listStatusResponse = JsonConvert.DeserializeObject<NewPandoraResponse<List<NewPandoraExperimentoStatusBE>>>(response);
                ViewBag.ListaStatus = listStatusResponse.data;
            }
            catch (Exception ex)
            {                
            }
            return View();
        }

        public ActionResult Listar()
        {
            NewPandoraResponse<List<NewPandoraPropuestaExperimentoBE>> ExperimentoResponse = new NewPandoraResponse<List<NewPandoraPropuestaExperimentoBE>>();          
            try
            {

                string response = WebApi<NewPandoraPropuestaExperimentoRequest>.RequestWebApi(new NewPandoraPropuestaExperimentoRequest(), ConfigurationManager.AppSettings["BaseUrlService"] + "api/Propuesta/Listar");
                ExperimentoResponse = JsonConvert.DeserializeObject<NewPandoraResponse<List<NewPandoraPropuestaExperimentoBE>>>(response);
            }
            catch (Exception ex)
            {
                ExperimentoResponse.Result = false;
            }

            return Json(ExperimentoResponse);
        }
        public ActionResult Obtener(NewPandoraPropuestaExperimentoRequest request)
        {
            NewPandoraResponse<NewPandoraPropuestaExperimentoBE> ExperimentoResponse = new NewPandoraResponse<NewPandoraPropuestaExperimentoBE>();
            try
            {
                string response = WebApi<NewPandoraPropuestaExperimentoRequest>.RequestWebApi(request, ConfigurationManager.AppSettings["BaseUrlService"] + "api/Propuesta/Obtener");
                ExperimentoResponse = JsonConvert.DeserializeObject<NewPandoraResponse<NewPandoraPropuestaExperimentoBE>>(response);
            }
            catch (Exception ex)
            {
                ExperimentoResponse.Result = false;
            }

            return Json(ExperimentoResponse);
        }
        public ActionResult Crear(NewPandoraPropuestaExperimentoRequest request)
        {
            NewPandoraResponse<int> ExperimentoResponse = new NewPandoraResponse<int>();
            try
            {
                string response = WebApi<NewPandoraPropuestaExperimentoRequest>.RequestWebApi(request, ConfigurationManager.AppSettings["BaseUrlService"] + "api/Propuesta/Crear");
                ExperimentoResponse = JsonConvert.DeserializeObject<NewPandoraResponse<int>>(response);
            }
            catch (Exception ex)
            {
                ExperimentoResponse.Result = false;
            }

            return Json(ExperimentoResponse);
        }
        public ActionResult Modificar(NewPandoraPropuestaExperimentoRequest request)
        {
            NewPandoraResponse<int> ExperimentoResponse = new NewPandoraResponse<int>();
            try
            {
                string response = WebApi<NewPandoraPropuestaExperimentoRequest>.RequestWebApi(request, ConfigurationManager.AppSettings["BaseUrlService"] + "api/Propuesta/Modificar");
                ExperimentoResponse = JsonConvert.DeserializeObject<NewPandoraResponse<int>>(response);
            }
            catch (Exception ex)
            {
                ExperimentoResponse.Result = false;
            }

            return Json(ExperimentoResponse);
        }
    }
}