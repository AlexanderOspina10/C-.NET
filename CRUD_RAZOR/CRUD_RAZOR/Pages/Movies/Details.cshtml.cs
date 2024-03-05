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
    public class DetailsModel : PageModel
    {
        private readonly CRUD_RAZOR.Data.CRUD_RAZORContext _context;

        public DetailsModel(CRUD_RAZOR.Data.CRUD_RAZORContext context)
        {
            _context = context;
        }

      public Pelicula Pelicula { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Pelicula == null)
            {
                return NotFound();
            }

            var pelicula = await _context.Pelicula.FirstOrDefaultAsync(m => m.Id == id);
            if (pelicula == null)
            {
                return NotFound();
            }
            else 
            {
                Pelicula = pelicula;
            }
            return Page();
        }
    }
}
