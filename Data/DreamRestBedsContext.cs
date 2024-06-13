using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DreamRestBeds.Models;

namespace DreamRestBeds.Data
{
    public class DreamRestBedsContext : DbContext
    {
        public DreamRestBedsContext (DbContextOptions<DreamRestBedsContext> options)
            : base(options)
        {
        }

        public DbSet<DreamRestBeds.Models.Bads> Bads { get; set; } = default!;
    }
}
