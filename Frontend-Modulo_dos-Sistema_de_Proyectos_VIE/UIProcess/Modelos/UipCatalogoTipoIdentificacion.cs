using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Web.Mvc;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipCatalogoTipoIdentificacion
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string DisciplinaCientifica { get; set; }
        [DataMember]
        public string Subdisciplina { get; set; }
        public IEnumerable<SelectListItem> Tipos
        {
            get;
            set;
        }
    }
}