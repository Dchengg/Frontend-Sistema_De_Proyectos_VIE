using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace UIProcess.Modelos
{
    [DataContract]
    [Serializable]
    public class oTipoIdentificacion
    {
        [DataMember]
        public int idTipoID { get; set; }
        [DataMember]
        public string tipoIdentificacion { get; set; }
    }
}