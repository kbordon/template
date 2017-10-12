using Microsoft.AspNetCore.Mvc;
using TemplateVariable.Models;

namespace insert-name-here.Controllers
{
    public class HomeController : Controller
    {
        [Route("/name")]
        public string Name() { return "this string"; }

        [Produces("text/html")]
        [Route("/examplehtml")]
        public string ExampleHtml()
        {
          return
          "<!DOCTYPE html>" +
          "<html>" +
          "<head>" +
            "<title>Hello Friend!</title>" +
          "</head>" +
          "<body>" +
            "<h1>Hello From Afar</h1>" +
          "</body>" +
          "</html>";
        }

        [Route("/")]
        public ActionResult Index()
        {
          return View();
        }
    }
}
