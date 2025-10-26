using Microsoft.AspNetCore.Mvc; /// sınıfa  controller özelliği kazandırmak için ekledik . 

namespace Basics.Controllers
{

    public class EmployeeController : Controller   /// sınıfa  controller özelliği kazandırdık kalıtım aldırarak 
    {

        public String Index()
        {
            return "Hello World!"; /// burada ekranda herşey gider sadece yazımız olur 

        }

        public ViewResult Index2()
        {
            return View("Index"); // burada ise bir şablon döndüürürüz 
            // bu view i tanımlamamız gerek views klasörü içinde employee isimli bir klasör içine oluşturacağız .
        }



        public IActionResult Index3()
        {


            return Content("Employee");
        }
    }


}