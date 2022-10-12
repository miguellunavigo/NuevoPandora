using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.BE
{
    public class ReinventaDatosCampaniaBE
    {
        public int IdCampania { get; set; }
        public string NombreCampania { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public string FechaInicioString { get { return FechaInicio.HasValue ? FechaInicio.Value.ToString("dd/MM/yyyy") : ""; } }
        public string FechaFinString { get { return FechaFin.HasValue ? FechaFin.Value.ToString("dd/MM/yyyy") : ""; } }
        public string ColorCabecera { get; set; }
        public string ColorDetalle { get; set; }
        public string TextoPrimario { get; set; }
        public string TextoSecundario { get; set; }
        public string ImagenPrimario { get; set; }
        public Nullable<bool> FlagCarrusel { get; set; }
        public string ImagenSecundario { get; set; }
        public string TextoTerciario { get; set; }
        public string MasInformacion { get; set; }
        public string UrlCampania { get; set; }
        public string TextoFinal1 { get; set; }
        public string TextoFinal2 { get; set; }
        public string TextoFinalUrl { get; set; }
        public string ImagenFinal { get; set; }
        public string UsuarioCreacion { get; set; }
        public Nullable<int> Estado { get; set; }
        public Nullable<int> IdExperimento { get; set; }
    }
    public class ReinventaDatosCampaniaRequest
    {
        public int IdCampania { get; set; }
        public string NombreCampania { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public string ColorCabecera { get; set; }
        public string ColorDetalle { get; set; }
        public string TextoPrimario { get; set; }
        public string TextoSecundario { get; set; }
        public string ImagenPrimario { get; set; }
        public Nullable<bool> FlagCarrusel { get; set; }
        public string ImagenSecundario { get; set; }
        public string TextoTerciario { get; set; }
        public string MasInformacion { get; set; }
        public string UrlCampania { get; set; }
        public string TextoFinal1 { get; set; }
        public string TextoFinal2 { get; set; }
        public string TextoFinalUrl { get; set; }
        public string ImagenFinal { get; set; }
        public string UsuarioCreacion { get; set; }
        public Nullable<int> Estado { get; set; }
        public Nullable<int> IdExperimento { get; set; }

    }
}
