using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestePratico.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "Roberto Luís Ghisleni";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Entre em contato para me contratar:";

      return View();
    }
  }
}