﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WApiInmoviliaria.Models;
using System.Web.Http.Cors;

namespace WApiInmoviliaria.Clases
{
    public class clsTelefono
    {
        DBInmobiliariaEntities dbsuper = new DBInmobiliariaEntities();
        public Telefono telefono { get; set; }
        public string Agregar()
        {
            dbsuper.Telefonoes.Add(telefono);
            dbsuper.SaveChanges();
            return "Se agregó el teléfono: " + telefono.numero;
        }
        public string Eliminar()
        {
            Telefono _telefono = dbsuper.Telefonoes
                                .Where(p => p.id_tel == telefono.id_tel)
                                .FirstOrDefault();
            dbsuper.Telefonoes.Remove(_telefono);
            dbsuper.SaveChanges();
            return "Se eliminó el teléfono: " + telefono.numero;
        }
        public string Actualizar()
        {
            Telefono _telefono = dbsuper.Telefonoes
                                .Where(p => p.id_tel == telefono.id_tel)
                                .FirstOrDefault();
            _telefono.tipo_telefono = telefono.tipo_telefono;
            _telefono.numero = telefono.numero;

            dbsuper.SaveChanges();
            return "Se actualizó el teléfono con número " + telefono.numero;
        }
        public IQueryable ListarTelefonos(string id_cliente)
        {
            return from Tel in dbsuper.Set<Telefono>()
                   join TiTe in dbsuper.Set<Tipo_Tel>()
                   on Tel.tipo_telefono equals TiTe.id_tipo_tel
                   where Convert.ToString(Tel.cliente) == id_cliente
                   select new
                   {
                       id_tel = Tel.id_tel,
                       tipo_telefono = TiTe.id_tipo_tel,
                       descripcion = TiTe.descripcion,
                       numero = Tel.numero
                   };
        }
    }
}
