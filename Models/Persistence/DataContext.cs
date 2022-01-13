using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Deep_Patel_Backend_Challenge.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Deep_Patel_Backend_Challenge.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<DeletedInventory> DeletedInventories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName=InventoryDatabase.db");
        }
    }
}