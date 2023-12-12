using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Dal
{
    public class PractikumContext:DbContext
    {
        public PractikumContext(DbContextOptions<PractikumContext> options):base(options)
        {
            
        }
        DbSet<User> Users { get; set; }
    }
}
