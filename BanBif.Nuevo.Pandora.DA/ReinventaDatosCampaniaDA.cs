using BanBif.Nuevo.Pandora.BE;
//using BanBif.Nuevo.Pandora.BE.Conyugues;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.DA
{
    public class ReinventaDatosCampaniaDA
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ReinventaDatosCampaniaResponse<List<ReinventaDatosCampaniaBE>> Listar(ReinventaDatosCampaniaRequest request)
        {
            ReinventaDatosCampaniaResponse<List<ReinventaDatosCampaniaBE>> response = new ReinventaDatosCampaniaResponse<List<ReinventaDatosCampaniaBE>>();
            try
            {
                using (panelEntities db = new panelEntities())
                {
                    var listUsuario = db.ReinventaDatosCampania.ToList();
                    response.data = new List<ReinventaDatosCampaniaBE>();
                    listUsuario.ForEach(p =>
                    {
                        response.data.Add(new ReinventaDatosCampaniaBE
                        {
                            IdCampania = p.IdCampania,
                            NombreCampania = p.NombreCampania,
                            FechaInicio = p.FechaInicio,
                            FechaFin = p.FechaFin,
                            ColorCabecera = p.ColorCabecera,
                            ColorDetalle = p.ColorDetalle,
                            TextoPrimario = p.TextoPrimario,
                            TextoSecundario = p.TextoSecundario,
                            ImagenPrimario = p.ImagenPrimario,
                            FlagCarrusel = p.FlagCarrusel,
                            ImagenSecundario = p.ImagenSecundario,
                            TextoTerciario = p.TextoTerciario,
                            MasInformacion = p.MasInformacion,
                            UrlCampania = p.UrlCampania,
                            TextoFinal1 = p.TextoFinal1,
                            TextoFinal2 = p.TextoFinal2,
                            TextoFinalUrl = p.TextoFinalUrl,
                            ImagenFinal = p.ImagenFinal,
                            UsuarioCreacion = p.UsuarioCreacion,
                            Estado = p.Estado,
                            IdExperimento = p.IdExperimento
                        });
                    });
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ReinventaDatosCampaniaResponse<ReinventaDatosCampaniaBE> Obtener(ReinventaDatosCampaniaRequest request)
        {
            ReinventaDatosCampaniaResponse<ReinventaDatosCampaniaBE> response = new ReinventaDatosCampaniaResponse<ReinventaDatosCampaniaBE>();
            try
            {
                using (panelEntities db = new panelEntities())
                {

                    var objReinventaDatosCampania = db.ReinventaDatosCampania.Where(p => p.IdExperimento == request.IdExperimento).FirstOrDefault();
                    response.data = new ReinventaDatosCampaniaBE();
                    response.data.IdCampania = objReinventaDatosCampania.IdCampania;
                    response.data.NombreCampania = objReinventaDatosCampania.NombreCampania;
                    response.data.FechaInicio = objReinventaDatosCampania.FechaInicio;
                    response.data.FechaFin = objReinventaDatosCampania.FechaFin;
                    response.data.ColorCabecera = objReinventaDatosCampania.ColorCabecera;
                    response.data.ColorDetalle = objReinventaDatosCampania.ColorDetalle;
                    response.data.TextoPrimario = objReinventaDatosCampania.TextoPrimario;
                    response.data.TextoSecundario = objReinventaDatosCampania.TextoSecundario;
                    response.data.ImagenPrimario = objReinventaDatosCampania.ImagenPrimario;
                    response.data.FlagCarrusel = objReinventaDatosCampania.FlagCarrusel;
                    response.data.ImagenSecundario = objReinventaDatosCampania.ImagenSecundario;
                    response.data.TextoTerciario = objReinventaDatosCampania.TextoTerciario;
                    response.data.MasInformacion = objReinventaDatosCampania.MasInformacion;
                    response.data.UrlCampania = objReinventaDatosCampania.UrlCampania;
                    response.data.TextoFinal1 = objReinventaDatosCampania.TextoFinal1;
                    response.data.TextoFinal2 = objReinventaDatosCampania.TextoFinal2;
                    response.data.TextoFinalUrl = objReinventaDatosCampania.TextoFinalUrl;
                    response.data.ImagenFinal = objReinventaDatosCampania.ImagenFinal;
                    response.data.UsuarioCreacion = objReinventaDatosCampania.UsuarioCreacion;
                    response.data.Estado = objReinventaDatosCampania.Estado;
                    response.data.IdExperimento = objReinventaDatosCampania.IdExperimento;
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ReinventaDatosCampaniaResponse<int> Crear(ReinventaDatosCampaniaRequest request)
        {
            ReinventaDatosCampaniaResponse<int> response = new ReinventaDatosCampaniaResponse<int>();
            try
            {
                using (panelEntities db = new panelEntities())
                {
                    var reinventaDatosCampania = new ReinventaDatosCampania();
                    reinventaDatosCampania.NombreCampania = request.NombreCampania;
                    reinventaDatosCampania.FechaInicio = request.FechaInicio;
                    reinventaDatosCampania.FechaFin = request.FechaFin;
                    reinventaDatosCampania.ColorCabecera = request.ColorCabecera;
                    reinventaDatosCampania.ColorDetalle = request.ColorDetalle;
                    reinventaDatosCampania.TextoPrimario = request.TextoPrimario;
                    reinventaDatosCampania.TextoSecundario = request.TextoSecundario;
                    reinventaDatosCampania.ImagenPrimario = request.ImagenPrimario;
                    reinventaDatosCampania.FlagCarrusel = request.FlagCarrusel;
                    reinventaDatosCampania.ImagenSecundario = request.ImagenSecundario;
                    reinventaDatosCampania.TextoTerciario = request.TextoTerciario;
                    reinventaDatosCampania.MasInformacion = request.MasInformacion;
                    reinventaDatosCampania.UrlCampania = request.UrlCampania;
                    reinventaDatosCampania.TextoFinal1 = request.TextoFinal1;
                    reinventaDatosCampania.TextoFinal2 = request.TextoFinal2;
                    reinventaDatosCampania.TextoFinalUrl = request.TextoFinalUrl;
                    reinventaDatosCampania.ImagenFinal = request.ImagenFinal;
                    reinventaDatosCampania.UsuarioCreacion = request.UsuarioCreacion;
                    reinventaDatosCampania.Estado = request.Estado;
                    reinventaDatosCampania.IdExperimento = request.IdExperimento;
                    db.ReinventaDatosCampania.Add(reinventaDatosCampania);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ReinventaDatosCampaniaResponse<int> Modificar(ReinventaDatosCampaniaRequest request)
        {
            ReinventaDatosCampaniaResponse<int> response = new ReinventaDatosCampaniaResponse<int>();
            try
            {
                using (panelEntities db = new panelEntities())
                {
                    var reinventaDatosCampania = db.ReinventaDatosCampania.Where(p => p.IdCampania == request.IdCampania).FirstOrDefault();
                    reinventaDatosCampania.NombreCampania = request.NombreCampania;
                    reinventaDatosCampania.FechaInicio = request.FechaInicio;
                    reinventaDatosCampania.FechaFin = request.FechaFin;
                    reinventaDatosCampania.ColorCabecera = request.ColorCabecera;
                    reinventaDatosCampania.ColorDetalle = request.ColorDetalle;
                    reinventaDatosCampania.TextoPrimario = request.TextoPrimario;
                    reinventaDatosCampania.TextoSecundario = request.TextoSecundario;
                    reinventaDatosCampania.ImagenPrimario = request.ImagenPrimario;
                    reinventaDatosCampania.FlagCarrusel = request.FlagCarrusel;
                    reinventaDatosCampania.ImagenSecundario = request.ImagenSecundario;
                    reinventaDatosCampania.TextoTerciario = request.TextoTerciario;
                    reinventaDatosCampania.MasInformacion = request.MasInformacion;
                    reinventaDatosCampania.UrlCampania = request.UrlCampania;
                    reinventaDatosCampania.TextoFinal1 = request.TextoFinal1;
                    reinventaDatosCampania.TextoFinal2 = request.TextoFinal2;
                    reinventaDatosCampania.TextoFinalUrl = request.TextoFinalUrl;
                    reinventaDatosCampania.ImagenFinal = request.ImagenFinal;
                    reinventaDatosCampania.UsuarioCreacion = request.UsuarioCreacion;
                    reinventaDatosCampania.Estado = request.Estado;
                    reinventaDatosCampania.IdExperimento = request.IdExperimento;
                    db.Entry(reinventaDatosCampania).State = EntityState.Modified;
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
