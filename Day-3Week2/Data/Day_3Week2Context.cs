using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Day_3Week2.Models;

namespace Day_3Week2.Data
{
    public class Day_3Week2Context : DbContext
    {
        public Day_3Week2Context (DbContextOptions<Day_3Week2Context> options)
            : base(options)
        {
        }

        public DbSet<Day_3Week2.Models.Product> Product { get; set; } = default!;
    }
}
