using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Context
{
    public class ApplicationDbContext:DbContext
    {
        //MAPEA NUESTRO MODELO PRODUCTO CON LA TABLA PRODUCT
        public DbSet<Product> Product { get; set; } //TABLA PRODUCTOS

        // CREAR UN CONTROLADOR QUE RECIBA COMO PARAMETRO EL DbContextOptions

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
