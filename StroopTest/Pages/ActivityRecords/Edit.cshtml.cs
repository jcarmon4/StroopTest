using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StroopTest.Models;

namespace StroopTest.Pages.ActivityRecords
{
    public class EditModel : PageModel
    {
        private readonly StroopTest.Models.StroopTestContext _context;

        public EditModel(StroopTest.Models.StroopTestContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ActivityRecord).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActivityRecordExists(ActivityRecord.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ActivityRecordExists(int id)
        {
            return _context.ActivityRecord.Any(e => e.ID == id);
        }
    }
}
