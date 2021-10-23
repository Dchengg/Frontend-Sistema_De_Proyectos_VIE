using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace UIProcess.Modelos
{
    // Basado en implementación encontrada en https://es.wikipedia.org/wiki/Singleton#C#
    public class CatalogosSingleton
    {
        // Atributos
        public List<SelectListItem> CatalogoTipoIdentificacion { get; set; }

        public List<SelectListItem> CatalogoPais { get; set; }

        public List<SelectListItem> CatalogoSexo { get; set; }

        public List<SelectListItem> CatalogoSituacionLaboral { get; set; }

        public List<SelectListItem> CatalogoInstitucion { get; set; }

        public List<SelectListItem> CatalogoTituloAcademico { get; set; }

        public List<SelectListItem> CatalogoIdioma { get; set; }

        public List<SelectListItem> CatalogoNivelIdioma { get; set; }

        public List<SelectListItem> CatalogoUnidadAcademica { get; set; }

        public List<SelectListItem> CatalogoTipoPerfil { get; set; }

        public List<SelectListItem> CatalogoDisciplinaCientifica { get; set; }

        public List<SelectListItem> CatalogoSubdisciplinaCientifica { get; set; }

        public List<SelectListItem> CatalogoEntidad { get; set; }

        public List<SelectListItem> CatalogoRevista { get; set; }

        public List<SelectListItem> CatalogoIndiceRevista { get; set; }

        public List<SelectListItem> CatalogoEditorial { get; set; }

        public List<SelectListItem> CatalogoParticipacionLibro { get; set; }

        public List<SelectListItem> CatalogoCategoriaAcademica { get; set; }

        public List<SelectListItem> CatalogoPorentajeNombramiento { get; set; }

        public List<SelectListItem> CatalogoTipoTelefono { get; set; }

        // Variable estática para la instancia, se necesita utilizar una función lambda ya que el constructor es privado
        private static readonly Lazy<CatalogosSingleton> instance = new Lazy<CatalogosSingleton>(() => new CatalogosSingleton());

        // Constructor privado para evitar la instanciación directa
        private CatalogosSingleton()
        {
        }

        // Propiedad para acceder a la instancia
        public static CatalogosSingleton Instancia
        {
            get
            {
                return instance.Value;
            }
        }
    }
}
