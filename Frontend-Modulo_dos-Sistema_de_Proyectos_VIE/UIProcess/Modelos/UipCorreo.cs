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
    public class UipCorreo
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string IdInvestigador { get; set; }
        [DataMember]
        public string Correo { get; set; }
    }
}
