using System;
using System.Runtime.Serialization;
using System.Web.Mvc;
using UIProcess.Interfaces;

namespace UIProcess.Modelos
{
    [DataContract]
    [Serializable]
    public class UipCatalogoNivelIdioma : ISelectListItem
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string NivelIdioma { get; set; }
        public SelectListItem ToSelectListItem()
        {
            return new SelectListItem()
            {
                Value = Id.ToString(),
                Text = NivelIdioma
            };
        }

    }
}