using Microsoft.EntityFrameworkCore;
using MiddleWareSimulation.Models;

namespace MiddleWareSimulation.Data
{
    public class SpinozaDBContext : DbContext
    {
        public SpinozaDBContext(DbContextOptions<SpinozaDBContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
