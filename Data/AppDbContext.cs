using Microsoft.EntityFrameworkCore;
using TemplateForT2.Models;

namespace PrepT2.Data;

public class AppDbContext : DbContext
{
    public DbSet<Registrations> Registrations { get; set; } = null!;
    public DbSet<Events> Events { get; set; } = null!;
    public DbSet<Venues> Venues { get; set; } = null!;
    public DbSet<VenueDetails> VenueDetails { get; set; } = null!;
    public DbSet<Attendees> Attendees { get; set; } = null!;

    public AppDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Attendees>().HasKey(a => a.Id);
        modelBuilder.Entity<Events>().HasKey(e => e.Id);
        modelBuilder.Entity<Venues>().HasKey(v => v.Id);
        modelBuilder.Entity<VenueDetails>().HasKey(vd => 
            new {vd.VenueId});
        modelBuilder.Entity<Registrations>().HasKey(at => 
            new {at.EventId, at.AttendeeId});
    }
}