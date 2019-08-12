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
    public class DetailsModel : PageModel
    {
        private readonly StroopTest.Models.StroopTestContext _context;

        public DetailsModel(StroopTest.Models.StroopTestContext context)
        {
            _context = context;
        }

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
    }
}
