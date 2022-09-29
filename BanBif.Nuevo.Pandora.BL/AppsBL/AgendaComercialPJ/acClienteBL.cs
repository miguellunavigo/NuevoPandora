using BanBif.Nuevo.Pandora.BE.AppsBE.AgendaComercialPJ;
using BanBif.Nuevo.Pandora.DA.AppsDA.AgendaComercialPJ;
using System;
using System.Collections.Generic;

namespace BanBif.Nuevo.Pandora.BL.AppsBL.AgendaComercialPJ
{
    public class acClienteBL
    {
        public acListaClienteResponse<List<acClienteBE>> ListarClientes(acListaClienteRequest request) {
            acListaClienteResponse<List<acClienteBE>> response = new acListaClienteResponse<List<acClienteBE>>();
            try
            {
                var ExperimentoDA = new acClientesDA();
                response.data = ExperimentoDA.ListarClientes().Lista;
                response.Result = true;

            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Mensaje = ex.InnerException.ToString();
            }

            return response;
        }
    }
}
