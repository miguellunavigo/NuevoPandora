using BanBif.Nuevo.Pandora.BE;
//using BanBif.Nuevo.Pandora.BE.Conyugues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.DA
{
    public class LoginDA
    {
        public NewPandoraLoginResponse Autenticacion(string usUsuarioWindows, string password)
        {
            NewPandoraLoginResponse response = new NewPandoraLoginResponse();
            try
            {
                using (panelEntities db = new panelEntities())
                {

                    var objDatosCampania = db.NewPandora_Usuario.Where(p => p.UsuarioWindows == usUsuarioWindows && p.Contrasenia == password).FirstOrDefault();
                    if (objDatosCampania != null)
                    {
                        response.Result = true;
                        response.Data = new NewPandoraLoginBE();
                        response.Data.IdUsuario = objDatosCampania.IdUsuario;
                        response.Data.IdRol = objDatosCampania.IdRol;
                        response.Data.UsuarioWindows = objDatosCampania.UsuarioWindows;
                        response.Data.Password = objDatosCampania.Contrasenia;
                        response.Data.Nombre = objDatosCampania.Nombre;
                        response.Data.Correo = objDatosCampania.Correo;
                        response.Data.FlagEstado = objDatosCampania.FlagEstado;                        
                    }
                    else
                    {
                        response.Mensaje = "El Usuario o Password son incorrectos";
                    }
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }
    }
}
