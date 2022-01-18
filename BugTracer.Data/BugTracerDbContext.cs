using BugTracer.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BugTracer.Data
{
    public class BugTracerDbContext : DbContext
    {
        public BugTracerDbContext(DbContextOptions<BugTracerDbContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<ResourceRole>  ResourceRoles { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketPriority> TicketPriorities { get; set; }
        public DbSet<TicketStatus> TicketStatuses { get; set; }
    }
}
