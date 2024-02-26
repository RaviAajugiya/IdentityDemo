using System;
using System.Collections.Generic;
using IdentityDemo.TempModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityDemo.Models;

public partial class IdentityDemoContext : IdentityDbContext<ApplicationUser>
{
    public IdentityDemoContext()
    {
    }

    public IdentityDemoContext(DbContextOptions<IdentityDemoContext> options)
        : base(options)
    {
    }


    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeDemo> EmployeeDemos { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<AspNetUserLogin>()
            .HasKey(l => new { l.LoginProvider, l.ProviderKey });

        modelBuilder.Entity<AspNetUserToken>()
            .HasKey(t => new { t.UserId, t.LoginProvider, t.Name });

        modelBuilder.Entity<EmployeeDemo>()
           .HasKey(t => new { t.EmployeeId });
    }

}
