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
    public class IndexModel : PageModel
    {
        private readonly StroopTest.Models.StroopTestContext _context;

        public IndexModel(StroopTest.Models.StroopTestContext context)
        {
            _context = context;
        }

        public IList<ActivityRecord> ActivityRecord { get;set; }

        public async Task OnGetAsync()
        {
            ActivityRecord = await _context.ActivityRecord.ToListAsync();
        }
    }
}
