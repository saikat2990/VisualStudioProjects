using System.Web;
using System.Web.Mvc;

namespace Asp.netMvcTuitorial
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
