using AutoMapper;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador;
using System.Collections.Generic;
using System.Web.Mvc;
using UIProcess.Modelos;

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
            // Tipo identificacion
            CreateMap<UipTipoIdentificacion, TipoIdentificacionViewModel>()
                .ForMember(dest => dest.CatalogoTipoIdentificacion, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoTipoIdentificacion));
            //CreateMap<CatalogosSingleton, TipoIdentificacionViewModel>();


            // Pais Nacimiento
            CreateMap<UipPaisNacimiento, PaisViewModel>()
                .ForMember(dest => dest.CatalogoPais, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoPais));
            //CreateMap<CatalogosSingleton, PaisViewModel>();


            // Nacionalidad
            CreateMap<UipNacionalidad, NacionalidadViewModel>()
                .ForMember(dest => dest.CatalogoPais, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoPais));
            //CreateMap<CatalogosSingleton, NacionalidadViewModel>();

            // Sexo
            CreateMap<UipInvestigadorConsultar, SexoViewModel>()
                .ForMember(dest => dest.Sexo, act => act.MapFrom(src => src.Sexo))
                .ForMember(dest => dest.CatalogoSexo, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoSexo));
            // CreateMap<CatalogosSingleton, SexoViewModel>();

            // Categorias académicas
            CreateMap<UipCategoriaAcademica, CategoriaAcademicaViewModel>()
                .ForMember(dest => dest.CatalogoCategoriaAcademica, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoCategoriaAcademica));
            //CreateMap<CatalogosSingleton, CategoriaAcademicaViewModel>();

            // Unidades académicas
            CreateMap<UipUnidadAcademica, UnidadAcademicaViewModel>()
                .ForMember(dest => dest.CatalogoUnidadAcademica, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoUnidadAcademica));
            //CreateMap<CatalogosSingleton, UnidadAcademicaViewModel>();

            // Situación laboral
            CreateMap<UipSituacionLaboral, SituacionLaboralViewModel>()
                .ForMember(dest => dest.CatalogoSituacionLaboral, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoSituacionLaboral));
            //CreateMap<CatalogosSingleton, SituacionLaboralViewModel>();

            // Telefono
            CreateMap<UipTelefono, TelefonoViewModel>()
                .ForMember(dest => dest.CatalogoTipoTelefono, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoTipoTelefono));
            //CreateMap<CatalogosSingleton, TelefonoViewModel>();

            // Correos
            CreateMap<UipCorreo, CorreoViewModel>();

            // Porcentaje Nombramiento
            CreateMap<UipInvestigadorConsultar, PorcentajeNombramientoViewModel>()
                .ForMember(dest => dest.PorcentajeNombramiento, act => act.MapFrom(src => src.PorcentajeNombramiento))
                .ForMember(dest => dest.CatalogoPorcentajeNombramiento, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoPorcentajeNombramiento));
            //CreateMap<CatalogosSingleton, PorcentajeNombramientoViewModel>();

            // Perfiles academicos
            CreateMap<UipPerfilAcademico, PerfilAcademicoViewModel>()
                .ForMember(dest => dest.CatalogoTipoPerfil, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoTipoPerfil));
            //CreateMap<CatalogosSingleton, PerfilAcademicoViewModel>();

            // Estudios realizados
            CreateMap<UipEstudioRealizado, EstudioRealizadoViewModel>()
                .ForMember(dest => dest.CatalogoTituloAcademico, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoTituloAcademico))
                .ForMember(dest => dest.CatalogoInstitucion, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoInstitucion))
                .ForMember(dest => dest.CatalogoPais, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoPais));
            //CreateMap<CatalogosSingleton, EstudioRealizadoViewModel>();

            // Idiomas
            CreateMap<UipIdioma, IdiomaViewModel>()
                .ForMember(dest => dest.CatalogoIdiomas, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoIdioma))
                .ForMember(dest => dest.CatalogoNivelEscritura, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoNivelIdioma))
                .ForMember(dest => dest.CatalogoNivelHabla, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoNivelIdioma))
                .ForMember(dest => dest.CatalogoNivelLectura, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoNivelIdioma));
            //CreateMap<CatalogosSingleton, IdiomaViewModel>();

            // Experiencias academicas
            CreateMap<UipExperienciaAcademica, ExperienciaAcademicaViewModel>();

            // Participaciones
            CreateMap<UipParticipacion, ParticipacionViewModel>();

            // Premios
            CreateMap<UipPremio, PremioViewModel>()
                .ForMember(dest => dest.CatalogoEntidad, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoEntidad))
                .ForMember(dest => dest.CatalogoPais, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoPais));
            //CreateMap<CatalogosSingleton, PremioViewModel>();

            // Articulos
            CreateMap<UipArticulo, ArticuloViewModel>()
                .ForMember(dest => dest.CatalogoRevista, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoRevista))
                .ForMember(dest => dest.CatalogoIndiceRevista, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoIndiceRevista));
            //CreateMap<CatalogosSingleton, ArticuloViewModel>();

            // Patentes
            CreateMap<UipPatente, PatenteViewModel>();

            // Lbros
            CreateMap<UipLibro, LibroViewModel>()
                .ForMember(dest => dest.CatalogoEditorial, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoEditorial))
                .ForMember(dest => dest.CatalogoParticipacionLibro, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoParticipacionLibro));
            //CreateMap<CatalogosSingleton, LibroViewModel>();

            // Licenciamientos
            CreateMap<UipLicenciamiento, LicenciamientoViewModel>();

            // Software
            CreateMap<UipSoftware, SoftwareViewModel>();

            // Ponencias
            CreateMap<UipPonencia, PonenciaViewModel>()
                .ForMember(dest => dest.CatalogoPais, act => act.MapFrom(src => CatalogosSingleton.Instancia.CatalogoPais));
            //CreateMap<CatalogosSingleton, PonenciaViewModel>();

            // General
            CreateMap<UipInvestigadorConsultar, FichaInvestigadorViewModel>()
                .ForMember(dest => dest.Sexo, act => act.MapFrom(src => new SexoViewModel()
                {
                    Sexo = src.Sexo,
                    CatalogoSexo = CatalogosSingleton.Instancia.CatalogoSexo
                }))
                .ForMember(dest => dest.PorcentajeNombramiento, act => act.MapFrom(src => new PorcentajeNombramientoViewModel()
                {
                    PorcentajeNombramiento = src.PorcentajeNombramiento,
                    CatalogoPorcentajeNombramiento = CatalogosSingleton.Instancia.CatalogoPorcentajeNombramiento
                }));
            CreateMap<CatalogosSingleton, FichaInvestigadorViewModel>();

        }
    }
}
