using System.Web.Mvc;

namespace sms_source.Areas.provider
{
    public class providerAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "provider";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "provider_default",
                "provider-{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
