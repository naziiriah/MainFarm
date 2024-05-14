using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MainFarm.Data;
using MainFarm.Model;

namespace MainFarm.Pages.FarmRecord
{
    public class DetailsModel : PageModel
    {
        private readonly MainFarm.Data.ApplicationDbContext _context;

        public DetailsModel(MainFarm.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Inventory Inventory { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventory = await _context.Inventory.FirstOrDefaultAsync(m => m.Guid == id);
            if (inventory == null)
            {
                return NotFound();
            }
            else
            {
                Inventory = inventory;
            }
            return Page();
        }
    }
}
