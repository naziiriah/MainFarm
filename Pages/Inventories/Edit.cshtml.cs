﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MainFarm.Data;
using MainFarm.Model;

namespace MainFarm.Pages.Inventories
{
    public class EditModel : PageModel
    {
        private readonly MainFarm.Data.MainFarmContext _context;

        public EditModel(MainFarm.Data.MainFarmContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Inventory Inventory { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventory =  await _context.Inventory.FirstOrDefaultAsync(m => m.Guid == id);
            if (inventory == null)
            {
                return NotFound();
            }
            Inventory = inventory;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Inventory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InventoryExists(Inventory.Guid))
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

        private bool InventoryExists(Guid id)
        {
            return _context.Inventory.Any(e => e.Guid == id);
        }
    }
}
