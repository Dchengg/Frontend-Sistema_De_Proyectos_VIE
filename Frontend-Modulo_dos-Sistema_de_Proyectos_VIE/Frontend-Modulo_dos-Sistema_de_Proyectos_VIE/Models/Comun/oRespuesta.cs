using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BackendFase1.Objetos.Clases
{
 
    public class oRespuesta<TipoGenerico>
    {
       
        public int CodigoRespuesta { get; set; }
    
        public string MensajeRespuesta { get; set; }

       
        public TipoGenerico ObjetoRespuesta { get; set; }


        public bool Estado { get; set; }
    }
}
