using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.BE
{
    public class NewPandoraIndicadorGraficaBE
    {
        public int IdIndicador { get; set; }
        public string Indicador { get; set; }
        public int Contador { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public string AnioMes { get { return Mes.ToString("D2") + "/" + Anio.ToString(); } }
    }


    public class NewPandoraIndicadorBE
    {
        public int IdIndicador { get; set; }
        public Nullable<int> IdExperimento { get; set; }
        public string Indicador { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<bool> FlagMostrar { get; set; }
        public int Contador { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
    }
    public class NewPandoraIndicadorResponse<T>
    {
        public bool Result { get; set; }
        public string Mensaje { get; set; }
        public T data { get; set; }
    }
    public class NewPandoraIndicadorRequest
    {
        public int IdIndicador { get; set; }
        public Nullable<int> IdExperimento { get; set; }
        public string Indicador { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<bool> FlagMostrar { get; set; }
    }
}
