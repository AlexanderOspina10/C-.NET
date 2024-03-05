using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD_RAZOR.Data;
using CRUD_RAZOR.Models;

namespace CRUD_RAZOR.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly CRUD_RAZOR.Data.CRUD_RAZORContext _context;

        public IndexModel(CRUD_RAZOR.Data.CRUD_RAZORContext context)
        {
            _context = context;
        }

        public IList<Pelicula> Pelicula { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Pelicula != null)
            {
                Pelicula = await _context.Pelicula.ToListAsync();
            }
        }
    }
}
