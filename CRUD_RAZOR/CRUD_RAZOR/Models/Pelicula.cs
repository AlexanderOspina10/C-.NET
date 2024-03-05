using System.ComponentModel.DataAnnotations;

namespace CRUD_RAZOR.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        [DataType(DataType.Date)]

        public DateTime ReleaseDate { get; set; }

        public string? Genre { get; set; }

        public decimal Price { get; set; }

    }

}
