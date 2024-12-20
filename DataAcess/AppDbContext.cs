using API_CRUD.Models;
using API_CRUD.Services.Product;
using Microsoft.EntityFrameworkCore;

namespace API_CRUD.DataAcess
{
    public class AppDbContext : DbContext
    {
        // Construtor para passar opções de configuração ao DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Tabelas mapeadas para o banco de dados
        public DbSet<UserModel> Users { get; set; }        // Representa a tabela de usuários
        public DbSet<CompanyModel> Companies { get; set; } // Representa a tabela de empresas
        public DbSet<ProductModel> Products { get; set; }       // Representa a tabela de produtos
        public DbSet<OrderModel> Orders { get; set; }
    }
}
