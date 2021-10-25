using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace UIProcess.Utilitarios
{
    public static class GeneradorCatalogos
    {
        private static (int, string)[] sexos = new (int, string)[]
        {
          (0, "Masculino"),
          (1, "Femenino"),
          (2, "Prefiero no decir")
        };

        private static List<SelectListItem> generarCatalogo((int,string)[] arreglo)
        {
            var lista = new List<SelectListItem>();
            foreach (var item in arreglo)
            {
                lista.Add(new SelectListItem()
                {
                    Value = item.Item1.ToString(),
                    Text = item.Item2
                });
            }
            return lista;
        }

        public static List<SelectListItem> generarCatalogoSexo()
        {
            return generarCatalogo(sexos);
        }

        public static List<SelectListItem> generarCatalogoPorcentajeNombramiento()
        {
            var arreglo = new (int, string)[100];
            for (int i = 1; i <= 100; i++)
            {
                arreglo[i-1] = ( i, i.ToString());
            }
            return generarCatalogo(arreglo);
        }
    }
}
