using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class oInvestigador
    {
        
        public string identificacion { get; set; }
       
        public string CadenaBase64Foto { get; set; }
    
        public string nombre { get; set; }
        
        public string apellido1 { get; set; }
        
        public string apellido2 { get; set; }
        
        public System.DateTime nacimiento { get; set; }
        
        public string loginInvestigador { get; set; }
        
        public string direccion { get; set; }
        
        public string paisNacimiento { get; set; }
        
        public string Nacionalidad { get; set; }
        
        public string apartadoPostal { get; set; }
        
        public string seudonimoBibliografico { get; set; }
        
        public string categoriaAcademica { get; set; }
        
        public System.DateTime fechaIngreso { get; set; }
        
        public string tipo { get; set; }
        
        public int porcentajeNombramiento { get; set; }
        
        public int consentimiento { get; set; }
    }
}