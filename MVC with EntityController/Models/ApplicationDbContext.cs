using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MVC_with_EntityController.Models.Entities;

namespace MVC_with_EntityController.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }

        public DbSet<Product> Products { get; set; }
    }
}
