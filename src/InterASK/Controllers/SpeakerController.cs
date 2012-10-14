using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SignalR;

namespace InterASK.Controllers
{
    public class SpeakerController : Controller
    {
        //
        // GET: /Speaker/
        public ActionResult Index()
        {
            return View();
        }

    }
}
