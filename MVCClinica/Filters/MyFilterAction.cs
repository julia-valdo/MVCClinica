using System.Diagnostics;
using System.Web.Mvc;

namespace MVCClinica.Filters
{
    public class MyFilterAction : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var controller = filterContext.RouteData.Values["controller"];
            var action = filterContext.RouteData.Values["action"];

            Debug.WriteLine("Controller: " + controller + "\nAction:" + action + "\nPaso por OnActionExecuting");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var controller = filterContext.RouteData.Values["controller"];
            var action = filterContext.RouteData.Values["action"];

            Debug.WriteLine("Controller: " + controller + "\nAction:" + action + "\nPaso por OnActionExecuted");
        }
    }
}