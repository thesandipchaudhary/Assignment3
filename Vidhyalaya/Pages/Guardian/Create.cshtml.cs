using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Vidhyalaya.Pages.Guardian
{
    public class CreateModel : PageModel
    {
        private readonly VidhyalayaDbContext _context;

        public CreateModel(VidhyalayaDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Guardian Guardian { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Guardian.Add(Guardian);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
