using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WApiInmoviliaria.Models;


namespace WApiInmoviliaria.Clases
{
    public class clsCliente
    {
        DBInmobiliariaEntities dbsuper = new DBInmobiliariaEntities();

        public Cliente Consultar(int idCliente)
        {
            return dbsuper.Clientes.FirstOrDefault(p => p.id_cliente == idCliente);
        }
    }
}