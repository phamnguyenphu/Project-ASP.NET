using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CuaHangOto.Models;

namespace CuaHangOto.Controllers
{
    public class UserController : Controller
    {
        // GET: User

        CUAHANGOTOEntities db = new CUAHANGOTOEntities();
        
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(Account account)
        {
            var lg = db.Accounts.Where(a => a.Username.Equals(account.Username) && a.Pass.Equals(account.Pass)).FirstOrDefault();
            if (lg != null)
            {
                ViewBag.Message = "Sucess";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("SignIn", "User");
            }
        }

        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(Customer_info account)
        {
            db.Customer_info.Add(account);
            db.SaveChanges();
            return View();
        }
        [ValidateInput(false)]
        public ActionResult Validate(Staff_info e)
        {
            if(ModelState.IsValid)
            {
                ModelState.AddModelError("", "Nhap vao!");
            }
            return RedirectToAction("Login", "User");
        }
    }
}