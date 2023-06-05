using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WApiInmoviliaria.Clases;
using WApiInmoviliaria.Models;

namespace WApiInmoviliaria.Controllers
{
    public class ClienteController : ApiController
    {
        // GET api/<controller>/5
        public Cliente Get(int idCliente)
        {
            clsCliente cliente = new clsCliente();
            return cliente.Consultar(idCliente);
        }
    }
}