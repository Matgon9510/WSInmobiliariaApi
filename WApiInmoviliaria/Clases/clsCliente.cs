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

        public string Actualizar()
        {
            Cliente _cliente = dbsuper.Clientes
                                .Where(p => p.id_cliente == cliente.id_cliente)
                                .FirstOrDefault();
            _cliente.nombre = cliente.nombre;
            _cliente.apellido = cliente.apellido;
            _cliente.email = cliente.email;
            _cliente.tipo_tel = cliente.tipo_tel;
            _cliente.telefono = cliente.nombre;
            _cliente.genero = cliente.genero;
            _cliente.direccion = cliente.direccion;
            _cliente.ciudad = cliente.ciudad;
            dbsuper.SaveChanges();
            return "Se actualizó el Cliente: " + _cliente.nombre + " " + _cliente.apellido;
        }

        public string Eliminar()
        {
            Cliente _cliente = dbsuper.Clientes
                                .Where(p => p.id_cliente == cliente.id_cliente)
                                .FirstOrDefault();
            if (_cliente != null)
            {
                dbsuper.Clientes.Remove(_cliente);
                dbsuper.SaveChanges();
                return "Se eliminó el Cliente: " + _cliente.nombre + " " + _cliente.apellido;
            }
            else         
                return "No se encontró el cliente con ID: " + cliente.id_cliente;  
        }

    }
}