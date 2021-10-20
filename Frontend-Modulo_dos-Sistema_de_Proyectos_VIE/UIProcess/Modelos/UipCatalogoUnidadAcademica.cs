using System;
using System.Runtime.Serialization;
using System.Web.Mvc;
using UIProcess.Interfaces;

namespace UIProcess.Modelos
{
    [DataContract]
    [Serializable]
    public class UipCatalogoUnidadAcademica : ISelectListItem
    {
        [DataMember]
        public int Id;
        [DataMember]
        public string NombreUnidadAcademica;
        public SelectListItem ToSelectListItem()
        {
            return new SelectListItem()
            {
                Value = Id.ToString(),
                Text = NombreUnidadAcademica
            };
        }
    }
}