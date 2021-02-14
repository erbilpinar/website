using Microsoft.EntityFrameworkCore;
using MMS.Models;

namespace MMS.Data
{
    public class SoftwareContext : DbContext
    {
        public SoftwareContext (DbContextOptions<SoftwareContext> options)
            : base(options)
        {
        }

        public DbSet<Software> Software { get; set; }
    }
}