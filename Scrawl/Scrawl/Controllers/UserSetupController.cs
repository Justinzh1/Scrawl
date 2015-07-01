using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scrawl.Controllers
{
    public class UserSetupController : Controller
    {
        // GET: UserSetup
        public ActionResult UserSetup()
        {
            return View();
        }

        public ActionResult AgeForm()
        {
            return View();
        }
    }
}