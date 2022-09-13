using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.BE
{
    public class NewPandoraPropuestaExperimentoBE
    {
        public int IdPropuestaExperimento { get; set; }
        public string NombrePropuestaExperimento { get; set; }
        public string Descripcion { get; set; }
        public string Tecnologia { get; set; }
        public Nullable<int> Indicador { get; set; }
        public Nullable<System.DateTime> FechaSolicitud { get; set; }
        public string FechaSolicitudString { get { return FechaSolicitud.HasValue ? FechaSolicitud.Value.ToString("dd/MM/yyyy") : ""; } }
        public Nullable<int> IdUsuarioContacto { get; set; }
        public Nullable<bool> FlagPublico { get; set; }
        public Nullable<int> IdStatusExperimento { get; set; }
    }
    public class NewPandoraPropuestaExperimentoResponse<T>
    {
        public bool Result { get; set; }
        public string Mensaje { get; set; }
        public T data { get; set; }
    }
    public class NewPandoraPropuestaExperimentoRequest
    {
        public int IdPropuestaExperimento { get; set; }
        public string NombrePropuestaExperimento { get; set; }
        public string Descripcion { get; set; }
        public string Tecnologia { get; set; }
        public Nullable<int> Indicador { get; set; }
        public Nullable<System.DateTime> FechaSolicitud { get; set; }
        public Nullable<int> IdUsuarioContacto { get; set; }
        public Nullable<bool> FlagPublico { get; set; }
        public Nullable<int> IdStatusExperimento { get; set; }
    }
}
