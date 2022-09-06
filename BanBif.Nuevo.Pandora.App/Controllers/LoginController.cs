using BanBif.Nuevo.Pandora.App.Util;
using BanBif.Nuevo.Pandora.BE;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BanBif.Nuevo.Pandora.App.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            ViewBag.URL = ConfigurationManager.AppSettings.Get("UrlApp").ToString();
            return View();
        }

        public ActionResult Autenticacion(NewPandoraLoginRequest request)
        {
            NewPandoraLoginResponse logResponse = new NewPandoraLoginResponse();
            try
            {
                request.Password = BanBif.Comunes.Util.Seguridad.Encrypt(request.Password);
                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Login/Autenticacion";
                string response = WebApi<NewPandoraLoginRequest>.RequestWebApi(request, strURL);
                logResponse = JsonConvert.DeserializeObject<NewPandoraLoginResponse>(response);
                //if (logResponse.Result)
                //{
                //    Session["UsuarioAutentificado"] = logResponse.Data;
                //    return RedirectToAction("Index", "Home");
                //}
            }
            catch (Exception ex)
            {
                logResponse.Result = false;
            }

            return Json(logResponse);
        }



    }
}