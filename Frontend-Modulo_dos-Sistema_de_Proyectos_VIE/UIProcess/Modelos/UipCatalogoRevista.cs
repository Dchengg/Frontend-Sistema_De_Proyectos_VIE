using System;
using System.Runtime.Serialization;
using System.Web.Mvc;
using UIProcess.Interfaces;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipCatalogoRevista : ISelectListItem
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string NombreRevista { get; set; }
        public SelectListItem ToSelectListItem()
        {
            return new SelectListItem()
            {
                Value = Id.ToString(),
                Text = NombreRevista
            };
        }
    }
}