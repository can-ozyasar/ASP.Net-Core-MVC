
using Basics.Models; // employee sınıfına erişebilmek için yazdık index 3 de
using Microsoft.AspNetCore.Mvc;
/// sınıfa  controller özelliği kazandırmak için ekledik . 
/// 


namespace Basics.Controllers
{

    public class EmployeeController : Controller   /// sınıfa  controller özelliği kazandırdık kalıtım aldırarak 
    {

        public IActionResult Index1()
        {
            // ders 2.9 da yorum satırı yaptık return "Hello World!"; /// burada ekranda herşey gider sadece yazımız olur 

            string message = $"Hello World! .{DateTime.Now.ToString()}"; // şuandaki tarih bilgisini mesaja ekledik mesaj değişkeni oluşturduk
            return View("Index1",message); /// view ifadesini yazarız , ikinci kısıma ise mesajıı veriyoruz

        }

        public ViewResult Index2()
        {


            var names = new String[]
            {

                "Ahmet","Mehmet","Can"
            };

            return View(names); // burada ise bir şablon döndüürürüz 
            // bu view i tanımlamamız gerek views klasörü içinde employee isimli bir klasör içine oluşturacağız .
        }



        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {
                
                new Employee(){ Id =1,FirstName="Ahmed" ,LastName="Can",Age=20},
                new Employee(){ Id =1,FirstName="Muhammed" ,LastName="Can",Age=25},
                new Employee(){ Id =1,FirstName="Tarık" ,LastName="",Age=24},
                new Employee(){ Id =1,FirstName="Kemal" ,LastName="Can",Age=18}
 
            };

            return View("Index3",list); // index3.cshtml ye git ve yanında list i götür 
        }
    }


}