using System;
using System.Runtime.Serialization;
using System.Web.Mvc;
using UIProcess.Interfaces;

namespace UIProcess.Modelos
{
    [DataContract]
    [Serializable]
    public class UipCatalogoTituloAcademico : ISelectListItem
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string TituloAcademico { get; set; }

        public SelectListItem ToSelectListItem()
        {
            return new SelectListItem()
            {
                Value = Id.ToString(),
                Text = TituloAcademico
            };
        }
    }
}