// candidate = aday

namespace BtkAkademiMvcGiris.Models
{

    public class Candidate
    {

 
        /// <summary>
        /// buradai ? işareti o alanı boş gelirse hata vermiyeceği anlamına gelir 
        /// değervar ise döndür yok ise bişey yapma 
        /// </summary>
        public String? Email { get; set; } = String.Empty; // ilk değer olarak boş atadık 
        public String? FirstName { get; set; } = String.Empty;
        public String? LastName { get; set; } = String.Empty;
        public String? SelectedCourse { get; set; } = String.Empty;

        public String FullName =>$"{FirstName}{LastName?.ToUpper()}"; // eğer lastname var ise büyüt yaz yoksa bişey yapma 
        public int Age { get; set; }
        public DateTime ApplyAt { get; set; }

        

        public Candidate()
        {

            ApplyAt = DateTime.Now; // o anki değer başvuru tarihi olarak atansın 
        }

    }



}