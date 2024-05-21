using MeetUp.Models;
using Microsoft.EntityFrameworkCore;

namespace MeetUp.DAL
{
    public class AddDbContext : DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> opt):base(opt) { }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
    
}
