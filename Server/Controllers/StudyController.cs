using Microsoft.AspNetCore.Mvc;

namespace MDR_FuiPortal.Server.Controllers
{
    public class StudyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
