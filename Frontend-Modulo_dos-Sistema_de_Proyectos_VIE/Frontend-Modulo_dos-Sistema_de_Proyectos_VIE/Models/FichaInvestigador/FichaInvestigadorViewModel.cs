using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class FichaInvestigadorViewModel
    {

        [Required]
        [Display(Name = "Fotografía")]
        public byte[] Fotografia { get; set; }  // Ok

        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; } // Ok

        [Required]
        [Display(Name = "Primer apellido")]
        public string PrimerApellido { get; set; } // Ok

        [Display(Name = "Segundo apellido")]
        public string SegundoApellido { get; set; } // Ok

        [Required]
        [Display(Name = "Fecha de nacimiento")]
        public System.DateTime FechaNacimiento { get; set; } // Ok

        public TipoIdentificacionViewModel TipoIdentificacion { get; set; } // Ok?

        public PaisViewModel PaisNacimiento { get; set; } // Ok?

        public IEnumerable<SelectListItem> CatalogoPais { get; set; }

        public NacionalidadViewModel Nacionalidad { get; set; } // Ok?

        public SexoViewModel Sexo { get; set; } // 

        [Required]
        [Display(Name = "Apartado postal")]
        public string ApartadoPostal { get; set; }

        [Required]
        [Display(Name = "Numero de identidad")]
        public string NumeroIdentidad { get; set; } // Ok

        [Required]
        [Display(Name = "Seudónimo bilbiográfico")]
        public string Seudonimo { get; set; }

        public List<CategoriaAcademicaViewModel> CategoriasAcademicas { get; set; }

        public List<UnidadAcademicaViewModel> UnidadesAcademicas { get; set; }

        [Required]
        [Display(Name = "Fecha de ingreso a la institución")]
        public DateTime FechaDeIngresoInstitucion { get; set; }

        public SituacionLaboralViewModel SituacionLaboral { get; set; }

        public List<TelefonoViewModel> Telefonos { get; set; }

        public IEnumerable<SelectListItem> CatalogoTipoTelefono { get; set; }

        public List<CorreoViewModel> Correos { get; set; }

        public PorcentajeNombramientoViewModel PorcentajeNombramiento { get; set; }

        public List<PerfilAcademicoViewModel> PerfilesAcademicos { get; set; }

        public List<EstudioRealizadoViewModel> EstudiosRealizados { get; set; }

        public IEnumerable<SelectListItem> CatalogoInstitucion { get; set; }

        public List<IdiomaViewModel> Idiomas { get; set; }

        public IEnumerable<SelectListItem> CatalogoIdioma { get; set; }

        public IEnumerable<SelectListItem> CatalogoNivelIdioma { get; set; }

        public List<ExperienciaAcademicaViewModel> ExperienciasAcademicas { get; set; }

        public List<ParticipacionViewModel> Participaciones { get; set; }

        public List<PremioViewModel> Premios { get; set; }

        public IEnumerable<SelectListItem> CatalogoEntidad { get; set; }

        public List<ArticuloViewModel> Articulos { get; set; }

        public List<PatenteViewModel> Patentes { get; set; }

        public List<LibroViewModel> Libros { get; set; }

        public List<LicenciamientoViewModel> Licenciamientos { get; set; }

        public List<SoftwareViewModel> Software { get; set; }

        public List<PonenciaViewModel> Ponencias { get; set; }

        [Required]
        [Display(Name = "Acepta las condiciones de uso sobre sus datos personales?")]
        public bool DatosPersonales { get; set; }

    }
}