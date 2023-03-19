using Microsoft.AspNetCore.Identity;

namespace WebAppLearn.Data
{
    public class Employee:IdentityUser
    {
        public string? FistName { get; set; }
        public string? LastName { get; set; }
        public string? TaxId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set;}

    }
}
