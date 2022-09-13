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
    public class PropuestaController : Controller
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
            }
            catch (Exception ex)
            {
                listExperimentoStatusResponse.Result = false;
            }

            return View();
        }

        public ActionResult Listar()
        {
            NewPandoraPropuestaExperimentoResponse<List<NewPandoraPropuestaExperimentoBE>> ExperimentoResponse = new NewPandoraPropuestaExperimentoResponse<List<NewPandoraPropuestaExperimentoBE>>();
            NewPandoraPropuestaExperimentoRequest request = new NewPandoraPropuestaExperimentoRequest();
            var login = (NewPandoraLoginBE)Session["UsuarioAutentificado"];
            //request.IdRol = login.IdRol.Value;
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Propuesta/Listar";
                string response = WebApi<NewPandoraPropuestaExperimentoRequest>.RequestWebApi(request, strURL);
                ExperimentoResponse = JsonConvert.DeserializeObject<NewPandoraPropuestaExperimentoResponse<List<NewPandoraPropuestaExperimentoBE>>>(response);
            }
            catch (Exception ex)
            {
                ExperimentoResponse.Result = false;
            }

            return Json(ExperimentoResponse);
        }
        public ActionResult Obtener(NewPandoraPropuestaExperimentoRequest request)
        {
            NewPandoraPropuestaExperimentoResponse<NewPandoraPropuestaExperimentoBE> ExperimentoResponse = new NewPandoraPropuestaExperimentoResponse<NewPandoraPropuestaExperimentoBE>();
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Propuesta/Obtener";
                string response = WebApi<NewPandoraPropuestaExperimentoRequest>.RequestWebApi(request, strURL);
                ExperimentoResponse = JsonConvert.DeserializeObject<NewPandoraPropuestaExperimentoResponse<NewPandoraPropuestaExperimentoBE>>(response);
            }
            catch (Exception ex)
            {
                ExperimentoResponse.Result = false;
            }

            return Json(ExperimentoResponse);
        }
        public ActionResult Crear(NewPandoraPropuestaExperimentoRequest request)
        {
            NewPandoraPropuestaExperimentoResponse<int> ExperimentoResponse = new NewPandoraPropuestaExperimentoResponse<int>();
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Propuesta/Crear";
                string response = WebApi<NewPandoraPropuestaExperimentoRequest>.RequestWebApi(request, strURL);
                ExperimentoResponse = JsonConvert.DeserializeObject<NewPandoraPropuestaExperimentoResponse<int>>(response);
            }
            catch (Exception ex)
            {
                ExperimentoResponse.Result = false;
            }

            return Json(ExperimentoResponse);
        }
        public ActionResult Modificar(NewPandoraPropuestaExperimentoRequest request)
        {
            NewPandoraPropuestaExperimentoResponse<int> ExperimentoResponse = new NewPandoraPropuestaExperimentoResponse<int>();
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Propuesta/Modificar";
                string response = WebApi<NewPandoraPropuestaExperimentoRequest>.RequestWebApi(request, strURL);
                ExperimentoResponse = JsonConvert.DeserializeObject<NewPandoraPropuestaExperimentoResponse<int>>(response);
            }
            catch (Exception ex)
            {
                ExperimentoResponse.Result = false;
            }

            return Json(ExperimentoResponse);
        }
    }
}