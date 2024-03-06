using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace projectef.Models;

public class Tarea{
    //[Key] //DATA ANOTATION, DEFINE LA CALVE PRIMARIA DE LA TABLA
    public Guid TareaId{get;set;} 

    [ForeignKey("CategoriaID")]

    public Guid CategoriaId{get;set;}
    //Validaciones
    //[Required]
    //[MaxLength(200)]

    public string Titulo{get;set;}

    public string Descripcion{get;set;}



    public Prioridad PrioridadTarea{get;set;}
    public DateTime FechaCreacion{get;set;}
    public virtual Categoria Categoria {get;set;}
    //[NotMapped]//El resumen no se rea en la BD
    public string Resumen{get;set;}
}

public enum Prioridad{
    Baja,
    Media,
    Alta
}