using System;
using System.Runtime.Serialization;
using System.Web.Mvc;
using UIProcess.Interfaces;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipCatalogoSubdisciplinaCientifica : ISelectListItem
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string DisciplinaCientifica { get; set; }
        [DataMember]
        public string Subdisciplina { get; set; }

        public SelectListItem ToSelectListItem()
        {
            return new SelectListItem()
            {
                Value = Id.ToString(),
                Text = Subdisciplina
            };
        }
    }
}