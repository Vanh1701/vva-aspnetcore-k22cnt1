using System.Web;
using System.Web.Mvc;

namespace vva_aspnetcore_k22cnt1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
