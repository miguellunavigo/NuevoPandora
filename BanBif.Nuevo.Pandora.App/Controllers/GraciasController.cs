﻿using BanBif.Nuevo.Pandora.BE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BanBif.Nuevo.Pandora.App.Controllers
{
    public class GraciasController : Controller
    {
        // GET: Gracias
        public ActionResult Index()
        {
            //ViewBag.URL = ConfigurationManager.AppSettings.Get("UrlApp").ToString();
            //ReinventaDatosCampaniaResponse loginResponse = (ReinventaDatosCampaniaResponse)Session["loginResponse"];

            return View();
        }

      
    }
}
