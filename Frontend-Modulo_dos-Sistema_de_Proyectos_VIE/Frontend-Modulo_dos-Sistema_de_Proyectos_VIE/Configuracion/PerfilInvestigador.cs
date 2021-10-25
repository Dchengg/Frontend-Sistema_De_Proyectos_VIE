using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using UIProcess.Modelos;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador;
using System.Web.Mvc;
using UIProcess.Interfaces;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Configuracion
{
    public class TipoIdentificacionResolver : IValueResolver<UipCatalogosInvestigador,
                                                     TipoIdentificacionViewModel,
                                                     IEnumerable<SelectListItem>>
    {
        public IEnumerable<SelectListItem> Resolve(UipCatalogosInvestigador source,
                                                   TipoIdentificacionViewModel destination,
                                                   IEnumerable<SelectListItem> member,
                                                   ResolutionContext context)
        {
            var nuevaLista = new List<SelectListItem>();
            source.CatalogoTipoIdentificacion.ForEach(ti => nuevaLista.Add(ti.ToSelectListItem()));
            return nuevaLista;
        }
    }

    public class PaisNacimientoResolver : IValueResolver<UipCatalogosInvestigador,
                                                     PaisViewModel,
                                                     IEnumerable<SelectListItem>>
    {
        public IEnumerable<SelectListItem> Resolve(UipCatalogosInvestigador source,
                                                   PaisViewModel destination,
                                                   IEnumerable<SelectListItem> member,
                                                   ResolutionContext context)
        {
            var nuevaLista = new List<SelectListItem>();
            source.CatalogoPais.ForEach(ti => nuevaLista.Add(ti.ToSelectListItem()));
            return nuevaLista;
        }
    }
    

    public class NacionalidadResolver : IValueResolver<UipCatalogosInvestigador,
                                                     NacionalidadViewModel,
                                                     IEnumerable<SelectListItem>>
    {
        public IEnumerable<SelectListItem> Resolve(UipCatalogosInvestigador source,
                                                   NacionalidadViewModel destination,
                                                   IEnumerable<SelectListItem> member,
                                                   ResolutionContext context)
        {
            var nuevaLista = new List<SelectListItem>();
            source.CatalogoPais.ForEach(ti => nuevaLista.Add(ti.ToSelectListItem()));
            return nuevaLista;
        }
    }

    public class CategoriaAcademicaResolver : IValueResolver<UipCatalogosInvestigador,
                                                     CategoriaAcademicaViewModel,
                                                     IEnumerable<SelectListItem>>
    {
        public IEnumerable<SelectListItem> Resolve(UipCatalogosInvestigador source,
                                                   CategoriaAcademicaViewModel destination,
                                                   IEnumerable<SelectListItem> member,
                                                   ResolutionContext context)
        {
            var nuevaLista = new List<SelectListItem>();
            source.CatalogoCategoriaAcademica.ForEach(ti => nuevaLista.Add(ti.ToSelectListItem()));
            return nuevaLista;
        }
    }

    public class UnidadAcademicaResolver : IValueResolver<UipCatalogosInvestigador,
                                                     UnidadAcademicaViewModel,
                                                     IEnumerable<SelectListItem>>
    {
        public IEnumerable<SelectListItem> Resolve(UipCatalogosInvestigador source,
                                                   UnidadAcademicaViewModel destination,
                                                   IEnumerable<SelectListItem> member,
                                                   ResolutionContext context)
        {
            var nuevaLista = new List<SelectListItem>();
            source.CatalogoUnidadAcademica.ForEach(ti => nuevaLista.Add(ti.ToSelectListItem()));
            return nuevaLista;
        }
    }

    public class SituacionLaboralResolver : IValueResolver<UipCatalogosInvestigador,
                                                     SituacionLaboralViewModel,
                                                     IEnumerable<SelectListItem>>
    {
        public IEnumerable<SelectListItem> Resolve(UipCatalogosInvestigador source,
                                                   SituacionLaboralViewModel destination,
                                                   IEnumerable<SelectListItem> member,
                                                   ResolutionContext context)
        {
            var nuevaLista = new List<SelectListItem>();
            source.CatalogoSituacionLaboral.ForEach(ti => nuevaLista.Add(ti.ToSelectListItem()));
            return nuevaLista;
        }
    }

    public class TelefonoResolver : IValueResolver<UipCatalogosInvestigador,
                                                     TelefonoViewModel,
                                                     IEnumerable<SelectListItem>>
    {
        public IEnumerable<SelectListItem> Resolve(UipCatalogosInvestigador source,
                                                   TelefonoViewModel destination,
                                                   IEnumerable<SelectListItem> member,
                                                   ResolutionContext context)
        {
            var nuevaLista = new List<SelectListItem>();
            source.CatalogoTipoTelefono.ForEach(ti => nuevaLista.Add(ti.ToSelectListItem()));
            return nuevaLista;
        }
    }

    

    public class PerfilInvestigador : Profile
    {

        public PerfilInvestigador()
        {

            // General
            
            CreateMap<FichaInvestigadorDTO, FichaInvestigadorViewModel>();
            CreateMap<UipInvestigadorConsultar, FichaInvestigadorViewModel>();
            CreateMap<CatalogosSingleton, FichaInvestigadorViewModel>();

            // Tipo identificacion
            CreateMap<UipTipoIdentificacion, TipoIdentificacionViewModel>();
            CreateMap<CatalogosSingleton, TipoIdentificacionViewModel>()
                .ForMember(dest => dest.CatalogoTipoIdentificacion, act => act.MapFrom(src => src.CatalogoTipoIdentificacion));

            // Pais Nacimiento
            CreateMap<UipPaisNacimiento, PaisViewModel>();
            CreateMap<CatalogosSingleton, PaisViewModel>()
                .ForMember(dest => dest.CatalogoPais, act => act.MapFrom(src => src.CatalogoPais));


            // Nacionalidad
            CreateMap<UipNacionalidad, NacionalidadViewModel>();
            CreateMap<CatalogosSingleton, NacionalidadViewModel>();

            // Sexo
            CreateMap<UipInvestigadorConsultar, SexoViewModel>();
            CreateMap<CatalogosSingleton, SexoViewModel>();

            // Categorias académicas
            CreateMap<UipCategoriaAcademica, CategoriaAcademicaViewModel>();
            CreateMap<CatalogosSingleton, CategoriaAcademicaViewModel>();

            // Unidades académicas
            CreateMap<UipUnidadAcademica, UnidadAcademicaViewModel>();
            CreateMap<CatalogosSingleton, UnidadAcademicaViewModel>();

            // Situación laboral
            CreateMap<UipSituacionLaboral, SituacionLaboralViewModel>();
            CreateMap<CatalogosSingleton, SituacionLaboralViewModel>();

            // Telefono
            CreateMap<UipTelefono, TelefonoViewModel>();
            CreateMap<CatalogosSingleton, TelefonoViewModel>();

            // Correos
            CreateMap<UipCorreo, CorreoViewModel>();

            // Porcentaje Nombramiento
            CreateMap<UipInvestigadorConsultar, PorcentajeNombramientoViewModel>();
            CreateMap<CatalogosSingleton, PorcentajeNombramientoViewModel>();

            // Perfiles academicos
            CreateMap<UipPerfilAcademico, PerfilAcademicoViewModel>();
            CreateMap<CatalogosSingleton, PerfilAcademicoViewModel>();

            // Estudios realizados
            CreateMap<UipEstudioRealizado, EstudioRealizadoViewModel>();
            CreateMap<CatalogosSingleton, EstudioRealizadoViewModel>();

            // Idiomas
            CreateMap<UipIdioma, IdiomaViewModel>();
            CreateMap<CatalogosSingleton, IdiomaViewModel>();

            // Experiencias academicas
            CreateMap<UipExperienciaAcademica, ExperienciaAcademicaViewModel>();
            CreateMap<CatalogosSingleton, ExperienciaAcademicaViewModel>();

            // Participaciones
            CreateMap<UipParticipacion, ParticipacionViewModel>();
            CreateMap<CatalogosSingleton, ParticipacionViewModel>();

            // Premios
            CreateMap<UipPremio, PremioViewModel>();
            CreateMap<CatalogosSingleton, PremioViewModel>();

            // Articulos
            CreateMap<UipArticulo, ArticuloViewModel>();
            CreateMap<CatalogosSingleton, ArticuloViewModel>();

            // Patentes
            CreateMap<UipPatente, PatenteViewModel>();

            // Lbros
            CreateMap<UipLibro, LibroViewModel>();
            CreateMap<CatalogosSingleton, LibroViewModel>();

            // Licenciamientos
            CreateMap<UipLicenciamiento, LicenciamientoViewModel>();

            // Software
            CreateMap<UipSoftware, SoftwareViewModel>();

            // Ponencias
            CreateMap<UipPonencia, PonenciaViewModel>();
            CreateMap<CatalogosSingleton, PonenciaViewModel>();
        }    
    }
}
