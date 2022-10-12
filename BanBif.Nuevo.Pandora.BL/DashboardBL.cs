using BanBif.Nuevo.Pandora.BE;
using BanBif.Nuevo.Pandora.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.BL
{
    /// <summary>
    /// 
    /// </summary>
    public class DashboardBL
    {
        public NewPandoraResponse<List<NewPandoraIndicadorGraficaBE>> ListarIndicadores(NewPandoraIndicadorRequest request)
        {
            NewPandoraResponse<List<NewPandoraIndicadorGraficaBE>> response = new NewPandoraResponse<List<NewPandoraIndicadorGraficaBE>>();
            try
            {
                var ExperimentoDA = new DashboardDA();
                response = ExperimentoDA.ListarIndicadores(request);
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }

        public NewPandoraResponse<Dashboard> ListarOrder()
        {
            NewPandoraResponse<Dashboard> response = new NewPandoraResponse<Dashboard>();
            try
            {
                var ExperimentoDA = new DashboardDA();
                response = ExperimentoDA.ListarOrder();
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }

        public NewPandoraResponse<int> ListarPayments()
        {
            NewPandoraResponse<int> response = new NewPandoraResponse<int>();
            try
            {
                var ExperimentoDA = new DashboardDA();
                response = ExperimentoDA.ListarPayments();
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }

        public NewPandoraResponse<Dashboard> ListarRevenue()
        {
            NewPandoraResponse<Dashboard> response = new NewPandoraResponse<Dashboard>();
            try
            {
                var ExperimentoDA = new DashboardDA();
                response = ExperimentoDA.ListarRevenue();
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }

        public NewPandoraResponse<Dashboard> ListarTotalRevenue()
        {
            NewPandoraResponse<Dashboard> response = new NewPandoraResponse<Dashboard>();
            try
            {
                var ExperimentoDA = new DashboardDA();
                response = ExperimentoDA.ListarTotalRevenue();
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }
        public NewPandoraResponse<Dashboard> ListarTecnologia()
        {
            NewPandoraResponse<Dashboard> response = new NewPandoraResponse<Dashboard>();
            try
            {
                var ExperimentoDA = new DashboardDA();
                response = ExperimentoDA.ListarTecnologia();
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }
        public NewPandoraResponse<Dashboard> ListarTransactions()
        {
            NewPandoraResponse<Dashboard> response = new NewPandoraResponse<Dashboard>();
            try
            {
                var ExperimentoDA = new DashboardDA();
                response = ExperimentoDA.ListarTransactions();
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }
        public NewPandoraResponse<Dashboard> ListarBrowser()
        {
            NewPandoraResponse<Dashboard> response = new NewPandoraResponse<Dashboard>();
            try
            {
                var ExperimentoDA = new DashboardDA();
                response = ExperimentoDA.ListarBrowser();
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }
        
    }
}
