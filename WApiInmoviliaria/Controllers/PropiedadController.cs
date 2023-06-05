using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WApiInmoviliaria.Clases;
using WApiInmoviliaria.Models;
using System.Web.Http.Cors;

namespace WApiInmoviliaria.Controllers
{
    [EnableCors(origins: "http://localhost:3376", headers: "*", methods: "*")]
    public class PropiedadController : ApiController
    {
            // GET api/<controller>/5
            public Propiedade Get(int idPropiedad)
            {
                clsPropiedad propiedad = new clsPropiedad();
                return propiedad.Consultar(idPropiedad);
            }
        }
}
