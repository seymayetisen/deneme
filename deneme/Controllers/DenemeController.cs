using deneme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace deneme.Controllers
{
    public class DenemeController : Controller
    {
        // GET: Deneme
        public ActionResult Index()
        {

            return View();
        }
        public JsonResult IsLogin(string username,string sifre)
        {
            LoginYonetimDbContext aaaa = new LoginYonetimDbContext();
            List<Login> lll = aaaa.login.Where(p=>p.username.Contains(username)).ToList();

            return Json(lll, JsonRequestBehavior.AllowGet);
            
        }
    }
}