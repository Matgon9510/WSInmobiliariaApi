using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WApiInmoviliaria.Models;


namespace WApiInmoviliaria.Clases
{
    public class clsGenero
    {
        DBInmobiliariaEntities dbsuper = new DBInmobiliariaEntities();
        public List<modelCombo> LlenarCombo()
        {
            return dbsuper.Generoes

                    .OrderBy(p => p.descripcion)
                    .Select(p => new modelCombo
                    {
                        Valor = p.genero1.ToString(),
                        Texto = p.descripcion
                    }).ToList();
        }
    }
}