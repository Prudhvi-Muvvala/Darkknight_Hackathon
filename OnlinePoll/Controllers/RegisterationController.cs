using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlinePoll.Controllers
{
    public class RegisterationController : Controller
    {
        // GET: Registeration
        public ActionResult RegisterToVote()
        {
            return View();
        }
    }
}