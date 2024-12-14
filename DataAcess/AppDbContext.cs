using API_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace API_CRUD.DataAcess;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options){}
    public DbSet<UserModel> Users { get; set; }
    public DbSet<CompanyModel> Companies { get; set; }

}

