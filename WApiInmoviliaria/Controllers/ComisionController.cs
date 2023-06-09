﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WApiInmoviliaria.Models;
using WApiInmoviliaria.Clases;
using System.Web.Http.Cors;

namespace WApiInmoviliaria.Controllers
{
    public class ComisionController : ApiController
    {
        [EnableCors(origins: "http://localhost:3376", headers: "*", methods: "*")]
        // GET api/<controller>
        public List<modelCombo> Get()
        {
            clsComision comision = new clsComision();
            return comision.LlenarCombo();
        }

    }
}