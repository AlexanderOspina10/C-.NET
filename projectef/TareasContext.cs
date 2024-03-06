
using Microsoft.EntityFrameworkCore;
using projectef.Models;
namespace projectef;

public class TareasContext:DbContext{
    //Aqui se importan la libreria using..
    //Representan las tablas dentro de la BD
public DbSet<Categoria> Categorias{get;set;}
public DbSet<Tarea> Tareas{get;set;}

//CREAR EL METODO BASE DEL CONSTRUCTOR

public TareasContext (DbContextOptions<TareasContext>options):base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(categoria => {
             categoria.ToTable("Categoria");   //CREAR LA TABLA CATEGORIAS
             categoria.HasKey(p => p.CategoriaId); //CREAR CATEGORIA ID
             categoria.Property(p=> p.Nombre).IsRequired().HasMaxLength(150);
             categoria.Property(p=>p.Descripcion);
        });

        modelBuilder.Entity<Tarea>(tarea=>{
            tarea.ToTable("Tarea");//CREAR LA TABLA TAREA
            tarea.HasKey(p=>p.TareaId);//CREAR LA PK DE LA TABLA
            tarea.HasOne(p=>p.Categoria).WithMany(p=>p.Tareas).HasForeignKey(p=>p.CategoriaId);//CLAVE FORANEA
            tarea.Property(p=>p.Titulo).IsRequired().HasMaxLength(200);
            tarea.Property(p=>p.Descripcion);
            tarea.Property(p=>p.PrioridadTarea);
            tarea.Property(p=>p.FechaCreacion);
            tarea.Ignore(p=>p.Resumen);
        });
    }
}
