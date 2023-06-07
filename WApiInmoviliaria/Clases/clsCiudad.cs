using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WApiInmoviliaria.Models;

namespace WApiInmoviliaria.Clases
{
    public class clsCiudad
    {
        DBInmobiliariaEntities dbsuper = new DBInmobiliariaEntities();
        public List<modelCombo> LlenarCombo()
        {
            return dbsuper.Ciudads

                    .OrderBy(p => p.descripcion)
                    .Select(p => new modelCombo
                    {
                        Valor = p.id_ciudad.ToString(),
                        Texto = p.descripcion
                    }).ToList();
        }
    }
}