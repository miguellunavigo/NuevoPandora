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
        public Nullable<System.DateTime> FechaSolicitud { get; set; }
        public Nullable<System.DateTime> FechaPublicacion { get; set; }
        public string FechaSolicitudString { get { return FechaSolicitud.HasValue ? FechaSolicitud.Value.ToString("dd/MM/yyyy") : ""; } }
        public string FechaPublicacionString { get { return FechaPublicacion.HasValue ? FechaPublicacion.Value.ToString("dd/MM/yyyy") : ""; } }
        public string Url { get; set; }
        public Nullable<int> IdUsuarioContacto { get; set; }
        public Nullable<bool> FlagPublico { get; set; }
        public Nullable<int> IdStatusExperimento { get; set; }
        public string StatusExperimento { get; set; }
        public int StatusOrden { get; set; }
        public Nullable<System.DateTime> FechaLanzamiento { get; set; }
        public string FechaLanzamientoString { get { return FechaLanzamiento.HasValue ? FechaLanzamiento.Value.ToString("dd/MM/yyyy") : ""; } }
        public Nullable<int> IdProducto { get; set; }
        public Nullable<System.DateTime> FechaInicioCronograma { get; set; }
        public Nullable<System.DateTime> FechaFinCronograma { get; set; }
        public string FechaInicioCronogramaString { get { return FechaInicioCronograma.HasValue ? FechaInicioCronograma.Value.ToString("dd/MM/yyyy") : ""; } }
        public string FechaFinCronogramaString { get { return FechaFinCronograma.HasValue ? FechaFinCronograma.Value.ToString("dd/MM/yyyy") : ""; } }
        public Nullable<bool> FlagExitosRapidos { get; set; }
        public string Plantilla { get; set; }
        public string TipoUsuario { get; set; }

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
        public Nullable<System.DateTime> FechaLanzamiento { get; set; }
        public Nullable<int> IdProducto { get; set; }
        public Nullable<System.DateTime> FechaInicioCronograma { get; set; }
        public Nullable<System.DateTime> FechaFinCronograma { get; set; }
        public Nullable<bool> FlagExitosRapidos { get; set; }
        public string Plantilla { get; set; }
        public string TipoUsuario { get; set; }
    }
}
