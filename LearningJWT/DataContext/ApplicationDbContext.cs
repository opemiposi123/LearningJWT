using LearningJWT.Models;
using Microsoft.EntityFrameworkCore;



namespace Persistence.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<UserModel> User { get; set; }
    }
}