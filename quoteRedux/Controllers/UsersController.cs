using System;
using LoginReg.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginReg.Factory;
using Microsoft.AspNetCore.Http;
namespace LoginReg.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserFactory userFactory;
        private readonly QuoteFactory quoteFactory;
        public UsersController()
        {
            quoteFactory = new QuoteFactory();
            userFactory = new UserFactory();
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.errorlist = new List<string>();
            string newb = "";
            ViewBag.confirm = newb;
            ViewBag.prevemail = newb;
            ViewBag.wrongpass = newb;
            ViewBag.wrongmail = newb; 
            return View();
        }
        [HttpPost]
        [Route("register")]
        public IActionResult Register(User newuser)
        {
            if(ModelState.IsValid){
                if(userFactory.FindByEmail(newuser.email) == null) //if user doesnt exist in database
                {
                    if (newuser.confpass == newuser.pass){ //if passwords match
                        userFactory.Add(newuser);
                        HttpContext.Session.SetInt32("current_id", newuser.Id);
                        return RedirectToAction("Home");
                    }
                    else{
                        ViewBag.errorlist = new List<string>();
                        ViewBag.confirm = "Confirm password must match password.";
                        return View("Index");
                    }
                }
                else{
                    ViewBag.errorlist = new List<string>();
                    ViewBag.prevemail = "Email already exists in database.";
                    return View("Index");
                }
            }
            else{
                ViewBag.errorlist = ModelState.Values;
                return View("Index");
            } 
        }
        [HttpPost]
        [Route("login")]
        public IActionResult Login(string email, string pass)
        {
            User founduser = userFactory.FindByEmail(email);
            if(founduser != null){ //email in db
                if (founduser.pass == pass){ //right pass
                    HttpContext.Session.SetInt32("current_id", founduser.Id);
                    return RedirectToAction("Home");
                }
                else{
                    ViewBag.errorlist = new List<string>();
                    ViewBag.wrongpass = "Password is incorrect for this email";
                    return View("Index");
                }
            }
            else{
                ViewBag.errorlist = new List<string>();
                ViewBag.wrongmail = "Email does not exist in database.";
                return View("Index");
            }
        }
        [HttpGet]
        [Route("home")]
        public IActionResult Home()
        {
            User currentuser = userFactory.FindByID(HttpContext.Session.GetInt32("current_id"));
            string newb = "";
            ViewBag.name = currentuser.fname;
            ViewBag.isquote = newb;
            ViewBag.Quotes = quoteFactory.FindAll();
            return View();
        }
        [HttpPost]
        [Route("quotes")]
        public IActionResult Create(Quote newQuote)
        {
            if(ModelState.IsValid){
                int? theid = HttpContext.Session.GetInt32("current_id");
                quoteFactory.Add(newQuote, theid);
                return RedirectToAction("Home");
            }
            else {
                ViewBag.name = userFactory.FindByID(HttpContext.Session.GetInt32("current_id")).fname;
                ViewBag.isquote = "You did not enter a quote";
                ViewBag.Quotes = quoteFactory.FindAll();
                return View("Home");
            }
        }
        [HttpGet]
        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

    }
}
