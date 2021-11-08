using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace UIProcess.Modelos
{
    [Serializable]
    [DataContract]
    public class UipCatalogosInvestigador
    {
        [DataMember]
        public List<UipCatalogoTipoIdentificacion> CatalogoTipoIdentificacion { get; set; }
        [DataMember]
        public List<UipCatalogoPais> CatalogoPais { get; set; }

        public List<UipCatalogoSexo> CatalogoSexo { get; set; }
        [DataMember]
        public List<UipCatalogoSituacionLaboral> CatalogoSituacionLaboral { get; set; }
        [DataMember]
        public List<UipCatalogoInstitucion> CatalogoInstitucion { get; set; }
        [DataMember]
        public List<UipCatalogoTituloAcademico> CatalogoTituloAcademico { get; set; }
        [DataMember]
        public List<UipCatalogoIdioma> CatalogoIdioma { get; set; }
        [DataMember]
        public List<UipCatalogoNivelIdioma> CatalogoNivelIdioma { get; set; }
        [DataMember]
        public List<UipCatalogoUnidadAcademica> CatalogoUnidadAcademica { get; set; }
        [DataMember]
        public List<UipCatalogoTipoPerfil> CatalogoTipoPerfil { get; set; }
        [DataMember]
        public List<UipCatalogoDisciplinaCientifica> CatalogoDisciplinaCientifica { get; set; }
        [DataMember]
        public List<UipCatalogoSubdisciplinaCientifica> CatalogoSubdisciplinaCientifica { get; set; }
        [DataMember]
        public List<UipCatalogoEntidad> CatalogoEntidad { get; set; }
        [DataMember]
        public List<UipCatalogoRevista> CatalogoRevista { get; set; }
        [DataMember]
        public List<UipCatalogoIndiceRevista> CatalogoIndiceRevista { get; set; }
        [DataMember]
        public List<UipCatalogoEditorial> CatalogoEditorial { get; set; }
        [DataMember]
        public List<UipCatalogoParticipacionLibro> CatalogoParticipacionLibro { get; set; }
        [DataMember]
        public List<UipCatalogoTipoTelefono> CatalogoTipoTelefono { get; set; }
        [DataMember]
        public List<UipCatalogoCategoriaAcademica> CatalogoCategoriaAcademica { get; set; }

        public List<UipCatalogoPorcentajeNombramiento> CatalogoPorentajeNombramiento { get; set; }

        //public  UipCatalogosInvestigador(List<UipCatalogoTipoIdentificacion> catalogoTipoIdentificacion, List<UipCatalogoPais> catalogoPais, List<UipCatalogoSituacionLaboral> catalogoSituacionLaboral,
        //                  List<UipCatalogoInstitucion> catalogoInstitucion, List<UipCatalogoTituloAcademico> catalogoTituloAcademico, List<UipCatalogoIdioma> catalogoIdioma,
        //                  List<UipCatalogoNivelIdioma> catalogoNivelIdioma, List<UipCatalogoUnidadAcademica> catalogoUnidadAcademica, List<UipCatalogoTipoPerfil> catalogoTipoPerfil,
        //                  List<UipCatalogoDisciplinaCientifica> catalogoDisciplinaCientifica, List<UipCatalogoSubdisciplinaCientifica> catalogoSubdisciplinaCientifica,
        //                  List<UipCatalogoEntidad> catalogoEntidad, List<UipCatalogoRevista> catalogoRevista, List<UipCatalogoIndiceRevista> catalogoIndiceRevista,
        //                  List<UipCatalogoEditorial> catalogoEditorial, List<UipCatalogoParticipacionLibro> catalogoParticipacionLibro,
        //                  List<UipCatalogoTipoTelefono> catalogoTipoTelefono, List<UipCatalogoCategoriaAcademica> catalogoCategoriaAcademica)
        //{
        //    CatalogoTipoIdentificacion = catalogoTipoIdentificacion;
        //    CatalogoPais = catalogoPais;
        //    CatalogoSituacionLaboral = catalogoSituacionLaboral;
        //    CatalogoInstitucion = catalogoInstitucion;
        //    CatalogoTituloAcademico = catalogoTituloAcademico;
        //    CatalogoIdioma = catalogoIdioma;
        //    CatalogoNivelIdioma = catalogoNivelIdioma;
        //    CatalogoUnidadAcademica = catalogoUnidadAcademica;
        //    CatalogoTipoPerfil = catalogoTipoPerfil;
        //    CatalogoDisciplinaCientifica = catalogoDisciplinaCientifica;
        //    CatalogoSubdisciplinaCientifica = catalogoSubdisciplinaCientifica;
        //    CatalogoEntidad = catalogoEntidad;
        //    CatalogoRevista = catalogoRevista;
        //    CatalogoIndiceRevista = catalogoIndiceRevista;
        //    CatalogoEditorial = catalogoEditorial;
        //    CatalogoParticipacionLibro = catalogoParticipacionLibro;
        //    CatalogoTipoTelefono = catalogoTipoTelefono;
        //    CatalogoCategoriaAcademica = catalogoCategoriaAcademica;
        //}

    }
}