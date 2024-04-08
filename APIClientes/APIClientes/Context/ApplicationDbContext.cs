using APIClientes.Models;
using Microsoft.EntityFrameworkCore;

namespace APIClientes.Context
{
    public class ApplicationDbContext:DbContext


    {
        public DbSet<Clientes> Clientes { get; set; }   //TABLA CLIENTES

        //CREAR UN CONTROLADOR QUE RECIBE COMO PARAMETRO EL DB CONTEXTOPTION

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base (options) { }
    }
}
