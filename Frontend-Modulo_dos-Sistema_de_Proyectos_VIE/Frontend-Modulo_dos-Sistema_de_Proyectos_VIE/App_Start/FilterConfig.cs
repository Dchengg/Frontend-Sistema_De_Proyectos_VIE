using System.Web.Mvc;

namespace Frontend_Modulo_dos_Sistema_de_Proyectos_VIE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
