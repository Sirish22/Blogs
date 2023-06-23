using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;

namespace Blogs.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        //relation 
        public List<Post>? Post { get; set; }
    }
}
