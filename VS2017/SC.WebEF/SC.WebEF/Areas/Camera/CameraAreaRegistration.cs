using System.Web.Mvc;

namespace SC.WebEF.Areas.Camera
{
    public class CameraAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Camera";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Camera_default",
                "Camera/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}