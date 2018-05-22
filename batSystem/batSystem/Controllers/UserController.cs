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
   
    [Authorize]
    public class UserController : Controller
    {
        public UserManager UserManager
        {
            get { return HttpContext.GetOwinContext().Get<UserManager>(); }
        }
        private UserMethods userMethods;
        public UserController(UserMethods userMethods)
        {
            this.userMethods = userMethods;
        }
       // GET: User
        public ActionResult Index()
        {
            var model = new UserListViewModel
            {
                Users = userMethods.GetAll()
            };
            return View(model);
        }
        public ActionResult CreateNewUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateNewUser(CreateNewUserModel model)
        {
            if (ModelState.IsValid)
            {
                 User newUser = new User { UserName = model.UserName, FirstName = model.FirstName, SecondName = model.SecondName, LastName = model.LastName };
               var result = UserManager.CreateAsync(newUser, model.Password);
                if(!result.Result.Succeeded)
                {
                    foreach (var er in result.Result.Errors)
                    {
                        ModelState.AddModelError("", er);
                    }
                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Проверьте правильность введенных данных");
            }
            return View(model);
        }
        
        public ActionResult ChangeUser(ChangeUserModel model, long id)
        {
            if (ModelState.IsValid)
            { User current = new User();
                current = userMethods.Load(id);
                return View(new ChangeUserModel
                {
                    Email = current.Email,
                    FirstName = current.FirstName,
                    SecondName = current.SecondName,
                    LastName = current.LastName,

                
                });
                current.UserName = model.UserName;// = { UserName = model.UserName, Password = current.Password, FirstName = model.FirstName, SecondName = model.SecondName, LastName = model.LastName };
                current.FirstName = model.FirstName;
                current.SecondName = model.SecondName;
                current.LastName = model.LastName;
                userMethods.Change(current);
                return RedirectToAction("Index", "Home");
            }
            return View(model);

        }
        [HttpPost]
        public ActionResult Edit (UserViewModel model)
        {
            var user = userMethods.Load(model.Id);
            user.DateofBirth = Convert.ToDateTime( model.DateofBirth);
            user.Email = model.Email;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.SecondName = model.SecondName;
            user.UserName = model.UserName;
            user.Status = model.Status;
            userMethods.Change(user);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Edit(long id)


        { 


          var user = userMethods.Load(id); 


           return View(new UserViewModel { 


              Id = user.Id, 
              FirstName = user.FirstName, 
             UserName = user.UserName, 
             LastName = user.LastName,
             SecondName = user.SecondName,
            Status = user.Status 
  }); 


  } 
        ////public ActionResult FindUser()
        ////{
        ////    User user;
        ////    return RedirectToAction("ChangeUser", "User") ;

        ////}
    }
}