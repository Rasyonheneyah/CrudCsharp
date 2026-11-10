using Microsoft.AspNetCore.Mvc;

namespace academico.Controllers
{
    public class MyController : Controller
    {
        public IActionResult MyAction()
        {
            return View();
        }
    }
}
