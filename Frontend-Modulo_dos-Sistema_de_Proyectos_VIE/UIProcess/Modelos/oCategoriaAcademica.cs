using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace UIProcess.Modelos
{
    [DataContract]
    [Serializable]
    public class oCategoriaAcademica
    {
        [DataMember]
        public int idCategoriaAcademica { get; set; }
        [DataMember]
        public string categoriaAcademica { get; set; }
    }
}