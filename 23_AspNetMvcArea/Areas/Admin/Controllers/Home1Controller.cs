using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23_AspNetMvcArea.Areas.Admin.Controllers
{
    public class Home1Controller : Controller
    {
        // GET: Admin/Home1
        public ActionResult Index() //Admin Area’dan Customer Area’ya yonlendirme
        {
            return RedirectToAction("Index", "Home2", new { area = "Customer" });
        }
    }
}