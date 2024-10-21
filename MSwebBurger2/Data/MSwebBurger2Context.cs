using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MSwebBurger2.Models;

namespace MSwebBurger2.Data
{
    public class MSwebBurger2Context : DbContext
    {
        public MSwebBurger2Context (DbContextOptions<MSwebBurger2Context> options)
            : base(options)
        {
        }

        public DbSet<MSwebBurger2.Models.Burger> Burger { get; set; } = default!;
        public DbSet<MSwebBurger2.Models.Promo> Promo { get; set; } = default!;
    }
}
