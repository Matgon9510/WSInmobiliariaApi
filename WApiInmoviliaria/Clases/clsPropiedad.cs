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

        public Propiedade Consultar(int idPropiedad)
        {
            return dbsuper.Propiedades.FirstOrDefault(p => p.id_propiedad == idPropiedad);
        }
    }
}