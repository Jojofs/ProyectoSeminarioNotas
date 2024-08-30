using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProyectoControlNotas.Models
{

    public class LoginDbContext : IdentityDbContext
       
        
    {
        public LoginDbContext(DbContextOptions<LoginDbContext> Options) : base(Options)
        {

        }
    }
}
