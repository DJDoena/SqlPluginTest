using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseLayer.Models;

public partial class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Table> Tables { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Table__3214EC0748092B7D");

            entity.ToTable("Table");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.SomeText).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
