using BanBif.Nuevo.Pandora.BE;
using BanBif.Nuevo.Pandora.DA.ModelApp;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.DA
{
    public class UsuarioDA
    {
        public NewPandoraResponse<List<NewPandoraUsuarioBE>> Listar(NewPandoraUsuarioRequest request)
        {
            
            NewPandoraResponse<List<NewPandoraUsuarioBE>> response = new NewPandoraResponse<List<NewPandoraUsuarioBE>>();
            try
            {
                using (panelEntities db = new panelEntities())
                {

                    var listUsuario = db.NewPandora_Usuario.Where(p => p.IdRol > request.IdRol || 1 == request.IdRol).ToList();
                    //var listRol = db.NewPandora_Rol.ToList();
                    response.data = new List<NewPandoraUsuarioBE>();
                    listUsuario.ForEach(p => { response.data.Add(new NewPandoraUsuarioBE { IdUsuario = p.IdUsuario, IdRol = p.IdRol, Nombre = p.Nombre, Correo = p.Correo, Rol = p.NewPandora_Rol.NombreRol, FlagEstado = p.FlagEstado }); });
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }

        public NewPandoraResponse<NewPandoraUsuarioBE> Obtener(NewPandoraUsuarioRequest request)
        {
            NewPandoraResponse<NewPandoraUsuarioBE> response = new NewPandoraResponse<NewPandoraUsuarioBE>();
            try
            {
                using (panelEntities db = new panelEntities())
                {

                    var objUsuario = db.NewPandora_Usuario.Where(p => p.IdUsuario == request.IdUsuario).FirstOrDefault();
                    response.data = new NewPandoraUsuarioBE();
                    response.data.IdUsuario = objUsuario.IdUsuario;
                    response.data.UsuarioWindows = objUsuario.UsuarioWindows;
                    response.data.Nombre = objUsuario.Nombre;
                    response.data.Correo = objUsuario.Correo;
                    response.data.IdRol = objUsuario.IdRol;
                    response.data.FlagEstado = objUsuario.FlagEstado;
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }

        public NewPandoraResponse<int> Crear(NewPandoraUsuarioRequest request)
        {
            NewPandoraResponse<int> response = new NewPandoraResponse<int>();
            try
            {
                using (panelEntities db = new panelEntities())
                {

                    var newPandora_Usuario = new NewPandora_Usuario();
                    newPandora_Usuario.UsuarioWindows = request.UsuarioWindows;
                    newPandora_Usuario.Nombre = request.Nombre;
                    newPandora_Usuario.Contrasenia = request.Contrasenia;
                    newPandora_Usuario.Correo = request.Correo;
                    newPandora_Usuario.IdRol = request.IdRol; 
                    newPandora_Usuario.FlagEstado = true;
                    db.NewPandora_Usuario.Add(newPandora_Usuario);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }
        public NewPandoraResponse<int> Modificar(NewPandoraUsuarioRequest request)
        {
            NewPandoraResponse<int> response = new NewPandoraResponse<int>();
            try
            {
                using (panelEntities db = new panelEntities())
                {

                    var newPandora_Usuario = db.NewPandora_Usuario.Where(p => p.IdUsuario == request.IdUsuario).FirstOrDefault();
                    newPandora_Usuario.UsuarioWindows = request.UsuarioWindows;
                    newPandora_Usuario.Nombre = request.Nombre;
                    newPandora_Usuario.Correo = request.Correo;
                    newPandora_Usuario.IdRol = request.IdRol; ;
                    newPandora_Usuario.FlagEstado = true;
                    //db.NewPandora_Usuario.Add(newPandora_Usuario);
                    db.Entry(newPandora_Usuario).State = EntityState.Modified;
                    db.SaveChanges();
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
