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
    public class IndexModel : PageModel
    {
        private readonly MainFarm.Data.ApplicationDbContext _context;

        public IndexModel(MainFarm.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Inventory> Inventory { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Inventory = await _context.Inventory.ToListAsync();
        }
    }
}
