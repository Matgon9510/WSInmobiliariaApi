using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WApiInmoviliaria.Models;

namespace WApiInmoviliaria.Clases
{
    public class clsTipoPropiedad
    {
        DBInmobiliariaEntities dbsuper = new DBInmobiliariaEntities();
        public List<modelCombo> LlenarCombo()
        {
            return dbsuper.TiposPropiedads

                    .OrderBy(p => p.nombre)
                    .Select(p => new modelCombo
                    {
                        Valor = p.id_tipo_propiedad.ToString(),
                        Texto = p.nombre
                    }).ToList();
        }

    }
}