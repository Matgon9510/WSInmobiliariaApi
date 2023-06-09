using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WApiInmoviliaria.Models;

namespace WApiInmoviliaria.Clases
{
    public class clsDepartamento
    {
        DBInmobiliariaEntities dbsuper = new DBInmobiliariaEntities();
        public List<modelCombo> LlenarCombo()
        {
            return dbsuper.Departamentoes

                    .OrderBy(p => p.descripcion)
                    .Select(p => new modelCombo
                    {
                        Valor = p.id_departamento.ToString(),
                        Texto = p.descripcion
                    }).ToList();
        }
    }
}