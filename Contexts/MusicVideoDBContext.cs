using Microsoft.EntityFrameworkCore;
using MusicVideo_MVC.Models;

namespace MusicVideo_MVC.Contexts
{
    public class MusicVideoDBContext : DbContext
    {
        public MusicVideoDBContext(DbContextOptions<MusicVideoDBContext> options) : base(options){}

        public DbSet<Mv> Mv{ get; set;}
    }
}