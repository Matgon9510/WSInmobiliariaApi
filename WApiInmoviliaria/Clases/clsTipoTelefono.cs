using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WApiInmoviliaria.Models;

namespace WApiInmoviliaria.Clases
{
    public class clsTipoTelefono
    {
        DBInmobiliariaEntities dbsuper = new DBInmobiliariaEntities();
        public List<modelCombo> LlenarCombo()
        {
            return dbsuper.Tipo_Tel

                    .OrderBy(p => p.descripcion)
                    .Select(p => new modelCombo
                    {
                        Valor = p.id_tipo_tel.ToString(),
                        Texto = p.descripcion
                    }).ToList();
        }
    }
}
