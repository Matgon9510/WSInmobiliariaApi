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
    public class ClienteController : ApiController
    {
        // GET api/<controller>/5
        public Cliente Get(int idCliente)
        {
            clsCliente cliente = new clsCliente();
            return cliente.Consultar(idCliente);
        }
        // POST api/values
        public string Post([FromBody] Cliente cliente)
        {
            clsCliente _cliente = new clsCliente();
            _cliente.cliente = cliente;
            return _cliente.Agregar();
        }
    }
}