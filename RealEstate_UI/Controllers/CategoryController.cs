using Microsoft.AspNetCore.Mvc;

namespace RealEstate_UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
