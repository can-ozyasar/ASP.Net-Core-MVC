using Microsoft.AspNetCore.Mvc;
using BtkAkademiMvcGiris.Models;

namespace BtkAkademiMvcGiris.Controllers
{

    public class CourseController : Controller
    {


        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);

        }
        public IActionResult Apply() // sunucudan bilgi taleb eden bir sayfa olacak 
        {

            return View();

        }

        [HttpPost] // bu sayede default olan get isteğini biz post olarak atadık dotnet
        [ValidateAntiForgeryToken]  //site güvenliği için 
        public IActionResult Apply([FromForm] Candidate model)  // gelecek bilginin nereden geleceğini de belirtebiliriz .[FromForm]
        {
            if (Repository.Applications.Any(c => c.Email.Equals(model.Email))) /// her e mail ile tek başvuru olsun diye
            {
                ModelState.AddModelError("", "there is already an application for you ");
            }



            if (ModelState.IsValid) // formu boş göderme engellemek için kontrol ekdik .
            {

                Repository.Add(model);
                return View("FeedBack", model);


            }
            else
            {
                return View();



            }


        }
    }


}