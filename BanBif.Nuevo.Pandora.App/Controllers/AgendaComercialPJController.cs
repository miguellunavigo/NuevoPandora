using BanBif.Nuevo.Pandora.App.Util;
using BanBif.Nuevo.Pandora.BE.AppsBE.AgendaComercialPJ;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;

namespace BanBif.Nuevo.Pandora.App.Controllers
{
    public class AgendaComercialPJController : Controller
    {
        // GET: AgendaComercialPJ
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarClientes(acListaClienteRequest request)
        {
            acListaClienteResponse<List<acClienteBE>> response = new acListaClienteResponse<List<acClienteBE>>();
            
            try
            {
                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/AgendaComercial/ListarClientes";
                string result = WebApi<acListaClienteRequest>.RequestWebApi(request, strURL);
                response = JsonConvert.DeserializeObject<acListaClienteResponse<List<acClienteBE>>>(result);
            }
            catch (Exception ex)
            {
                response.Result = false;
            }

            return Json(response);
        }

        public ActionResult ObtenerClientes(acListaClienteRequest request)
        {
            acListaClienteResponse<acClienteBE> response = new acListaClienteResponse<acClienteBE>();
            try
            {
                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/AgendaComercial/ObtenerClientes";
                string result = WebApi<acListaClienteRequest>.RequestWebApi(request, strURL);
                response = JsonConvert.DeserializeObject<acListaClienteResponse<acClienteBE>>(result);
            }
            catch (Exception ex)
            {
                response.Result = false;
            }
            return Json(response);
        }
        public ActionResult ListarClientesContacto(acListaClienteContactoRequest request)
        {
            acListaClienteResponse<List<acClienteContactoBE>> response = new acListaClienteResponse<List<acClienteContactoBE>>();
            try
            {
                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/AgendaComercial/ListarClientesContacto";
                string result = WebApi<acListaClienteContactoRequest>.RequestWebApi(request, strURL);
                response = JsonConvert.DeserializeObject<acListaClienteResponse<List<acClienteContactoBE>>>(result);
            }
            catch (Exception ex)
            {
                response.Result = false;
            }
            return Json(response);
        }

        public ActionResult ObtenerClientesContacto(acListaClienteContactoRequest request)
        {
            acListaClienteResponse<acClienteContactoBE> response = new acListaClienteResponse<acClienteContactoBE>();
            try
            {
                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/AgendaComercial/ObtenerClientesContacto";
                string result = WebApi<acListaClienteContactoRequest>.RequestWebApi(request, strURL);
                response = JsonConvert.DeserializeObject<acListaClienteResponse<acClienteContactoBE>>(result);
            }
            catch (Exception ex)
            {
                response.Result = false;
            }

            return Json(response);
        }
        public ActionResult ListarClienteContactoComentarios(acListaClienteContactoComentarioRequest request)
        {
            acListaClienteResponse<List<acClienteContactoComentarioBE>> response = new acListaClienteResponse<List<acClienteContactoComentarioBE>>();
            try
            {
                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/AgendaComercial/ListarClienteContactoComentarios";
                string result = WebApi<acListaClienteContactoComentarioRequest>.RequestWebApi(request, strURL);
                response = JsonConvert.DeserializeObject<acListaClienteResponse<List<acClienteContactoComentarioBE>>>(result);
            }
            catch (Exception ex)
            {
                response.Result = false;
            }
            return Json(response);
        }
    }
}