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

    public class NewPandoraIndicadorRequest
    {
        public int IdIndicador { get; set; }
        public Nullable<int> IdExperimento { get; set; }
        public string Indicador { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<bool> FlagMostrar { get; set; }
    }

    public class Dashboard
    {      
        public List<Series> series { get; set; } = new List<Series>();
        public List<string> categories { get; set; } = new List<string>();


    }
    public class Series {
        public string name { get; set; }
        public List<int> data { get; set; } = new List<int>();
    }
    
}
