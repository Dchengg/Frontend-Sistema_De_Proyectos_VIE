using System.Collections.Generic;
using System.Web.Mvc;

namespace UIProcess.Modelos
{
    public class UipCatalogoSexo
    {
        public string Sexo { get; set; }
        public IEnumerable<SelectListItem> Sexos { get; set; }
    }
}