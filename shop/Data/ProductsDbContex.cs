//define the context of the database and the model
//represents the database, where the models represents the table

using Microsoft.EntityFrameworkCore;
using shop.Models;

namespace shop.Data;

public class ProductsDbContext : DbContext
{
    public DbSet<Models.ProductsModel> Products {get; set;}
    public DbSet<Models.ListsModel> Lists {get; set;}
    public ProductsDbContext(DbContextOptions<ProductsDbContext> options)
        :base(options){}
}