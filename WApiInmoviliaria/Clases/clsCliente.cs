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
        public Cliente cliente { get; set; }

        public string Agregar()
        {
            dbsuper.Clientes.Add(cliente);
            dbsuper.SaveChanges();
            return "Se agregó el cliente: " + cliente.nombre+" "+ cliente.apellido;
        }

        public Cliente Consultar(int idCliente)
        {
            return dbsuper.Clientes.FirstOrDefault(p => p.id_cliente == idCliente);
        }
    }
}