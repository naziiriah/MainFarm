using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MainFarm.Model;

namespace MainFarm.Data
{
    public class MainFarmContext : DbContext
    {
        public MainFarmContext (DbContextOptions<MainFarmContext> options)
            : base(options)
        {
        }

        public DbSet<MainFarm.Model.Inventory> Inventory { get; set; } = default!;
    }
}
