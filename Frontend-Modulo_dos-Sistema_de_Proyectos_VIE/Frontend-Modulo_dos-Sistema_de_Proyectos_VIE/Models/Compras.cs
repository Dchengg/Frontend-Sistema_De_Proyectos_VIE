using Newtonsoft.Json;
using System;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models
{
    public class Compras
    {
        #region Variables y Constantes
        [JsonProperty("Id")]
        public String Id { get; set; }
        [JsonProperty("NombreProducto")]
        public String NombreProducto { get; set; }
        [JsonProperty("Cantidad")]
        public String Cantidad { get; set; }
        [JsonProperty("PrecioTotal")]
        public String PrecioTotal { get; set; }

        #endregion
    }
}