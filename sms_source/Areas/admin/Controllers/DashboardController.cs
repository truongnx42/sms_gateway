using Helper;
using sms_source.Areas.provider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sms_source.Areas.provider.Controllers
{
    public class DashboardController : Controller
    {
        //
        // GET: /admin/Dashboard/
        //

        public ActionResult Index()
        {

            return View();
        }

    }
}
