using BanBif.Nuevo.Pandora.BE;
using BanBif.Nuevo.Pandora.DA.ModelApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.DA
{
    public class LoginDA
    {
        public NewPandoraResponse<NewPandoraLoginBE> Autenticacion(string usUsuarioWindows, string password)
        {
            NewPandoraResponse<NewPandoraLoginBE> response = new NewPandoraResponse<NewPandoraLoginBE>();
            try
            {
                using (panelEntities db = new panelEntities())
                {

                    var objDatosCampania = db.NewPandora_Usuario.Where(p => p.UsuarioWindows == usUsuarioWindows && p.Contrasenia == password).FirstOrDefault();
                    if (objDatosCampania != null)
                    {
                        response.Result = true;
                        response.data = new NewPandoraLoginBE();
                        response.data.IdUsuario = objDatosCampania.IdUsuario;
                        response.data.IdRol = objDatosCampania.IdRol;
                        response.data.UsuarioWindows = objDatosCampania.UsuarioWindows;
                        response.data.Password = objDatosCampania.Contrasenia;
                        response.data.Nombre = objDatosCampania.Nombre;
                        response.data.Correo = objDatosCampania.Correo;
                        response.data.FlagEstado = objDatosCampania.FlagEstado;                        
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
