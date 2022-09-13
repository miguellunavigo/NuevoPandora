using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.BE
{
    public class NewPandoraExperimentoBE
    {
        public int IdExperimento { get; set; }
        public string NombreExperimento { get; set; }
        public string Descripcion { get; set; }
        public string Tecnologia { get; set; }
        public string DesarrolladoPor { get; set; }
        public Nullable<int> Indicador { get; set; }
        public Nullable<System.DateTime> FechaSolicitud { get; set; }
        public Nullable<System.DateTime> FechaPublicacion { get; set; }
        public string FechaSolicitudString { get { return FechaSolicitud.HasValue ? FechaSolicitud.Value.ToString("dd/MM/yyyy") : ""; } }
        public string FechaPublicacionString { get { return FechaPublicacion.HasValue ? FechaPublicacion.Value.ToString("dd/MM/yyyy") : ""; } }
        public string Url { get; set; }
        public Nullable<int> IdUsuarioContacto { get; set; }
        public Nullable<bool> FlagPublico { get; set; }
        public Nullable<int> IdStatusExperimento { get; set; }
    }
    public class NewPandoraExperimentoResponse<T>
    {
        public bool Result { get; set; }
        public string Mensaje { get; set; }
        public T data { get; set; }
    }
    public class NewPandoraExperimentoRequest
    {
        public int IdExperimento { get; set; }
        public string NombreExperimento { get; set; }
        public string Descripcion { get; set; }
        public string Tecnologia { get; set; }
        public string DesarrolladoPor { get; set; }
        public Nullable<int> Indicador { get; set; }
        public Nullable<System.DateTime> FechaSolicitud { get; set; }
        public Nullable<System.DateTime> FechaPublicacion { get; set; }
        public string Url { get; set; }
        public Nullable<int> IdUsuarioContacto { get; set; }
        public Nullable<bool> FlagPublico { get; set; }
        public Nullable<bool> FlagEstado { get; set; }
        public Nullable<int> IdStatusExperimento { get; set; }
    }
}
