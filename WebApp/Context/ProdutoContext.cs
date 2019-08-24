using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Context
{
    public class ProdutoContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=faculdade;Uid=root;Pwd=leoq15/*;");
            base.OnConfiguring(optionsBuilder);
        }

        public ProdutoContext()
        {
            Database.EnsureCreated();
        }
    }
}
