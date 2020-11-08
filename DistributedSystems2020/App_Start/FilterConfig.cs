using System.Web;
using System.Web.Mvc;

namespace DistributedSystems2020 {
    public class FilterConfig {
        public static void RegisterGlobalFilters( GlobalFilterCollection filters ) {
            filters.Add( new HandleErrorAttribute() );
        }
    }
}
