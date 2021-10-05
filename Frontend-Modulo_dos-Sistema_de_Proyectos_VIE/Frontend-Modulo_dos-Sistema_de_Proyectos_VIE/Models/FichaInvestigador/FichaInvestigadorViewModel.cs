using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class FichaInvestigadorViewModel
    {

        [Required]
        [Display(Name = "Fotografía")]
        public byte[] Fotografia { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Primer apellido")]
        public string PrimerApellido { get; set; }

        [Display(Name = "Segundo apellido")]
        public string SegundoApellido { get; set; }

        [Required]
        [Display(Name = "Fecha de nacimiento")]
        public System.DateTime FechaNacimiento { get; set; }

        public TipoIdentificacionViewModel tipoIdentificacionViewModel { get; set; }

        public PaisViewModel paisViewModel { get; set; }

        public SexoViewModel sexoViewModel { get; set; }

        //TODO: Poner los teléfonos

        [Required]
        [Display(Name = "Apartado postal")]
        public string ApartadoPostal { get; set; }

        //TODO: Poner el correo electrónico

        [Required]
        [Display(Name = "Numero de identidad")]
        public string NumeroIdentidad { get; set; }

        [Required]
        [Display(Name = "Seudónimo bilbiográfico")]
        public string Seudonimo { get; set; }

        public CategoriaAcademicaViewModel CategoriaAcademicaViewModel { get; set; }

        public UnidadAcademicaViewModel UnidadAcademicaViewModel { get; set; }

        [Required]
        [Display(Name = "Fecha de ingreso a la institución")]
        public DateTime FechaDeIngresoInstitucion { get; set; }

        public SituacionLaboralViewModel SituacionLaboralViewModel { get; set; }

        public PorcentajeNombramientoViewModel PorcentajeNombramientoViewModel { get; set; }
        
        public List<EstudioRealizadoViewModel> EstudiosRealizados { get; set; }

        public List<IdiomaViewModel> Idiomas { get; set; }

        public List<ExperienciaAcademicaViewModel> ExperienciaAcademicas { get; set; }

        public List<ParticipacionViewModel> Participaciones { get; set; }

        public List<PremioViewModel> Premios { get; set; }

        public List<ArticuloViewModel> Articulos { get; set; }

        public List<PatenteViewModel> Patentes { get; set; }
        [DataMember]
        public List<oLibro> Libros { get; set; }
        [DataMember]
        public List<oPonencia> Ponencias { get; set; }
        [DataMember]
        public List<oSoftware> Software { get; set; }
        [DataMember]
        public List<oLicenciamiento> Licenciamientos { get; set; }
        
        [DataMember]
        public List<oSubdisciplina> SubdisciplinasCientificas { get; set; }

        [Required]
        [Display(Name = "Acepta las condiciones de uso sobre sus datos personales?")]
        public bool DatosPersonales { get; set; }

    }
}