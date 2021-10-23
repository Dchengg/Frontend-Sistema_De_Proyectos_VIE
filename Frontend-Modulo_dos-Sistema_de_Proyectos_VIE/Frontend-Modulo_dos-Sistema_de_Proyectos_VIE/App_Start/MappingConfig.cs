using AutoMapper;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Configuracion;
using Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.FichaInvestigador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UIProcess.Modelos;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE
{
    public class MappingConfig
    {
        public static void MapearCatalogos(UipCatalogosInvestigador catalogos)
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<PerfilCatalogos>());

            UipCatalogosGlobal.CatalogoTipoIdentificacion = catalogos.CatalogoTipoIdentificacion.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoPais = catalogos.CatalogoPais.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoSexo = new List<SelectListItem>()
            {
                new SelectListItem() {Value = "1", Text = "Masculino"},
                new SelectListItem() {Value = "2", Text = "Femenino"},
                new SelectListItem() {Value = "3", Text = "Prefiero no especificar"}
            };
            UipCatalogosGlobal.CatalogoCategoriaAcademica = catalogos.CatalogoCategoriaAcademica.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoSituacionLaboral = catalogos.CatalogoSituacionLaboral.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoPorentajeNombramiento = new List<SelectListItem>();
            for (int i = 1; i <= 100; i++)
            {
                UipCatalogosGlobal.CatalogoPorentajeNombramiento.Add(new SelectListItem() { Value = i.ToString(), Text = i.ToString() });
            }
            UipCatalogosGlobal.CatalogoInstitucion = catalogos.CatalogoInstitucion.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoTituloAcademico = catalogos.CatalogoTituloAcademico.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoIdioma = catalogos.CatalogoIdioma.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoNivelIdioma = catalogos.CatalogoNivelIdioma.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoUnidadAcademica = catalogos.CatalogoUnidadAcademica.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoTipoPerfil = catalogos.CatalogoTipoPerfil.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoDisciplinaCientifica = catalogos.CatalogoDisciplinaCientifica.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoEntidad = catalogos.CatalogoEntidad.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoRevista = catalogos.CatalogoRevista.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoIndiceRevista = catalogos.CatalogoIndiceRevista.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoEditorial = catalogos.CatalogoEditorial.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoParticipacionLibro = catalogos.CatalogoParticipacionLibro.Select(i => i.ToSelectListItem()).ToList();
            UipCatalogosGlobal.CatalogoTipoTelefono = catalogos.CatalogoTipoTelefono.Select(i => i.ToSelectListItem()).ToList();
        }

        public static FichaInvestigadorViewModel MapearFichaInvestigador(UipInvestigadorConsultar investigador)
        {
            // Configuracion de Automapper
            var config = new MapperConfiguration(
                             cfg =>
                             { 
                                 // Tipo identificacion
                                 cfg.CreateMap<UipTipoIdentificacion, TipoIdentificacionViewModel>();
                                 //cfg.CreateMap<UipCatalogosInvestigador, TipoIdentificacionViewModel>()
                                 //   .ForMember(dest => dest.CatalogoTipoIdentificacion, opt => opt.MapFrom<TipoIdentificacionResolver>());

                                 //// Pais Nacimiento
                                 //cfg.CreateMap<UipPaisNacimiento, PaisViewModel>();
                                 //cfg.CreateMap<UipCatalogosInvestigador, PaisViewModel>()
                                 //   .ForMember(dest => dest.CatalogoPais, opt => opt.MapFrom<PaisResolver>());
                                 //cfg.CreateMap<UipInvestigadorConsultar, FichaInvestigadorViewModel>()
                                 //   .IncludeMembers(source => source.TipoIdentificacion,
                                 //                   source => source.PaisNacimiento);
                                 //cfg.CreateMap<UipCatalogosInvestigador, FichaInvestigadorViewModel>();

                                 //// Pais
                                 //cfg.CreateMap<UipInvestigadorConsultar, PaisViewModel>()
                                 //.ForMember(d => d.PaisNacimientoSeleccionado, action => action.MapFrom(s => s.IdPaisNacimiento))
                                 //.ForMember(d => d.PaisNacimiento, action => action.MapFrom(s => s.PaisNacimiento));
                                 //cfg.CreateMap<CatalogosViewModel, PaisViewModel>();

                                 //// Nacionalidad
                                 //cfg.CreateMap<UipInvestigadorConsultar, NacionalidadViewModel>()
                                 //.ForMember(d => d.NacionalidadSeleccionada, action => action.MapFrom(s => s.IdNacionalidad))
                                 //.ForMember(d => d.Nacionalidad, action => action.MapFrom(s => s.Nacionalidad));
                                 //cfg.CreateMap<CatalogosViewModel, NacionalidadViewModel>()
                                 //.ForMember(d => d.CatalogoNacionalidad, action => action.MapFrom(s => s.CatalogoPais));

                                 //// Sexo
                                 //cfg.CreateMap<UipInvestigadorConsultar, SexoViewModel>()
                                 //.ForMember(d => d.SexoSeleccionado, action => action.MapFrom(s => s.Sexo));
                                 //cfg.CreateMap<CatalogosViewModel, SexoViewModel>();

                                 //// Categoria academica
                                 //cfg.CreateMap<UipCategoriaAcademica, CategoriaAcademicaViewModel>()
                                 //.ForMember(d => d.CategoriaAcademicaSeleccionada, action => action.MapFrom(s => s.Id))
                                 //.ForMember(d => d.CategoriaAcademica, action => action.MapFrom(s => s.NombreCategoria));
                                 //cfg.CreateMap<CatalogosViewModel, CategoriaAcademicaViewModel>();

                                 //// Unidad academica
                                 //cfg.CreateMap<UipUnidadAcademica, UnidadAcademicaViewModel>()
                                 //.ForMember(d => d.UnidadAcademicaSeleccionada, action => action.MapFrom(s => s.IdUnidadAcademica))
                                 //.ForMember(d => d.UnidadAcademica, action => action.MapFrom(s => s.NombreUnidadAcademica))
                                 //.ForMember(d => d.Sede, action => action.MapFrom(s => s.NombreSede));
                                 //cfg.CreateMap<CatalogosViewModel, UnidadAcademicaViewModel>()
                                 //.ForMember(d => d.CatalogoUnidadesAcademicas, action => action.MapFrom(s => s.CatalogoUnidadAcademica));

                                 //// Situacion laboral
                                 //cfg.CreateMap<UipInvestigadorConsultar, SituacionLaboralViewModel>()
                                 //.ForMember(d => d.SituacionLaboralSeleccionada, action => action.MapFrom(s => s.IdSituacionLaboral))
                                 //.ForMember(d => d.SituacionLaboral, action => action.MapFrom(s => s.SituacionLaboral));
                                 //cfg.CreateMap<CatalogosViewModel, SituacionLaboralViewModel>();

                                 //// Telefono
                                 //cfg.CreateMap<UipTelefono, TelefonoViewModel>()
                                 //.ForMember(d => d.TipoTelefonoSeleccionado, action => action.MapFrom(s => s.IdTipoTelefono))
                                 //.ForMember(d => d.TipoTelefono, action => action.MapFrom(s => s.Tipo))
                                 //.ForMember(d => d.Telefono, action => action.MapFrom(s => s.Numero));
                                 //cfg.CreateMap<CatalogosViewModel, TelefonoViewModel>();

                                 //// Correo
                                 //cfg.CreateMap<UipCorreo, CorreoViewModel>();

                                 //// Porcentaje de nombramiento
                                 //cfg.CreateMap<UipInvestigadorConsultar, PorcentajeNombramientoViewModel>()
                                 //.ForMember(d => d.PorcentajeNombramientoSeleccionado, action => action.MapFrom(s => s.PorcentajeNombramiento));
                                 //cfg.CreateMap<CatalogosViewModel, PorcentajeNombramientoViewModel>();

                                 //// Perfil academico
                                 //cfg.CreateMap<UipPerfilAcademico, PerfilAcademicoViewModel>()
                                 //.ForMember(d => d.TipoPerfilSeleccionado, action => action.MapFrom(s => s.TipoPerfil))
                                 //.ForMember(d => d.Direccion, action => action.MapFrom(s => s.Direccion));
                                 //cfg.CreateMap<CatalogosViewModel, PerfilAcademicoViewModel>()
                                 //.ForMember(d => d.CatalogoTiposPerfilAcademico, action => action.MapFrom(s => s.CatalogoTipoPerfil));

                                 //// Estudio realizado
                                 //cfg.CreateMap<UipEstudioRealizado, EstudioRealizadoViewModel>()
                                 //.ForMember(d => d.TituloAcademico, action => action.MapFrom(s => s.TituloAcademico))
                                 //.ForMember(d => d.Pais, action => action.MapFrom(s => s.NombrePais))
                                 //.ForMember(d => d.Institucion, action => action.MapFrom(s => s.NombreInstitucion))
                                 //.ForMember(d => d.AreaDeEstudio, action => action.MapFrom(s => s.AreaDeEstudio))
                                 //.ForMember(d => d.AnoGraduacion, action => action.MapFrom(s => s.AnoGraduacion));
                                 //cfg.CreateMap<UipCatalogoPais, EstudioRealizadoViewModel>();

                             }
            );
            return null;
        }
        
            //#region Mapeo manual del objeto de consulta al objeto de la vista
            //objetoVista.Fotografia = investigador.Fotografia;
            //objetoVista.Nombre = investigador.Nombre;
            //objetoVista.PrimerApellido = investigador.PrimerApellido;
            //objetoVista.SegundoApellido = investigador.SegundoApellido;
            //objetoVista.FechaNacimiento = investigador.FechaNacimiento;

            //// Tipo identificacion
            //var catTipoIdentificacion = UipCatalogosGlobal.CatalogoTipoIdentificacion;
            //catTipoIdentificacion.ForEach(i => i.Selected = false);
            //catTipoIdentificacion.First(i => i.Value == investigador.IdTipoIdentificacion.ToString()).Selected = true;

            //objetoVista.TipoIdentificacionViewModel = new TipoIdentificacionViewModel
            //{
            //    IdTipoIdentificacion = investigador.IdTipoIdentificacion,
            //    CatalogoTipoIdentificacion = catTipoIdentificacion
            //};

            //// Pais de nacimiento
            //var catPais = UipCatalogosGlobal.CatalogoPais;
            //catPais.ForEach(i => i.Selected = false);
            //catPais.First(i => i.Value == investigador.IdPaisNacimiento.ToString()).Selected = true;
            //objetoVista.PaisViewModel = new PaisViewModel
            //{
            //    PaisNacimientoSeleccionado = investigador.IdPaisNacimiento,
            //    CatalogoPais = catPais
            //};

            //// Nacionalidad
            //var catNacionalidad = UipCatalogosGlobal.CatalogoPais;
            //catNacionalidad.ForEach(i => i.Selected = false);
            //catNacionalidad.First(i => i.Value == investigador.IdNacionalidad.ToString()).Selected = true;

            //objetoVista.NacionalidadViewModel = new NacionalidadViewModel
            //{
            //    NacionalidadSeleccionada = investigador.IdNacionalidad,
            //    CatalogoNacionalidad = catNacionalidad
            //};

            //// Catalogo pais
            //objetoVista.CatalogoPais = UipCatalogosGlobal.CatalogoPais;

            //// Sexo
            //var catSexo = UipCatalogosGlobal.CatalogoSexo;
            //catSexo.ForEach(i => i.Selected = false);
            //catSexo.First(i => i.Text == investigador.Sexo).Selected = true;

            //objetoVista.SexoViewModel = new SexoViewModel
            //{
            //    SexoSeleccionado = investigador.Sexo,
            //    CatalogoSexo = catSexo
            //};

            //// Apartado postal
            //objetoVista.ApartadoPostal = investigador.ApartadoPostal;

            //// Numero identidad
            //objetoVista.NumeroIdentidad = investigador.NumeroIdentidad;

            //// Seudonimo
            //objetoVista.Seudonimo = investigador.Seudonimo;

            //// Categorias academicas
            //objetoVista.CategoriasAcademicas = new List<CategoriaAcademicaViewModel>();
            //foreach (var categoriaAcademica in investigador.CategoriasAcademicas)
            //{
            //    var catCategoriasAcademicas = UipCatalogosGlobal.CatalogoCategoriaAcademica;
            //    catCategoriasAcademicas.ForEach(i => i.Selected = false);
            //    catCategoriasAcademicas.First(i => i.Value == categoriaAcademica.Id.ToString()).Selected = true;

            //    objetoVista.CategoriasAcademicas.Add(new CategoriaAcademicaViewModel()
            //    {
            //        CategoriaAcademicaSeleccionada = (categoriaAcademica.Id - 1),
            //        CatalogoCategoriasAcademicas = catCategoriasAcademicas
            //    });
            //}

            //// Unidades academicas
            //objetoVista.UnidadesAcademicas = new List<UnidadAcademicaViewModel>();
            //foreach (var unidadAcademica in investigador.UnidadesAcademicas)
            //{
            //    var catUnidadesAcademicas = UipCatalogosGlobal.CatalogoUnidadAcademica;
            //    catUnidadesAcademicas.ForEach(i => i.Selected = false);
            //    catUnidadesAcademicas.First(i => i.Value == unidadAcademica.IdUnidadAcademica.ToString()).Selected = true;
            //    objetoVista.UnidadesAcademicas.Add(new UnidadAcademicaViewModel()
            //    {
            //        UnidadAcademicaSeleccionada = unidadAcademica.Id,
            //        UnidadAcademica = unidadAcademica.NombreUnidadAcademica,
            //        CatalogoUnidadesAcademicas = catUnidadesAcademicas
            //    });
            //}

            //// Fecha de ingreso a institucion
            //objetoVista.FechaDeIngresoInstitucion = investigador.FechaDeIngresoInstitucion;

            //// Situacion laboral
            //var catSituacionLaboral = UipCatalogosGlobal.CatalogoSituacionLaboral;
            //catSituacionLaboral.ForEach(i => i.Selected = false);
            //catSituacionLaboral.First(i => i.Value == investigador.IdSituacionLaboral.ToString()).Selected = true;

            //objetoVista.SituacionLaboralViewModel = new SituacionLaboralViewModel()
            //{
            //    SituacionLaboralSeleccionada = investigador.IdSituacionLaboral,
            //    CatalogoSituacionLaboral = catSituacionLaboral
            //};

            //// Telefonos
            //objetoVista.Telefonos = new List<TelefonoViewModel>();
            //foreach (var telefono in investigador.Telefonos)
            //{
            //    var catTelefonos = UipCatalogosGlobal.CatalogoTipoTelefono;
            //    catTelefonos.ForEach(i => i.Selected = false);
            //    catTelefonos.First(i => i.Value == telefono.IdTipoTelefono.ToString()).Selected = true;

            //    objetoVista.Telefonos.Add(new TelefonoViewModel()
            //    {
            //        Telefono = telefono.Numero,
            //        TipoTelefono = telefono.Tipo,
            //        CatalogoTipoTelefono = catTelefonos
            //    });
            //}

            //// Catalogo de telefonos
            //objetoVista.CatalogoTipoTelefono = UipCatalogosGlobal.CatalogoTipoTelefono;

            //// Correos
            //objetoVista.Correos = new List<CorreoViewModel>();
            //foreach (var correo in investigador.Correos)
            //{
            //    objetoVista.Correos.Add(new CorreoViewModel()
            //    {
            //        Correo = correo.Correo
            //    });
            //}

            //// Porcentaje de nombramieto
            //var catPorcetajeNombramiento = UipCatalogosGlobal.CatalogoPorentajeNombramiento;
            //catPorcetajeNombramiento.ForEach(i => i.Selected = false);
            //catPorcetajeNombramiento.First(i => i.Value == investigador.PorcentajeNombramiento.ToString()).Selected = true;
            //objetoVista.PorcentajeNombramientoViewModel = new PorcentajeNombramientoViewModel()
            //{
            //    PorcentajeNombramientoSeleccionado = investigador.PorcentajeNombramiento,
            //    CatalogoPorcentajeNombramiento = UipCatalogosGlobal.CatalogoPorentajeNombramiento
            //};

            //objetoVista.PerfilesAcademicos = new List<PerfilAcademicoViewModel>();
            //{
            //    foreach (var perfilAcademico in investigador.PerfilesAcademicos)
            //    {
            //        objetoVista.PerfilesAcademicos.Add(new PerfilAcademicoViewModel()
            //        {
            //            TipoPerfilSeleccionado = perfilAcademico.TipoPerfil,
            //            CatalogoTiposPerfilAcademico = UipCatalogosGlobal.CatalogoTipoPerfil,
            //            Direccion = perfilAcademico.Direccion
            //        });
            //    }
            //}

            //// Estudios realizados
            //objetoVista.EstudiosRealizados = new List<EstudioRealizadoViewModel>();
            //foreach (var estudioRealizado in investigador.EstudiosRealizados)
            //{

            //    objetoVista.EstudiosRealizados.Add(new EstudioRealizadoViewModel()
            //    {
            //        IdTituloAcademico = estudioRealizado.IdTituloAcademico,
            //        TituloAcademico = estudioRealizado.TituloAcademico,
            //        TitulosAcademicos = UipCatalogosGlobal.CatalogoTituloAcademico,
            //        IdInstitucion = estudioRealizado.IdInstitucion,
            //        Institucion = estudioRealizado.NombreInstitucion,
            //        Instituciones = UipCatalogosGlobal.CatalogoInstitucion,
            //        AnoGraduacion = estudioRealizado.AnoGraduacion,
            //        AreaDeEstudio = estudioRealizado.AreaDeEstudio,
            //        IdPais = estudioRealizado.IdPais,
            //        Pais = estudioRealizado.NombrePais,
            //        Paises = UipCatalogosGlobal.CatalogoPais
            //    }); ;
            //}

            //// Catalogo instituciones
            //objetoVista.CatalogoInstitucion = UipCatalogosGlobal.CatalogoInstitucion;

            //// Idiomas
            //objetoVista.Idiomas = new List<IdiomaViewModel>();
            //foreach (var idioma in investigador.Idiomas)
            //{
            //    var catIdioma = UipCatalogosGlobal.CatalogoIdioma;
            //    catIdioma.ForEach(i => i.Selected = false);
            //    catIdioma.First(i => i.Value == idioma.IdIdioma.ToString()).Selected = true;

            //    var catNivelHabla = UipCatalogosGlobal.CatalogoNivelIdioma;
            //    catNivelHabla.ForEach(i => i.Selected = false);
            //    catNivelHabla.First(i => i.Value == idioma.IdNivelHabla.ToString()).Selected = true;

            //    var catNivelEscritura = UipCatalogosGlobal.CatalogoNivelIdioma;
            //    catNivelEscritura.ForEach(i => i.Selected = false);
            //    catNivelEscritura.First(i => i.Value == idioma.IdNivelEscritura.ToString()).Selected = true;

            //    var catNivelLectura = UipCatalogosGlobal.CatalogoNivelIdioma;
            //    catNivelLectura.ForEach(i => i.Selected = false);
            //    catNivelLectura.First(i => i.Value == idioma.IdNivelLectura.ToString()).Selected = true;

            //    objetoVista.Idiomas.Add(new IdiomaViewModel()
            //    {
            //        NombreIdioma = idioma.NombreIdioma,
            //        IdIdioma = idioma.IdIdioma,
            //        CatalogoIdiomas = UipCatalogosGlobal.CatalogoIdioma,
            //        NivelHabla = idioma.NivelHabla,
            //        IdNivelHabla = idioma.IdNivelHabla,
            //        CatalogoNivelHabla = UipCatalogosGlobal.CatalogoNivelIdioma,
            //        NivelEscritura = idioma.NivelEscritura,
            //        IdNivelEscritura = idioma.IdNivelEscritura,
            //        CatalogoNivelEscritura = UipCatalogosGlobal.CatalogoNivelIdioma,
            //        NivelLectura = idioma.NivelLectura,
            //        IdNivelLectura = idioma.IdNivelLectura,
            //        CatalogoNivelLectura = UipCatalogosGlobal.CatalogoNivelIdioma,
            //        IdiomaMaterno = idioma.EsMaterno
            //    }); ;
            //}

            //// Catalogo idioma
            //objetoVista.CatalogoIdioma = UipCatalogosGlobal.CatalogoIdioma;

            //// Catalogo nivel idioma
            //objetoVista.CatalogoNivelIdioma = UipCatalogosGlobal.CatalogoNivelIdioma;

            //// Catalogo experiencias academicas
            //objetoVista.ExperienciaAcademicas = new List<ExperienciaAcademicaViewModel>();
            //foreach (var experienciaAcademica in investigador.ExperienciasAcademicas)
            //{
            //    objetoVista.ExperienciaAcademicas.Add(new ExperienciaAcademicaViewModel()
            //    {
            //        Puesto = experienciaAcademica.Puesto,
            //        AnoInicio = experienciaAcademica.AnoInicio,
            //        AnoTermino = experienciaAcademica.AnoFinalizacion,
            //        UnidadDepartametal = experienciaAcademica.UnidadDepartamental
            //    });
            //}

            //// Participaciones de proyectos, etc.
            //objetoVista.Participaciones = new List<ParticipacionViewModel>();
            //foreach (var participacion in investigador.Participaciones)
            //{
            //    objetoVista.Participaciones.Add(new ParticipacionViewModel()
            //    {
            //        Puesto = participacion.Puesto,
            //        Entidad = participacion.Entidad,
            //        AnoInicio = participacion.AnoInicio,
            //        AnoTermino = participacion.AnoFinalizacion
            //    });
            //}

            //// Premios
            //objetoVista.Premios = new List<PremioViewModel>();
            //foreach (var premio in investigador.Premios)
            //{
            //    var catEntidades = UipCatalogosGlobal.CatalogoEntidad;
            //    catEntidades.ForEach(i => i.Selected = false);
            //    catEntidades.First(i => i.Value == premio.Entidad).Selected = true;

            //    var catPaisPremio = UipCatalogosGlobal.CatalogoPais;
            //    catPaisPremio.ForEach(i => i.Selected = false);
            //    catPaisPremio.First(i => i.Value == premio.Pais).Selected = true;

            //    objetoVista.Premios.Add(new PremioViewModel()
            //    {
            //        NombrePremio = premio.NombrePremio,
            //        EntidadSeleccionada = premio.Entidad,
            //        Entidades = catEntidades,
            //        Ano = premio.Ano,
            //        PaisSeleccionado = premio.Pais,
            //        Paises = catPaisPremio
            //    });
            //}

            //// Catalogo entidades
            //objetoVista.CatalogoEntidades = UipCatalogosGlobal.CatalogoEntidad;

            //// Articulos
            //objetoVista.Articulos = new List<ArticuloViewModel>();
            //foreach (var articulo in investigador.Articulos)
            //{
            //    var catRevistas = UipCatalogosGlobal.CatalogoRevista;
            //    catRevistas.ForEach(i => i.Selected = false);
            //    catRevistas.First(i => i.Value == articulo.IdRevista.ToString()).Selected = true;

            //    var catIndiceRevista = UipCatalogosGlobal.CatalogoIndiceRevista;
            //    catIndiceRevista.ForEach(i => i.Selected = false);
            //    catIndiceRevista.First(i => i.Value == articulo.IdIndice.ToString()).Selected = true;

            //    objetoVista.Articulos.Add(new ArticuloViewModel()
            //    {
            //        TituloArticulo = articulo.TituloArticulo,
            //        IdRevista = articulo.IdRevista,
            //        NombreRevista = articulo.NombreRevista,
            //        CatalogoRevistas = catRevistas,
            //        IdIndice = articulo.IdIndice,
            //        NombreIndice = articulo.NombreIndice,
            //        CatalogoIndice = catIndiceRevista,
            //        Volumen = articulo.Volumen,
            //        Numero = articulo.Numero,
            //        Ano = articulo.Ano
            //    });
            //}

            //objetoVista.Patentes = new List<PatenteViewModel>();
            //foreach (var patente in investigador.Patentes)
            //{
            //    objetoVista.Patentes.Add(new PatenteViewModel()
            //    {
            //        NombrePatente = patente.Nombre,
            //        NumeroPatente = patente.NumPatente,
            //        LugarInscripcion = patente.Lugar,
            //        AnoInscripcion = patente.Ano
            //    });
            //}

            //objetoVista.Libros = new List<LibroViewModel>();
            //foreach (var libro in investigador.Libros)
            //{
            //    var catEditoriales = UipCatalogosGlobal.CatalogoEditorial;
            //    catEditoriales.ForEach(i => i.Selected = false);
            //    catEditoriales.First(i => i.Value == libro.IdEditorial.ToString()).Selected = true;

            //    var catTipoParticipacion = UipCatalogosGlobal.CatalogoParticipacionLibro;
            //    catTipoParticipacion.ForEach(i => i.Selected = false);
            //    catTipoParticipacion.First(i => i.Value == libro.IdTipoParticipacion.ToString()).Selected = true;

            //    objetoVista.Libros.Add(new LibroViewModel()
            //    {
            //        Titulo = libro.Titulo,
            //        EditorialSeleccionada = libro.NombreEditorial,
            //        Editoriales = catEditoriales,
            //        TipoParticipacionSeleccionada = libro.TipoParticipacion,
            //        TiposParticipacion = catTipoParticipacion,
            //        Ano = libro.Ano
            //    });
            //}

            //objetoVista.Licenciamientos = new List<LicenciamientoViewModel>();
            //foreach (var licenciamiento in investigador.Licenciamientos)
            //{
            //    objetoVista.Licenciamientos.Add(new LicenciamientoViewModel()
            //    {
            //        ProductoLicenciado = licenciamiento.Producto,
            //        PersonaConLicenciamiento = licenciamiento.LicenciadoA,
            //        Ano = licenciamiento.Ano
            //    });
            //}

            //objetoVista.Software = new List<SoftwareViewModel>();
            //foreach (var software in investigador.Software)
            //{
            //    objetoVista.Software.Add(new SoftwareViewModel()
            //    {
            //        Titulo = software.Titulo,
            //        Plataforma = software.Plataforma,
            //        Ano = software.Ano
            //    });
            //}

            //objetoVista.Ponencias = new List<PonenciaViewModel>();
            //foreach (var ponencia in investigador.Ponencias)
            //{
            //    var catPaisPonencia = UipCatalogosGlobal.CatalogoPais;
            //    catPaisPonencia.ForEach(i => i.Selected = false);
            //    catPaisPonencia.First(i => i.Value == ponencia.IdPais.ToString()).Selected = true;

            //    objetoVista.Ponencias.Add(new PonenciaViewModel()
            //    {
            //        Titulo = ponencia.Titulo,
            //        Seminario = ponencia.Seminario,
            //        PaisSeleccionado = ponencia.NombrePais,
            //        Paises = catPaisPonencia,
            //        Ano = ponencia.Ano
            //    });
            //}

            //objetoVista.DatosPersonales = investigador.DatosPersonales;

            //#endregion

            //return View(objetoVista);
    }
}