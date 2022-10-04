using BanBif.Nuevo.Pandora.BE.AppsBE.AgendaComercialPJ;
using BanBif.Nuevo.Pandora.DA.AppsDA.AgendaComercialPJ;
using System;
using System.Collections.Generic;

namespace BanBif.Nuevo.Pandora.BL.AppsBL.AgendaComercialPJ
{
    public class acClienteBL
    {
        public acListaClienteResponse<List<acClienteBE>> ListarClientes(acListaClienteRequest request)
        {
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
        public acListaClienteResponse<acClienteBE> ObtenerClientes(acListaClienteRequest request)
        {
            acListaClienteResponse<acClienteBE> response = new acListaClienteResponse<acClienteBE>();
            try
            {
                var ExperimentoDA = new acClientesDA();
                response.data = ExperimentoDA.ObtenerClientes(request).Obtener;
                response.Result = true;

            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Mensaje = ex.InnerException.ToString();
            }

            return response;
        }


        public NewPandoraResponse<int> CrearClientesContacto(acListaClienteContactoRequest request)
        {
            NewPandoraResponse<int> response = new NewPandoraResponse<int>();
            try
            {
                var acClientesDA = new acClientesDA();
                response = acClientesDA.CrearClientesContacto(request);
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.InnerException.ToString();
            }
            return response;
        }
        public acListaClienteResponse<List<acClienteContactoBE>> ListarClientesContacto(acListaClienteContactoRequest request)
        {
            acListaClienteResponse<List<acClienteContactoBE>> response = new acListaClienteResponse<List<acClienteContactoBE>>();
            try
            {
                var ExperimentoDA = new acClientesDA();
                response.data = ExperimentoDA.ListarClientesContacto(request);
                response.Result = true;

            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Mensaje = ex.InnerException.ToString();
            }

            return response;
        }
        public acListaClienteResponse<acClienteContactoBE> ObtenerClientesContacto(acListaClienteContactoRequest request)
        {
            acListaClienteResponse<acClienteContactoBE> response = new acListaClienteResponse<acClienteContactoBE>();
            try
            {
                var acClientesDA = new acClientesDA();
                response.data = acClientesDA.ObtenerClientesContacto(request);
                response.Result = true;

            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Mensaje = ex.InnerException.ToString();
            }

            return response;
        }
        public acListaClienteResponse<List<acClienteContactoComentarioBE>> ListarClienteContactoComentarios(acListaClienteContactoComentarioRequest request)
        {
            acListaClienteResponse<List<acClienteContactoComentarioBE>> response = new acListaClienteResponse<List<acClienteContactoComentarioBE>>();
            try
            {
                var acClientesDA = new acClientesDA();
                response.data = acClientesDA.ListarClienteContactoComentarios(request);
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
