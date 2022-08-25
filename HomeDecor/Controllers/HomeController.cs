using Microsoft.AspNetCore.Mvc;
namespace HomeDecor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}