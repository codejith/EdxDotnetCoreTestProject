using Microsoft.AspNetCore.Mvc;

namespace TestApp.Controllers { 
    public class TestController : Controller {
        
        public IActionResult Foo() {
            ViewBag.Title = "Foo";
            ViewBag.Header = "Foo Header";
            ViewBag.Items = "ABC DEF GHI".Split(" ");
            return View();
        }
    }
}