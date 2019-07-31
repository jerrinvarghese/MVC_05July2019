using DAL;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.ViewModels;

namespace MVC_Application1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        ItemRepository itemrepository = new ItemRepository();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginPage(FormCollection collection)
        {
            var un = collection["username"];
            var pwd = collection["password"];
            //ItemRepository itemrepository = new ItemRepository();
            List<tbl_Login> authenticatedUser = itemrepository.getLoginTableData();
            foreach (var item in authenticatedUser)
            {
                if ((un == item.UserID) && (pwd == item.UserPassword))
                {
                    return RedirectToAction("DisplayLoginData","Home");
                }
                else
                {
                    ViewBag.LoginError="The credentials are invalid";
                }
             }
            return View();
        }
        
        public ActionResult RegisterPage()
        {
            RegisterNewUserViewModel registerNewUserViewModel = new RegisterNewUserViewModel();
            return View(registerNewUserViewModel);
        }
        [HttpPost]
        public ActionResult RegisterPage(RegisterNewUserViewModel registerNewUserViewModel)
        {
            //ItemRepository itemrepository = new ItemRepository();
            itemrepository.saveNewRegisterationData(registerNewUserViewModel);
            return View();
        }
        [HttpPost]
        public ActionResult EditRegisteredUser(fetchingSpecificLoginData userUpdatedData)
        {
            bool flag = true;
            itemrepository.EditUserRegistrationData(userUpdatedData);
            if(flag==false)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            
        }

        public ActionResult HomePage()
        {
            return View();
        }
    }
}