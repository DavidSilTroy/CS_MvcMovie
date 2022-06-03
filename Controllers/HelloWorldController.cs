using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome

        public string Welcome(string name, int numTimes = 1, int id = 1)
        {
            //HelloWorld/Welcome/2?name=David%20Silva&numtimes=3
            return $"Hello {name}, NumTimes is: {numTimes} and the id: {id}";
        }

    }
}
