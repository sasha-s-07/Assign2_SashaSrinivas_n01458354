using System.Web;
using System.Web.Mvc;

namespace Assign2_SashaSrinivas_n01458354
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
