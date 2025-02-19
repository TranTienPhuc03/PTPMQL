using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    { 
        // GET: /HelloWorld/
        public IActionResult IndexHelloWorld()
        {
            return View();
        } 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is my Welcome action";
        }
    }
}