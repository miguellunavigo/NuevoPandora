using BanBif.Nuevo.Pandora.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BanBif.Nuevo.Pandora.App.Seguridad
{
    public class UserSession
    {
        public static string BearerToken
        {
            get
            {
                string result = string.Empty;

                if (HttpContext.Current.Session["UsuarioAutentificado"] != null)
                {
                    var obj = (NewPandoraLoginBE)HttpContext.Current.Session["UsuarioAutentificado"];

                    if (obj != null)
                    {
                        result = "BearerToken";
                    }
                }
                return result;
            }
        }

    }
}