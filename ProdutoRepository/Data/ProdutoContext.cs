using Microsoft.EntityFrameworkCore;
using ProdutoRepositoryModelo.Entities;

namespace ProdutoRepositoryModelo.Data
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }
    }
}
