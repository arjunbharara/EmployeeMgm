using Microsoft.AspNetCore.Identity;

namespace EmployeeManagement.Models
{
    public class Employee :IdentityUser 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DOB { get; set; }
        public string City { get; set; }

    }
}
