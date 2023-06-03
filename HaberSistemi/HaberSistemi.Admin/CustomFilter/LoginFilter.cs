using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberSistemi.Admin.CustomFilter
{
    public class LoginFilter : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context) //Aksiyon aldıktan sonra olanları yazacağımız alan.
        {
            HttpContextWrapper wrapper = new HttpContextWrapper(HttpContext.Current);
            var SessionControl = context.HttpContext.Session["KullaniciEmail"];
            if (SessionControl == null)
            {
                context.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary { { "controller", "Account" }, { "Action", "Login" } });
            }
        }

        public void OnActionExecuting(ActionExecutingContext context) //Aksiyon alırken olanları yazacağımız alan.
        {
            
        }
    }
}