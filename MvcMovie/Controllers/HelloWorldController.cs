using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        // GET: /HelloWorld/Welcome

        public string Welcome(string name, int numTimes = 1, int id = 1)
        {
            return $"Hello {name}, NumTimes is: {numTimes} and the id: {id}";
        }

    }
}
