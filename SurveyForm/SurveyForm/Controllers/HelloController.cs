using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace YourNamespace.Controllers
{
 public class HelloController : Controller
 {
        

[HttpGet]
[Route("/index")]
public IActionResult Index()
{
 return View();
 
}

[HttpPost]
[Route("/Post")]
public IActionResult Index(string Name, String Location, String Language, String Comment)
{
    Dictionary<string, string> Info = new Dictionary<string, string>();
    Info.Add("name",Name);
    Info.Add("location",Location);
    Info.Add("language",Language);
    Info.Add("comment",Comment);

    ViewBag.values = Info; 
   return View("Post");

}


public IActionResult Method()
{
 return RedirectToAction("OtherMethod", new {parameter = "this is a string"});
}




 }
 
 
}