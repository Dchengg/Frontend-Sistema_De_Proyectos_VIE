using System.Collections.Generic;
using System.Web.Mvc;
using UIProcess.Interfaces;

namespace UIProcess.Modelos
{
    public class UipCatalogoSexo : ISelectListItem
    {
        public string Sexo { get; set; }
        public SelectListItem ToSelectListItem()
        {
            return new SelectListItem()
            {
                Value = Sexo,
                Text = Sexo
            };
        }
    }
}