using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WApiInmoviliaria.Models;

namespace WApiInmoviliaria.Clases
{
    public class clsComision
    {
        DBInmobiliariaEntities dbsuper = new DBInmobiliariaEntities();
        public List<modelCombo> LlenarCombo()
        {
            return dbsuper.Comisions

                    .OrderBy(p => p.descricion)
                    .Select(p => new modelCombo
                    {
                        Valor = p.id_comision.ToString(),
                        Texto = p.descricion
                    }).ToList();
        }
    }
}
