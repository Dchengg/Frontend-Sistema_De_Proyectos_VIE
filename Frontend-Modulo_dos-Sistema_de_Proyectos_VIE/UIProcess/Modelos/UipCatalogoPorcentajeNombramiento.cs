using System.Web.Mvc;
using UIProcess.Interfaces;

namespace UIProcess.Modelos
{
    public class UipCatalogoPorcentajeNombramiento : ISelectListItem
    {
        public int PorcentajeNombramiento { get; set; }

        public SelectListItem ToSelectListItem()
        {
            return new SelectListItem()
            {
                Value = PorcentajeNombramiento.ToString(),
                Text = PorcentajeNombramiento.ToString()
            };
        }
    }
}