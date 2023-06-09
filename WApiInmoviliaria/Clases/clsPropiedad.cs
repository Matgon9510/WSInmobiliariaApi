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
            CalcularValorFinal();
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
            CalcularValorFinal();
            _propiedad.comision = propiedad.comision;
            _propiedad.precio_final = propiedad.precio_final;


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

        private void CalcularValorFinal()
        {
            double ValorUnitario;
            if (propiedad.precio_inicial <= 800000)
            {
                propiedad.comision = 1;
                ValorUnitario = 0.05;
            }
            else
            {
                if (propiedad.precio_inicial > 800000 && propiedad.precio_inicial <= 1500000)
                {
                    propiedad.comision = 2;
                    ValorUnitario = 0.1;
                }
                else
                {
                    propiedad.comision = 3;
                    ValorUnitario = 0.15;
                }
            }

            propiedad.precio_final = Convert.ToInt32((propiedad.precio_inicial * ValorUnitario) + propiedad.precio_inicial);
        }




    }
}