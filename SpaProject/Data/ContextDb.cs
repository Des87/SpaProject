using Microsoft.EntityFrameworkCore;
using SpaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaProject.Data
{
    public class ContextDb : DbContext
    {
        public ContextDb()
        {
            Database.EnsureCreated();
        }

        public DbSet<CustomersTrack> CustomersTrack { get; set; }
        public DbSet<Sauna> Sauna { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=database.db");
           
            base.OnConfiguring(optionsBuilder);

        }
    }
}
