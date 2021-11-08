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
    public class UipTipoIdentificacion
    {
        [DataMember]
        public int IdTipoIdentificacion { get; set; }
        [DataMember]
        public string TipoIdentificacion { get; set; }
    }
}
