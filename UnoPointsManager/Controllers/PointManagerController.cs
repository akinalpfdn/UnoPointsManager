using Microsoft.AspNetCore.Mvc;

namespace UnoPointsManager.Controllers
{
    public class PointManagerController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}