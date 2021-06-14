using LojaAspNet.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaAspNet.Data
{
    public class LojaContext : DbContext
    {
        public LojaContext(DbContextOptions<LojaContext> options) : base(options) {}

        public DbSet<Produto> Produto { get; set; }
    }
}
