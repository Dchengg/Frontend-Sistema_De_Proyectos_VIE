using AutoMapper;
using System.Web.Mvc;
using UIProcess.Interfaces;
using UIProcess.Modelos;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Configuracion
{
    /// <summary>
    /// Convierte los datos de clases con la interfaz ISelectListItem a objetos de tipo
    /// SelectListItem para formar los catálogos de la vista.
    /// </summary>
    public class CatalogoItemConverter : ITypeConverter<ISelectListItem, SelectListItem>
    {
        public SelectListItem Convert(ISelectListItem source, SelectListItem destination, ResolutionContext context)
        {
            return source.ToSelectListItem();
        }
    }

    public class PerfilCatalogos : Profile
    {
        public PerfilCatalogos()
        {
            CreateMap<ISelectListItem, SelectListItem>()
                .ConvertUsing<CatalogoItemConverter>();
            CreateMap<UipCatalogosInvestigador, CatalogosSingleton>();
        }
    }
}