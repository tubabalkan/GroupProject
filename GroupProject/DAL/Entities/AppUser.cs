using Microsoft.AspNetCore.Identity;

namespace GroupProject.DAL.Entities
{
    public class AppUser:IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
    }
}
