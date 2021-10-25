using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using UIProcess.Configuracion;
using UIProcess.Consultas;

namespace UIProcess.Modelos
{
    // Basado en implementación encontrada en https://es.wikipedia.org/wiki/Singleton#C#
    public class CatalogosSingleton
    {
        // Atributos
        public IEnumerable<SelectListItem> CatalogoTipoIdentificacion { get; set; }

        public IEnumerable<SelectListItem> CatalogoPais { get; set; }

        public IEnumerable<SelectListItem> CatalogoSexo { get; set; }

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

        public IEnumerable<SelectListItem> CatalogoCategoriaAcademica { get; set; }

        public IEnumerable<SelectListItem> CatalogoPorcentajeNombramiento { get; set; }

        public IEnumerable<SelectListItem> CatalogoTipoTelefono { get; set; }

        // Variable estática para la instancia, se necesita utilizar una función lambda ya que el constructor es privado
        private static readonly Lazy<CatalogosSingleton> instance = new Lazy<CatalogosSingleton>(() =>
        {
            var respuesta = Consultor.ConsultarCatalogos();
            if (respuesta.estaSinErrores())
            {
                var config = new MapperConfiguration(cfg => cfg.AddProfile<PerfilCatalogos>());
                //.config.AssertConfigurationIsValid();
                var mapper = config.CreateMapper();
                return mapper.Map<CatalogosSingleton>(respuesta.ObjetoRespuesta);
            }
            else
            {
                return new CatalogosSingleton();
            }
        }
        );

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
