using Microsoft.EntityFrameworkCore;
using MVCTASK.Models;
using System.Security.Cryptography.X509Certificates;

namespace MVCTASK.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}
