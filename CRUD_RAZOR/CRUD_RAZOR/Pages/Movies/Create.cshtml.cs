using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CRUD_RAZOR.Data;
using CRUD_RAZOR.Models;

namespace CRUD_RAZOR.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly CRUD_RAZOR.Data.CRUD_RAZORContext _context;

        public CreateModel(CRUD_RAZOR.Data.CRUD_RAZORContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pelicula Pelicula { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Pelicula.Add(Pelicula);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
