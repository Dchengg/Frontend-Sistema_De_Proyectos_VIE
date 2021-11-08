using System.ComponentModel.DataAnnotations;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class LicenciamientoViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Producto licenciado")]
        public string Producto { get; set; }

        [Required]
        [Display(Name = "Licenciado(a)")]
        public string LicenciadoA { get; set; }

        [Required]
        [Display(Name = "Año")]
        public int Ano { get; set; }

    }
}