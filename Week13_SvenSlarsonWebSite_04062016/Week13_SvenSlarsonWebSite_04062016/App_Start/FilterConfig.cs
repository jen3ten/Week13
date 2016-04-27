using System.Web;
using System.Web.Mvc;

namespace Week13_SvenSlarsonWebSite_04062016
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
