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
            NewPandoraResponse<List<NewPandoraRolBE>> usuarioResponse = new NewPandoraResponse<List<NewPandoraRolBE>>();
            NewPandoraRolRequest request = new NewPandoraRolRequest();
            request.IdRol = login.IdRol.Value;
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Rol/Listar";
                string response = WebApi<NewPandoraRolRequest>.RequestWebApi(request, strURL);
                usuarioResponse = JsonConvert.DeserializeObject<NewPandoraResponse<List<NewPandoraRolBE>>>(response);
                ViewBag.ListaRol = usuarioResponse.data;

                NewPandoraResponse<List<NewPandoraUsuarioBE>> usuarioResponse1 = new NewPandoraResponse<List<NewPandoraUsuarioBE>>();
                NewPandoraUsuarioRequest request1 = new NewPandoraUsuarioRequest();
                request1.IdRol = login.IdRol.Value;
                string strURL1 = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Usuario/Listar";
                string response1 = WebApi<NewPandoraUsuarioRequest>.RequestWebApi(request1, strURL1);
                usuarioResponse1 = JsonConvert.DeserializeObject<NewPandoraResponse<List<NewPandoraUsuarioBE>>>(response1);

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
            NewPandoraResponse<List<NewPandoraUsuarioBE>> usuarioResponse = new NewPandoraResponse<List<NewPandoraUsuarioBE>>();
            NewPandoraUsuarioRequest request = new NewPandoraUsuarioRequest();
            var login = (NewPandoraLoginBE)Session["UsuarioAutentificado"];
            request.IdRol = login.IdRol.Value;
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Usuario/Listar";
                string response = WebApi<NewPandoraUsuarioRequest>.RequestWebApi(request, strURL);
                usuarioResponse = JsonConvert.DeserializeObject<NewPandoraResponse<List<NewPandoraUsuarioBE>>>(response);
            }
            catch (Exception ex)
            {
                usuarioResponse.Result = false;
            }

            return Json(usuarioResponse);
        }
        public ActionResult Obtener(NewPandoraUsuarioRequest request)
        {
            NewPandoraResponse<NewPandoraUsuarioBE> usuarioResponse = new NewPandoraResponse<NewPandoraUsuarioBE>();
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Usuario/Obtener";
                string response = WebApi<NewPandoraUsuarioRequest>.RequestWebApi(request, strURL);
                usuarioResponse = JsonConvert.DeserializeObject<NewPandoraResponse<NewPandoraUsuarioBE>>(response);
            }
            catch (Exception ex)
            {
                usuarioResponse.Result = false;
            }

            return Json(usuarioResponse);
        }
        public ActionResult Crear(NewPandoraUsuarioRequest request)
        {
            NewPandoraResponse<int> usuarioResponse = new NewPandoraResponse<int>();
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Usuario/Crear";
                string response = WebApi<NewPandoraUsuarioRequest>.RequestWebApi(request, strURL);
                usuarioResponse = JsonConvert.DeserializeObject<NewPandoraResponse<int>>(response);
            }
            catch (Exception ex)
            {
                usuarioResponse.Result = false;
            }

            return Json(usuarioResponse);
        }
        public ActionResult Modificar(NewPandoraUsuarioRequest request)
        {
            NewPandoraResponse<int> usuarioResponse = new NewPandoraResponse<int>();
            try
            {

                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Usuario/Modificar";
                string response = WebApi<NewPandoraUsuarioRequest>.RequestWebApi(request, strURL);
                usuarioResponse = JsonConvert.DeserializeObject<NewPandoraResponse<int>>(response);
            }
            catch (Exception ex)
            {
                usuarioResponse.Result = false;
            }

            return Json(usuarioResponse);
        }
    }
}