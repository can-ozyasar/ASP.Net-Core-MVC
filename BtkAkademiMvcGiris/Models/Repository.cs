


namespace BtkAkademiMvcGiris.Models
{


public static class Repository
    {


        private static List<Candidate> applications = new List<Candidate>();


        public static IEnumerable<Candidate> Applications => applications; /// sınıf içerisindeki listeye bakarak bize yanıt döndürecek 
        // getterimşz olacak 



        /// formdan gelecek elemanları ekleyebileceğimiz bir yapı kuralım 
        /// 
        /// 
        public static void Add(Candidate candidate)
        {
            
            applications.Add(candidate);
        }
    
    
    
    
    
    
    
    }


}