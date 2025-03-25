using BoekenBeheerApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekenBeheerApp.Services.Db
{
    public class BoekenDbContext : DbContext
    {
        public DbSet<Boek> boeks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseInMemoryDatabase(nameof(BoekenDbContext));

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //  => optionsBuilder.UseSqlServer("Data Source=ARNOH\\VIVES;Initial Catalog=BoekenBeheerApp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"));
    }
}
