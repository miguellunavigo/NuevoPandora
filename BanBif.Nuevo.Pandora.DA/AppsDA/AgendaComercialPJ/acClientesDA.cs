using System.Linq;
using BanBif.Nuevo.Pandora.BE.AppsBE.AgendaComercialPJ;
using BanBif.Nuevo.Pandora.DA.ModelApp;
using System.Collections.Generic;
using System;

namespace BanBif.Nuevo.Pandora.DA.AppsDA.AgendaComercialPJ
{
    public class acClientesDA
    {

        public acListaClientesBE ListarClientes()
        {
            using (var db = new agendapjEntities())
            {

                var result = new acListaClientesBE();
                var clientes = db.TBL_mAGENDACOMERCIAL_CLIENTE.ToList();
                result.Lista = new List<acClienteBE>();

                foreach (var item in clientes)
                {

                    result.Lista.Add(new acClienteBE
                    {
                        CodigoCliente = item.CODIGOCLIENTE,
                        RazonSocial = item.RAZON_SOCIAL,
                        RUC = item.RUC,
                        CrossCliente = item.CROSS_CLIENTE,
                        Facturacion = item.FACTURACION,
                        GiroNegocio = item.GIRO_NEGOCIO,
                        Score = item.SCORE,
                        Segmento = item.SEGMENTO
                    });
                }

                return result;
            }
        }
        public acListaClientesBE ObtenerClientes(acListaClienteRequest request)
        {
            using (var db = new agendapjEntities())
            {

                var result = new acListaClientesBE();
                var clientes = db.TBL_mAGENDACOMERCIAL_CLIENTE.Where(p => p.CODIGOCLIENTE == request.CodigoCliente).ToList();
                foreach (var item in clientes)
                {

                    result.Obtener = new acClienteBE
                    {
                        CodigoCliente = item.CODIGOCLIENTE,
                        RUC = item.RUC,
                        RazonSocial = item.RAZON_SOCIAL,
                        Direccion = item.DIRECCION,
                        Departamento = item.DEPARTAMENTO,
                        Provincia = item.PROVINCIA,
                        Distrito = item.DISTRITO,
                        Correo = item.CORREO,
                        Telefono = item.TELEFONO,
                        Zona = item.ZONA,
                        GiroNegocio = item.GIRO_NEGOCIO,
                        GrupoEconomico = item.GRUPO_ECONOMICO,
                        Segmento = item.SEGMENTO,
                        Score = item.SCORE,
                        CrossCliente = item.CROSS_CLIENTE,
                        Facturacion = item.FACTURACION,
                        ROE = item.ROE,
                        SOW = item.SOW,
                        Rentabilidad = item.RENTABILIDAD,
                        VolumenNegocio = item.VOLUMEN_NEGOCIO,
                        VolumenPasivos = item.VOLUMEN_PASIVOS,
                        VolumenActivos = item.VOLUMEN_ACTIVOS,
                        VolumenContingentes = item.VOLUMEN_CONTINGENTES,
                        CalificacionBanBif = item.CALIFICACION_BANBIF,
                        CalificacionSSFF = item.CALIFICACION_SSFF,
                        SistemaVigilancia = item.SISTEMA_VIGILANCIA,
                        LineaDisponible = item.LINEA_DISPONIBLE,
                        DeudaRCC = item.DEUDA_RCC
                    };
                }

                return result;
            }
        }


        public NewPandoraResponse<int> CrearClientesContacto(acListaClienteContactoRequest request)
        {
            NewPandoraResponse<int> response = new NewPandoraResponse<int>();
            try
            {
                using (agendapjEntities db = new agendapjEntities())
                {
                    var insert = new TBL_mAGENDACOMERCIAL_CLIENTE_CONTACTO();
                    insert.CODIGOCONTACTO = request.CodigoContacto;
                    insert.CODIGOCLIENTE = request.CodigoCliente;
                    insert.NOMBRE_APELLIDO = request.NombreApellido;
                    insert.CARGO = request.Cargo;
                    insert.CORREO = request.Correo;
                    insert.TELEFONO = request.Telefono;
                    db.TBL_mAGENDACOMERCIAL_CLIENTE_CONTACTO.Add(insert);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }
        public List<acClienteContactoBE> ListarClientesContacto(acListaClienteContactoRequest request)
        {
            using (var db = new agendapjEntities())
            {
                var result = new List<acClienteContactoBE>();
                var clientes = db.TBL_mAGENDACOMERCIAL_CLIENTE_CONTACTO.Where(p => p.CODIGOCLIENTE == request.CodigoCliente).ToList();

                foreach (var item in clientes)
                {

                    result.Add(new acClienteContactoBE
                    {
                        CodigoContacto = item.CODIGOCONTACTO,
                        CodigoCliente = item.CODIGOCONTACTO,
                        NombreApellido = item.NOMBRE_APELLIDO,
                        Cargo = item.CARGO,
                        Correo = item.CORREO,
                        Telefono = item.TELEFONO,
                    });
                }

                return result;
            }
        }
        public acClienteContactoBE ObtenerClientesContacto(acListaClienteContactoRequest request)
        {
            using (var db = new agendapjEntities())
            {

                var result = new acClienteContactoBE();
                var clientes = db.TBL_mAGENDACOMERCIAL_CLIENTE_CONTACTO.Where(p => p.CODIGOCONTACTO == request.CodigoContacto).ToList();
                foreach (var item in clientes)
                {

                    result = new acClienteContactoBE
                    {
                        CodigoContacto = item.CODIGOCONTACTO,
                        CodigoCliente = item.CODIGOCONTACTO,
                        NombreApellido = item.NOMBRE_APELLIDO,
                        Cargo = item.CARGO,
                        Correo = item.CORREO,
                        Telefono = item.TELEFONO,
                    };
                }

                return result;
            }
        }

        public List<acClienteContactoComentarioBE> ListarClienteContactoComentarios(acListaClienteContactoComentarioRequest request)
        {
            using (var db = new agendapjEntities())
            {

                var result = new List<acClienteContactoComentarioBE>();
                var clientes = db.TBL_mAGENDACOMERCIAL_CLIENTE_CONTACTO_COMENTARIOS.Where(p => p.CODIGOCONTACTO == request.CodigoContacto).ToList();
                result = new List<acClienteContactoComentarioBE>();

                foreach (var item in clientes)
                {

                    result.Add(new acClienteContactoComentarioBE
                    {
                        CodigoComentario = item.CODIGOCOMENTARIO,
                        CodigoContacto = item.CODIGOCONTACTO.Value,
                        Comentario = item.COMENTARIO
                    });
                }

                return result;
            }
        }
    }
}
