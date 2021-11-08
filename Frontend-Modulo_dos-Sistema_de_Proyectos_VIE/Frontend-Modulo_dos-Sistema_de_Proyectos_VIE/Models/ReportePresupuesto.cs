using Newtonsoft.Json;
using System;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class ReportePresupuesto : ResultadoReporte
    {
        [JsonProperty("PresupuestoTotal")]
        public String PresupuestoTotal { get; set; }

    }
}