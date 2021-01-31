using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class BaseController : Controller
    {
        private readonly ILog _iLog;

        public BaseController()
        {
            _iLog = Log.GetInstance;
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            _iLog.LogException(filterContext.Exception.ToString());
            filterContext.ExceptionHandled = true;
            this.View("Error").ExecuteResult(this.ControllerContext);
        }
    }
}