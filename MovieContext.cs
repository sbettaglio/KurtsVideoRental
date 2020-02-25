using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KurtsVideoRental
{
  public partial class MovieContext : DbContext
  {
    public DbSet<Movie> Movies { get; set; }
    public MovieContext()
    {

    }

    public MovieContext(DbContextOptions<MovieContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {

        optionsBuilder.UseNpgsql("server=localhost;database=MovieDb");
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
  }
}
