using BanBif.Nuevo.Pandora.App.Util;
using BanBif.Nuevo.Pandora.BE;
using Microsoft.Owin.Security;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Claims;
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
            NewPandoraResponse<NewPandoraLoginBE> logResponse = new NewPandoraResponse<NewPandoraLoginBE>();
            try
            {
                request.Password = BanBif.Comunes.Util.Seguridad.Encrypt(request.Password);
                string strURL = ConfigurationManager.AppSettings["BaseUrlService"] + "api/Login/Autenticacion";
                string response = WebApi<NewPandoraLoginRequest>.RequestWebApi(request, strURL);
                logResponse = JsonConvert.DeserializeObject<NewPandoraResponse<NewPandoraLoginBE>>(response);
                if (logResponse.Result)
                {
                    Session["UsuarioAutentificado"] = logResponse.data;
                    AuthenticationProperties options = new AuthenticationProperties
                    {
                        AllowRefresh = true,
                        IsPersistent = false,
                        ExpiresUtc = DateTime.UtcNow.AddSeconds(8000)
                    };

                    //Init User Info
                    var claims = new[]
                    {
                        new Claim(ClaimTypes.Name, logResponse.data.UsuarioWindows),
                        new Claim(ClaimTypes.NameIdentifier, string.Format(logResponse.data.IdUsuario.ToString()))
                    };

                    var identity = new ClaimsIdentity(claims, "ApplicationCookie");
                    Request.GetOwinContext().Authentication.SignIn(options, identity);
                    //return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                logResponse.Result = false;
            }

            return Json(logResponse);
        }



    }
}