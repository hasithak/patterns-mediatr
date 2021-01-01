using Microsoft.EntityFrameworkCore;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class AppDbContext : DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
        { }
    }
}
