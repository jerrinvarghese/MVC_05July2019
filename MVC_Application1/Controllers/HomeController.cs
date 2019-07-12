using DAL.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using MVC_Application1.Models;

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
        public ActionResult angularJSExample()
        {
            return View();
        }


        public ActionResult VerifyUser(UserModel obj)
        {
            DbForLearningEntities context = new DbForLearningEntities();
            var user = context.tbl_Login.Where(x => x.UserEmail.Equals(obj.Email) && x.UserPassword.Equals(obj.Password)).FirstOrDefault();
            return new JsonResult
            {
                Data = user,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
        public ActionResult LoginPage1()
        {
            return View();
        } 

        public ActionResult ngRouteView()
        {
            return View();
        }
    }

}