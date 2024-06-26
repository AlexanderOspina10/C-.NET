using System.ComponentModel.DataAnnotations;

namespace projectef.Models;

public class Categoria{
//Atributos generales del model

//[Key] //DATA ANOTATION, DEFINE LA CALVE PRIMARIA DE LA TABLA

public Guid CategoriaId{get;set;}

//[Required]
//[MaxLength(150)]

public string Nombre{get;set;}

public string Descripcion{get;set;}


public virtual ICollection<Tarea> Tareas {get;set;}

public int Peso {get;set;}
}