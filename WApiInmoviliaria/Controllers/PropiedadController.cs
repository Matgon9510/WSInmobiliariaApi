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


        // POST api/values
        public string Post([FromBody] Propiedade propiedade)
        {
            clsPropiedad _propiedad = new clsPropiedad();
            _propiedad.propiedad = propiedade;
            return _propiedad.Agregar();
        }


        // PUT api/values/5
        public string Put([FromBody] Propiedade propiedade)
        {
            clsPropiedad _propiedad = new clsPropiedad();
            _propiedad.propiedad = propiedade;
            return _propiedad.Actualizar();
        }

        // DELETE api/values/5
        public string Delete([FromBody] Propiedade propiedade)
        {
            clsPropiedad _propiedad = new clsPropiedad();
            _propiedad.propiedad = propiedade;
            return _propiedad.Eliminar();
        }

    }
}