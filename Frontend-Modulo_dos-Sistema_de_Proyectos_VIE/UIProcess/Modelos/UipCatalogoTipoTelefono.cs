using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using UIProcess.Interfaces;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipCatalogoTipoTelefono : ISelectListItem
    {
        [DataMember]
        public int IdTipoTelefono { get; set; }
        [DataMember]
        public string Tipo { get; set; }

        public SelectListItem ToSelectListItem()
        {
            return new SelectListItem()
            {
                Value = IdTipoTelefono.ToString(),
                Text = Tipo
            };
        }
    }
}
