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
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            var login = (NewPandoraLoginBE)Session["UsuarioAutentificado"];
            NewPandoraRolResponse usuarioResponse = new NewPandoraRolResponse();
            NewPandoraRolRequest request = new NewPandoraRolRequest();
            request.IdRol = login.IdRol.Value;
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Rol/Listar";
                string response = WebApi<NewPandoraRolRequest>.RequestWebApi(request, strURL);
                usuarioResponse = JsonConvert.DeserializeObject<NewPandoraRolResponse>(response);
                ViewBag.ListaRol = usuarioResponse.Data;

                NewPandoraUsuarioResponse<List<NewPandoraUsuarioBE>> usuarioResponse1 = new NewPandoraUsuarioResponse<List<NewPandoraUsuarioBE>>();
                NewPandoraUsuarioRequest request1 = new NewPandoraUsuarioRequest();
                request1.IdRol = login.IdRol.Value;
                string strURL1 = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Usuario/Listar";
                string response1 = WebApi<NewPandoraUsuarioRequest>.RequestWebApi(request1, strURL1);
                usuarioResponse1 = JsonConvert.DeserializeObject<NewPandoraUsuarioResponse<List<NewPandoraUsuarioBE>>>(response1);

                ViewBag.ListaUsuario = usuarioResponse1.data;

            }
            catch (Exception ex)
            {
                usuarioResponse.Result = false;
            }

            return View();
        }

        public ActionResult Listar()
        {
            NewPandoraUsuarioResponse<List<NewPandoraUsuarioBE>> usuarioResponse = new NewPandoraUsuarioResponse<List<NewPandoraUsuarioBE>>();
            NewPandoraUsuarioRequest request = new NewPandoraUsuarioRequest();
            var login = (NewPandoraLoginBE)Session["UsuarioAutentificado"];
            request.IdRol = login.IdRol.Value;
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Usuario/Listar";
                string response = WebApi<NewPandoraUsuarioRequest>.RequestWebApi(request, strURL);
                usuarioResponse = JsonConvert.DeserializeObject<NewPandoraUsuarioResponse<List<NewPandoraUsuarioBE>>>(response);
            }
            catch (Exception ex)
            {
                usuarioResponse.Result = false;
            }

            return Json(usuarioResponse);
        }
        public ActionResult Obtener(NewPandoraUsuarioRequest request)
        {
            NewPandoraUsuarioResponse<NewPandoraUsuarioBE> usuarioResponse = new NewPandoraUsuarioResponse<NewPandoraUsuarioBE>();
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Usuario/Obtener";
                string response = WebApi<NewPandoraUsuarioRequest>.RequestWebApi(request, strURL);
                usuarioResponse = JsonConvert.DeserializeObject<NewPandoraUsuarioResponse<NewPandoraUsuarioBE>>(response);
            }
            catch (Exception ex)
            {
                usuarioResponse.Result = false;
            }

            return Json(usuarioResponse);
        }
        public ActionResult Crear(NewPandoraUsuarioRequest request)
        {
            NewPandoraUsuarioResponse<int> usuarioResponse = new NewPandoraUsuarioResponse<int>();
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Usuario/Crear";
                string response = WebApi<NewPandoraUsuarioRequest>.RequestWebApi(request, strURL);
                usuarioResponse = JsonConvert.DeserializeObject<NewPandoraUsuarioResponse<int>>(response);
            }
            catch (Exception ex)
            {
                usuarioResponse.Result = false;
            }

            return Json(usuarioResponse);
        }
        public ActionResult Modificar(NewPandoraUsuarioRequest request)
        {
            NewPandoraUsuarioResponse<int> usuarioResponse = new NewPandoraUsuarioResponse<int>();
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Usuario/Modificar";
                string response = WebApi<NewPandoraUsuarioRequest>.RequestWebApi(request, strURL);
                usuarioResponse = JsonConvert.DeserializeObject<NewPandoraUsuarioResponse<int>>(response);
            }
            catch (Exception ex)
            {
                usuarioResponse.Result = false;
            }

            return Json(usuarioResponse);
        }
    }
}