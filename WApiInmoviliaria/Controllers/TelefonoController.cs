using System;
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
    [EnableCors(origins: "http://localhost:3376", headers: "*", methods: "*")]
    public class TelefonoController : ApiController
    {
        // GET api/<controller>
        public IQueryable Get(string id_cliente)
        {
            clsTelefono telefono = new clsTelefono();
            return telefono.ListarTelefonos(id_cliente);
        }
        // POST api/values
        public string Post([FromBody] Telefono telefono)
        {
            clsTelefono _telefono = new clsTelefono();
            _telefono.telefono = telefono;
            return _telefono.Agregar();
        }

        // PUT api/values/5
        public string Put([FromBody] Telefono telefono)
        {
            clsTelefono _telefono = new clsTelefono();
            _telefono.telefono = telefono;
            return _telefono.Actualizar();
        }

        // DELETE api/values/5
        public string Delete([FromBody] Telefono telefono)
        {
            clsTelefono _telefono = new clsTelefono();
            _telefono.telefono = telefono;
            return _telefono.Eliminar();
        }
    }
}