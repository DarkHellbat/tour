using batSystem.Auth;
using batSystem.Models;
using batSystem.Models.Mappings;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace batSystem.Controllers
{
    public class AccountController : Controller
    {
        private UserMethods meth;
        public SignInManager SignInManager
        {
            get { return HttpContext.GetOwinContext().Get<SignInManager>(); }
        }
        public UserManager UserManager
        {
            get { return HttpContext.GetOwinContext().Get<UserManager>(); }
        }
        public AccountController(UserMethods meth)
        {
            this.meth = meth;
        }
        public ActionResult CreateUserByRequest(string login, string password)
        {
            var user = new User
            {
                UserName = login,
            };
            var result = UserManager.CreateAsync(user, password);
            if (result.Result.Succeeded)
            {
                SignInManager.SignIn(user, false, false);
            }
            else
            {
                foreach (var error in result.Result.Errors)
                {
                    ModelState.AddModelError("", error);

                }


            }
            return RedirectToAction("Index", "Home");
            //meth.Save(user);
            //return View("View");
        }
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            ViewData.TemplateInfo.HtmlFieldPrefix = "mod1[0].Id";
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model) //[Bind(Prefix ="mod1")]
        {
            if (ModelState.IsValid)
            {
                var result = SignInManager.PasswordSignIn(model.UserName, model.Password, false, false);
                if (result == SignInStatus.Success)
                {
                   User current = meth.FindByLogin(model.UserName);
                    meth.RememberCurrent(current);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Неверное имя пользователя или пароль");
                }
            }
            return View(model);
        }
        public ActionResult LogOff()
        {
            SignInManager.SignOut();
            return RedirectToAction("Index", "Home");
        }
       
      
      
        
    }
}