using DAL.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;

namespace MVC_Application1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ItemRepository loginData = new ItemRepository();
            List<tbl_Login> lst = loginData.getLoginTableData();
            ViewBag.Items = lst;
            //ViewBag.Count = lst.Count;
            return View("Index", ViewBag);
        }
    }
}