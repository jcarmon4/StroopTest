using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StroopTest.Models;

namespace StroopTest.Pages.ActivityRecords
{
    public class DeleteModel : PageModel
    {
        private readonly StroopTest.Models.StroopTestContext _context;

        public DeleteModel(StroopTest.Models.StroopTestContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ActivityRecord ActivityRecord { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ActivityRecord = await _context.ActivityRecord.FirstOrDefaultAsync(m => m.ID == id);

            if (ActivityRecord == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ActivityRecord = await _context.ActivityRecord.FindAsync(id);

            if (ActivityRecord != null)
            {
                _context.ActivityRecord.Remove(ActivityRecord);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
