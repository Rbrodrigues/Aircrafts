using System.Web;
using System.Web.Mvc;

namespace Konatus.ABCD_Airlines.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
