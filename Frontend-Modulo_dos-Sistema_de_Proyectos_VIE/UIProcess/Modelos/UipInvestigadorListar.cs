using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipInvestigadorListar
    {
        [DataMember]
        public string NumeroIdentidad { get; set; }
        [DataMember]
        public string TipoIdentificacion { get; set; }
        [DataMember]
        public string NombreApellido { get; set; }
    }
}
