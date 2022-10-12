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
            try
            {
                string responseStatus = WebApi<NewPandoraExperimentoStatusRequest>.RequestWebApi(new NewPandoraExperimentoStatusRequest() { FlagExperimento = true }, ConfigurationManager.AppSettings["BaseUrlService"] + "api/ExperimentoStatus/Listar");
                var listStatusResponse = JsonConvert.DeserializeObject<NewPandoraResponse<List<NewPandoraExperimentoStatusBE>>>(responseStatus);
                ViewBag.ListaStatus = listStatusResponse.data;

                string responseProducto = WebApi<NewPandoraProductoRequest>.RequestWebApi(new NewPandoraProductoRequest(), ConfigurationManager.AppSettings["BaseUrlService"] + "api/Producto/Listar");
                var listProductoResponse = JsonConvert.DeserializeObject<NewPandoraResponse<List<NewPandoraProductoBE>>>(responseProducto);
                ViewBag.ListaProducto = listProductoResponse.data;

                string responseExperimento = WebApi<NewPandoraExperimentoRequest>.RequestWebApi(new NewPandoraExperimentoRequest(), ConfigurationManager.AppSettings["BaseUrlService"] + "api/Experimento/Listar");
                var listExperimento = JsonConvert.DeserializeObject<NewPandoraResponse<List<NewPandoraExperimentoBE>>>(responseExperimento);
                ViewBag.ListaExperimento = listExperimento.data;

            }
            catch (Exception ex)
            {

            }

            return View();
        }

        public ActionResult Listar(NewPandoraExperimentoRequest request)
        {
            NewPandoraResponse<List<NewPandoraExperimentoBE>> ExperimentoResponse = new NewPandoraResponse<List<NewPandoraExperimentoBE>>();
            //NewPandoraExperimentoRequest request = new NewPandoraExperimentoRequest();
            var login = (NewPandoraLoginBE)Session["UsuarioAutentificado"];
            //request.IdRol = login.IdRol.Value;
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Experimento/Listar";
                string response = WebApi<NewPandoraExperimentoRequest>.RequestWebApi(request, strURL);
                ExperimentoResponse = JsonConvert.DeserializeObject<NewPandoraResponse<List<NewPandoraExperimentoBE>>>(response);
            }
            catch (Exception ex)
            {
                ExperimentoResponse.Result = false;
            }

            return Json(ExperimentoResponse);
        }

        public ActionResult Obtener(NewPandoraExperimentoRequest request)
        {
            NewPandoraResponse<NewPandoraExperimentoBE> ExperimentoResponse = new NewPandoraResponse<NewPandoraExperimentoBE>();
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Experimento/Obtener";
                string response = WebApi<NewPandoraExperimentoRequest>.RequestWebApi(request, strURL);
                ExperimentoResponse = JsonConvert.DeserializeObject<NewPandoraResponse<NewPandoraExperimentoBE>>(response);
            }
            catch (Exception ex)
            {
                ExperimentoResponse.Result = false;
            }

            return Json(ExperimentoResponse);
        }
        public ActionResult Crear(NewPandoraExperimentoRequest request)
        {
            NewPandoraResponse<int> ExperimentoResponse = new NewPandoraResponse<int>();
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Experimento/Crear";
                string response = WebApi<NewPandoraExperimentoRequest>.RequestWebApi(request, strURL);
                ExperimentoResponse = JsonConvert.DeserializeObject<NewPandoraResponse<int>>(response);
            }
            catch (Exception ex)
            {
                ExperimentoResponse.Result = false;
            }

            return Json(ExperimentoResponse);
        }
        public ActionResult Modificar(NewPandoraExperimentoRequest request)
        {
            NewPandoraResponse<int> ExperimentoResponse = new NewPandoraResponse<int>();
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Experimento/Modificar";
                string response = WebApi<NewPandoraExperimentoRequest>.RequestWebApi(request, strURL);
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