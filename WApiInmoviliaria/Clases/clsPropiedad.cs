using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WApiInmoviliaria.Models;


namespace WApiInmoviliaria.Clases
{
    public class clsPropiedad
    {
        DBInmobiliariaEntities dbsuper = new DBInmobiliariaEntities();

        public Propiedade propiedad { get; set; }

        public string Agregar()
        {
            dbsuper.Propiedades.Add(propiedad);
            dbsuper.SaveChanges();
            return "Se agregó la  propiedad: " + propiedad.id_propiedad;
        }

        public Propiedade Consultar(int idPropiedad)
        {
            return dbsuper.Propiedades.FirstOrDefault(p => p.id_propiedad == idPropiedad);
        }

        public string Actualizar()
        {
            Propiedade _propiedad = dbsuper.Propiedades
                                .Where(p => p.id_propiedad == propiedad.id_propiedad)
                                .FirstOrDefault();
            _propiedad.id_propiedad = propiedad.id_propiedad;
            _propiedad.direccion = propiedad.direccion;
            _propiedad.ciudad = propiedad.ciudad;
            _propiedad.departamento = propiedad.departamento;
            _propiedad.tipo_propiedad = propiedad.tipo_propiedad;
            _propiedad.num_habitaciones = propiedad.num_habitaciones;
            _propiedad.num_banos = propiedad.num_banos;
            _propiedad.estacionamiento = propiedad.estacionamiento;
            _propiedad.estado = propiedad.estado;
            _propiedad.tipo_contrato = propiedad.tipo_contrato;
            _propiedad.precio_inicial = propiedad.precio_inicial;


            dbsuper.SaveChanges();
            return "Se actualizó la propiedad " + propiedad.id_propiedad;
        }

        public string Eliminar()
        {
            Propiedade _propiedad = dbsuper.Propiedades
                                .Where(p => p.id_propiedad == propiedad.id_propiedad)
                                .FirstOrDefault();
            dbsuper.Propiedades.Remove(_propiedad);
            dbsuper.SaveChanges();
            return "Se eliminó la Propiedad: " + propiedad.id_propiedad;
        }
    }
}