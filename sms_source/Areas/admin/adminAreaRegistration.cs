using System.Web.Mvc;

namespace sms_source.Areas.provider
{
    public class adminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "admin_default",
                "admin-{controller}/{action}/{id}",
                new { controller = "dashboard", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
