using System.Linq;
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
            return "Se agregó el cliente: " + cliente.nombre + " " + cliente.apellido;
        }

        public Cliente Consultar(int idCliente)
        {
            return dbsuper.Clientes.FirstOrDefault(p => p.id_cliente == idCliente);
        }

        public string Eliminar(int idCliente)
        {
            Cliente _cliente = dbsuper.Clientes.FirstOrDefault(p => p.id_cliente == idCliente);

            if (_cliente != null)
            {
                dbsuper.Clientes.Remove(_cliente);
                dbsuper.SaveChanges();
                return "Se eliminó el Cliente: " + _cliente.nombre + " " + _cliente.apellido;
            }
            else
            {
                return "No se encontró el cliente con ID: " + idCliente;
            }
        }


    }
}