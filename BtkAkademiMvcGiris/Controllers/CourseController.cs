using Microsoft.AspNetCore.Mvc;
using BtkAkademiMvcGiris.Models;

namespace BtkAkademiMvcGiris.Controllers
{

    public class CourseController : Controller
    {


        public IActionResult Index()
        {

            return View();

        }
        public IActionResult Apply() // sunucudan bilgi taleb eden bir sayfa olacak 
        {

            return View();

        }

        [HttpPost] // bu sayede default olan get isteğini biz post olarak atadık dotnet
        [ValidateAntiForgeryToken]  //site güvenliği için 
        public IActionResult Apply([FromForm] Candidate model)  // gelecek bilginin nereden geleceğini de belirtebiliriz .[FromForm]
        {

            return View();

        }
    }


}