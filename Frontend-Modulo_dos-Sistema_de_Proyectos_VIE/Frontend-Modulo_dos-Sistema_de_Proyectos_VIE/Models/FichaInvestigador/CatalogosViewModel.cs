using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UIProcess.Modelos;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador
{
    public class CatalogosViewModel
    {
        public IEnumerable<SelectListItem> CatalogoTipoIdentificacion { get; set; }
        public IEnumerable<SelectListItem> CatalogoPais { get; set; }
        public IEnumerable<SelectListItem> CatalogoSituacionLaboral { get; set; }
        public IEnumerable<SelectListItem> CatalogoInstitucion { get; set; }
        public IEnumerable<SelectListItem> CatalogoTituloAcademico { get; set; }    
        public IEnumerable<SelectListItem> CatalogoIdioma { get; set; }     
        public IEnumerable<SelectListItem> CatalogoNivelIdioma { get; set; }      
        public IEnumerable<SelectListItem> CatalogoUnidadAcademica { get; set; }    
        public IEnumerable<SelectListItem> CatalogoTipoPerfil { get; set; }     
        public IEnumerable<SelectListItem> CatalogoDisciplinaCientifica { get; set; }     
        public IEnumerable<SelectListItem> CatalogoSubdisciplinaCientifica { get; set; }      
        public IEnumerable<SelectListItem> CatalogoEntidad { get; set; }    
        public IEnumerable<SelectListItem> CatalogoRevista { get; set; }   
        public IEnumerable<SelectListItem> CatalogoIndiceRevista { get; set; }      
        public IEnumerable<SelectListItem> CatalogoEditorial { get; set; }     
        public IEnumerable<SelectListItem> CatalogoParticipacionLibro { get; set; }
        public IEnumerable<SelectListItem> CatalogoSexo { get; set; }
        public IEnumerable<SelectListItem> CatalogoTipoTelefono { get; set; }
        public IEnumerable<SelectListItem> CatalogoPorcentajeNombramiento { get; set; }

    }
}