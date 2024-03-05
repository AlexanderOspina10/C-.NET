using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_RAZOR.Models;

namespace CRUD_RAZOR.Data
{
    public class CRUD_RAZORContext : DbContext
    {
        public CRUD_RAZORContext (DbContextOptions<CRUD_RAZORContext> options)
            : base(options)
        {
        }

        public DbSet<CRUD_RAZOR.Models.Pelicula> Pelicula { get; set; } = default!;
    }
}
