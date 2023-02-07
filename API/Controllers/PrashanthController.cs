using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PrashanthController : Controller
    {
        [Route("/api/prashanth")]
        public IActionResult Index()
        {
            return Json(new
            {
                name = "Prashanth",
                team = "Cloud Team"
            });
        }
    }
}
