using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Web.Mvc;
using UIProcess.Interfaces;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipCatalogoTipoIdentificacion : ISelectListItem
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string TipoIdentificacion { get; set; }

        public SelectListItem ToSelectListItem()
        {
            return new SelectListItem() { Value = Id.ToString(), Text = TipoIdentificacion};
        }
    }
}