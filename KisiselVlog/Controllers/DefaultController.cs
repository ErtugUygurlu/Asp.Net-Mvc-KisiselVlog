using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KisiselVlog.Models.Entity;
using KisiselVlog.Models.MyClass;

namespace KisiselVlog.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        KisiselBlogDBEntities db= new KisiselBlogDBEntities();
        public ActionResult Index()
        {
            Class1 cs= new Class1();
            cs.Deger1 = db.TBLHAKKIMDA.ToList();
            cs.Deger2 = db.TBLILETISIM.ToList();
            return View(cs);
        }
    }
}