using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class KeerthanController : Controller
    {
        [Route("/api/keerthan")]
        public IActionResult Index()
        {
            return Json(new
            {
                name = "Keerthan",
                team = "Cloud Team"
            });
        }
    }
}
