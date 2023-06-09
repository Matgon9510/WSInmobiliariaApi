using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WApiInmoviliaria.Models;

namespace WApiInmoviliaria.Clases
{
    public class clsEstacionamiento
    {
        DBInmobiliariaEntities dbsuper = new DBInmobiliariaEntities();
        public List<modelCombo> LlenarCombo()
        {
            return dbsuper.Estacionamientoes

                    .OrderBy(p => p.descripcion)
                    .Select(p => new modelCombo
                    {
                        Valor = p.id_estacionamiento.ToString(),
                        Texto = p.descripcion
                    }).ToList();
        }
    }
}