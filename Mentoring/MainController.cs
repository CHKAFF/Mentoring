using Microsoft.AspNetCore.Mvc;

namespace Mentoring
{
    public class MainController : Controller
    {
        // GET
        public string Index(string name)
        {
            return $"Hello {name}";
        }
    }
}