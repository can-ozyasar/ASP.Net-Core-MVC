namespace Basics.Models
{
    


    public class Employee
    {
        public int Id { get; set; }

        public String FirstName { get; set; } = String.Empty;
        public String LastName { get; set; } = String.Empty;

        public String FullName => $"{FirstName} {LastName.ToUpper()}";// otomatik olarak değişken e atanacak 

        public int Age { get; set; } = 0; /// default değeri belirttik 
    }
}