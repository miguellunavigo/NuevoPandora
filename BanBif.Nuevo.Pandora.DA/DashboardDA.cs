using BanBif.Nuevo.Pandora.BE;
using BanBif.Nuevo.Pandora.DA.ModelApp;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Nuevo.Pandora.DA
{
    public class DashboardDA
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public NewPandoraResponse<List<NewPandoraIndicadorGraficaBE>> ListarIndicadores(NewPandoraIndicadorRequest request)
        {
            NewPandoraResponse<List<NewPandoraIndicadorGraficaBE>> response = new NewPandoraResponse<List<NewPandoraIndicadorGraficaBE>>();
            try
            {
                using (panelEntities db = new panelEntities())
                {
                    var list = (from m in db.NewPandora_Indicador
                                join n in db.NewPandora_IndicadorRegistro on m.IdIndicador equals n.IdIndicador
                                where m.IdExperimento == request.IdExperimento
                                group n by new { Indicador = m.Indicador, Anio = n.Fecha.Value.Year, Mes = n.Fecha.Value.Month } into g
                                orderby g.Key.Indicador, g.Key.Anio, g.Key.Mes
                                select new NewPandoraIndicadorGraficaBE
                                {
                                    Indicador = g.Key.Indicador,
                                    Contador = g.Count(),
                                    Anio = g.Key.Anio,
                                    Mes = g.Key.Mes,
                                }).ToList();

                    response.data = list;
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }

        public NewPandoraResponse<Dashboard> ListarOrder()
        {
            NewPandoraResponse<Dashboard> response = new NewPandoraResponse<Dashboard>();
            try
            {
                using (panelEntities db = new panelEntities())
                {
                    Dashboard data = new Dashboard();
                    Series series = new Series();

                    var query = db.NewPandora_Experimento.Where(m => m.FlagExitosRapidos == true && m.FechaPublicacion.HasValue).
                        GroupBy(p => p.FechaPublicacion.Value.Year).Select(g => new { name = g.Key, count = g.Count() });


                    //var query2 = db.NewPandora_Experimento.Where(m => m.FlagExitosRapidos == true && m.FechaPublicacion.HasValue).
                    //  GroupBy(p => p.FechaPublicacion.Value.Year).Select(g => new Dashboard() { name = g.Key.ToString(), data = new List<int>(g.Count()) });

                    foreach (var item in query)
                    {
                        //var objList = data.series.Where(p => p.name == item.name.ToString()).FirstOrDefault();
                        //if (objList == null)
                        //{
                        //    Series obj = new Series();
                        //    obj.name = item.name.ToString();
                        //    obj.data.Add(item.count);

                        //}
                        //else
                        //{
                        //    objList.data.Add(item.count);
                        //}
                        series.name = string.Empty;
                        series.data.Add(item.count);
                    }
                    data.series.Add(series);

                    response.Result = true;
                    response.data = data;
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }

        public NewPandoraResponse<int> ListarPayments()
        {
            NewPandoraResponse<int> response = new NewPandoraResponse<int>();
            try
            {
                using (panelEntities db = new panelEntities())
                {
                    Dashboard data = new Dashboard();

                    var query2 = db.NewPandora_PropuestaExperimento.Count();
                    //data.data = new List<int>(query2);
                    response.Result = true;
                    response.data = query2;
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }

        public NewPandoraResponse<Dashboard> ListarRevenue()
        {
            NewPandoraResponse<Dashboard> response = new NewPandoraResponse<Dashboard>();
            try
            {
                using (panelEntities db = new panelEntities())
                {
                    Dashboard data = new Dashboard();
                    Series series = new Series();
                    var list = (from m in db.NewPandora_Experimento
                                join n in db.NewPandora_Productos on m.IdProducto equals n.IdProducto
                                group n by new { Producto = n.Nombre } into g
                                orderby g.Key.Producto
                                select new NewPandoraIndicadorGraficaBE
                                {
                                    Indicador = g.Key.Producto,
                                    Contador = g.Count(),
                                }).ToList();

                    foreach (var item in list)
                    {
                        data.categories.Add(item.Indicador);
                    }

                    foreach (var item in list)
                    {
                        series.name = string.Empty;
                        series.data.Add(item.Contador);
                    }
                    data.series.Add(series);
                    response.Result = true;
                    response.data = data;
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }

        public NewPandoraResponse<Dashboard> ListarTotalRevenue()
        {
            NewPandoraResponse<Dashboard> response = new NewPandoraResponse<Dashboard>();
            try
            {
                Dashboard data = new Dashboard();
                using (panelEntities db = new panelEntities())
                {
                    var list = (from m in db.NewPandora_Experimento
                                where m.FechaPublicacion.HasValue
                                group m by new { Anio = m.FechaPublicacion.Value.Year, Mes = m.FechaPublicacion.Value.Month } into g
                                orderby g.Key.Anio, g.Key.Mes
                                select new NewPandoraIndicadorGraficaBE
                                {
                                    Contador = g.Count(),
                                    Anio = g.Key.Anio,
                                    Mes = g.Key.Mes,
                                }).ToList();

                    foreach (var itemAnio in list.GroupBy(p => p.Anio))
                    {
                        Series series = new Series();
                        series.name = itemAnio.Key.ToString();

                        for (int i = 1; i < 13; i++)
                        {                            
                            if (!list.Where(p => p.Anio == itemAnio.Key && p.Mes == i).Any())
                            {
                                list.Add(new NewPandoraIndicadorGraficaBE() { Contador = 0, Anio = itemAnio.Key, Mes = i });
                            }
                        }

                        foreach (var itemMes in list.Where(p => p.Anio == itemAnio.Key).OrderBy(p => p.Mes))
                        {

                            series.data.Add(itemMes.Contador);
                        }

                        data.series.Add(series);
                    }

                    response.Result = true;
                    response.data = data;
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }

        public NewPandoraResponse<List<NewPandoraIndicadorGraficaBE>> ListarOrderStatics(NewPandoraIndicadorRequest request)
        {
            NewPandoraResponse<List<NewPandoraIndicadorGraficaBE>> response = new NewPandoraResponse<List<NewPandoraIndicadorGraficaBE>>();
            try
            {
                using (panelEntities db = new panelEntities())
                {
                    var list = (from m in db.NewPandora_Indicador
                                join n in db.NewPandora_IndicadorRegistro on m.IdIndicador equals n.IdIndicador
                                where m.IdExperimento == request.IdExperimento
                                group n by new { Indicador = m.Indicador, Anio = n.Fecha.Value.Year, Mes = n.Fecha.Value.Month } into g
                                orderby g.Key.Indicador, g.Key.Anio, g.Key.Mes
                                select new NewPandoraIndicadorGraficaBE
                                {
                                    Indicador = g.Key.Indicador,
                                    Contador = g.Count(),
                                    Anio = g.Key.Anio,
                                    Mes = g.Key.Mes,
                                }).ToList();

                    response.data = list;
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }

        public NewPandoraResponse<Dashboard> ListarTecnologia()
        {
            NewPandoraResponse<Dashboard> response = new NewPandoraResponse<Dashboard>();
            try
            {
                using (panelEntities db = new panelEntities())
                {
                    Dashboard data = new Dashboard();
                    Series series = new Series();
                    var list = (from m in db.NewPandora_Experimento                                
                                group m by new { Tecnologia = m.Tecnologia } into g
                                orderby g.Key.Tecnologia
                                select new NewPandoraIndicadorGraficaBE
                                {
                                    Indicador = g.Key.Tecnologia,
                                    Contador = g.Count(),
                                }).ToList();

                    foreach (var item in list)
                    {
                        data.categories.Add(item.Indicador);
                    }

                    foreach (var item in list)
                    {
                        series.name = string.Empty;
                        series.data.Add(item.Contador);
                    }
                    data.series.Add(series);
                    response.Result = true;
                    response.data = data;
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }

        public NewPandoraResponse<Dashboard> ListarTransactions()
        {
            NewPandoraResponse<Dashboard> response = new NewPandoraResponse<Dashboard>();
            try
            {
                using (panelEntities db = new panelEntities())
                {
                    Dashboard data = new Dashboard();
                    
                    var list = (from m in db.NewPandora_Experimento
                                group m by new { TipoUsuario = m.TipoUsuario } into g
                                orderby g.Key.TipoUsuario
                                select new NewPandoraIndicadorGraficaBE
                                {
                                    Indicador = g.Key.TipoUsuario,
                                    Contador = g.Count(),
                                }).ToList();

                    

                    foreach (var item in list)
                    {
                        Series series = new Series();
                        series.name = item.Indicador;
                        series.data.Add(item.Contador);
                        data.series.Add(series);
                    }
                    
                    response.Result = true;
                    response.data = data;
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }

        public NewPandoraResponse<Dashboard> ListarBrowser()
        {
            NewPandoraResponse<Dashboard> response = new NewPandoraResponse<Dashboard>();
            try
            {
                using (panelEntities db = new panelEntities())
                {
                    Dashboard data = new Dashboard();

                    var list = (from m in db.NewPandora_Experimento
                                group m by new { StatusExperimento = m.NewPandora_StatusExperimento.Status } into g
                                orderby g.Key.StatusExperimento
                                select new NewPandoraIndicadorGraficaBE
                                {
                                    Indicador = g.Key.StatusExperimento,
                                    Contador = g.Count(),
                                }).ToList();



                    foreach (var item in list)
                    {
                        Series series = new Series();
                        series.name = item.Indicador;
                        series.data.Add(item.Contador);
                        data.series.Add(series);
                    }

                    response.Result = true;
                    response.data = data;
                }
            }
            catch (Exception ex)
            {
                response.Mensaje = ex.Message;
            }
            return response;
        }
    }
}
