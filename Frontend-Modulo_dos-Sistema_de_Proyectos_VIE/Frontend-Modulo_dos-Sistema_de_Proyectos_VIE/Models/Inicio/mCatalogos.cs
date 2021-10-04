using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE.Models.Inicio
{
    [Serializable]
    [DataContract]
    public class mCatalogos
    {
        [DataMember]
        public List<mCatalogoTipoIdentificacion> CatalogoTipoIdentificacion { get; set; }
        [DataMember]
        public List<mCatalogoPais> CatalogoPais { get; set; }
        [DataMember]
        public List<mCatalogoSituacionLaboral> CatalogoSituacionLaboral { get; set; }
        [DataMember]
        public List<mCatalogoInstitucion> CatalogoInstitucion { get; set; }
        [DataMember]
        public List<mCatalogoTituloAcademico> CatalogoTituloAcademico { get; set; }
        [DataMember]
        public List<mCatalogoIdioma> CatalogoIdioma { get; set; }
        [DataMember]
        public List<mCatalogoNivelIdioma> CatalogoNivelIdioma { get; set; }
        [DataMember]
        public List<mCatalogoUnidadAcademica> CatalogoUnidadAcademica { get; set; }
        [DataMember]
        public List<mCatalogoTipoPerfil> CatalogoTipoPerfil { get; set; }
        [DataMember]
        public List<mCatalogoDisciplinaCientifica> CatalogoDisciplinaCientifica { get; set; }
        [DataMember]
        public List<mCatalogoSubdisciplinaCientifica> CatalogoSubdisciplinaCientifica { get; set; }
        [DataMember]
        public List<mCatalogoEntidad> CatalogoEntidad { get; set; }
        [DataMember]
        public List<mCatalogoRevista> CatalogoRevista { get; set; }
        [DataMember]
        public List<mCatalogoIndiceRevista> CatalogoIndiceRevista { get; set; }
        [DataMember]
        public List<mCatalogoEditorial> CatalogoEditorial { get; set; }
        [DataMember]
        public List<mCatalogoParticipacionLibro> CatalogoParticipacionLibro { get; set; }

        public mCatalogos(List<mCatalogoTipoIdentificacion> catalogoTipoIdentificacion, List<mCatalogoPais> catalogoPais, List<mCatalogoSituacionLaboral> catalogoSituacionLaboral,
                          List<mCatalogoInstitucion> catalogoInstitucion, List<mCatalogoTituloAcademico> catalogoTituloAcademico, List<mCatalogoIdioma> catalogoIdioma,
                          List<mCatalogoNivelIdioma> catalogoNivelIdioma, List<mCatalogoUnidadAcademica> catalogoUnidadAcademica, List<mCatalogoTipoPerfil> catalogoTipoPerfil,
                          List<mCatalogoDisciplinaCientifica> catalogoDisciplinaCientifica, List<mCatalogoSubdisciplinaCientifica> catalogoSubdisciplinaCientifica,
                          List<mCatalogoEntidad> catalogoEntidad, List<mCatalogoRevista> catalogoRevista, List<mCatalogoIndiceRevista> catalogoIndiceRevista,
                          List<mCatalogoEditorial> catalogoEditorial, List<mCatalogoParticipacionLibro> catalogoParticipacionLibro)
        {
            CatalogoTipoIdentificacion = catalogoTipoIdentificacion;
            CatalogoPais = catalogoPais;
            CatalogoSituacionLaboral = catalogoSituacionLaboral;
            CatalogoInstitucion = catalogoInstitucion;
            CatalogoTituloAcademico = catalogoTituloAcademico;
            CatalogoIdioma = catalogoIdioma;
            CatalogoNivelIdioma = catalogoNivelIdioma;
            CatalogoUnidadAcademica = catalogoUnidadAcademica;
            CatalogoTipoPerfil = catalogoTipoPerfil;
            CatalogoDisciplinaCientifica = catalogoDisciplinaCientifica;
            CatalogoSubdisciplinaCientifica = catalogoSubdisciplinaCientifica;
            CatalogoEntidad = catalogoEntidad;
            CatalogoRevista = catalogoRevista;
            CatalogoIndiceRevista = catalogoIndiceRevista;
            CatalogoEditorial = catalogoEditorial;
            CatalogoParticipacionLibro = catalogoParticipacionLibro;
        }

    }
}