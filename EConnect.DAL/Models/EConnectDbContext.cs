using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EConnect.DAL.Models;

public partial class EConnectDbContext : DbContext
{
    public EConnectDbContext()
    {
        //Scaffold-DbContext "Server=DESKTOP-DDGFN4K\SQL2022;Database=EConnect;User Id=sa;Password=sql2022;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context "EConnectDbContext" -DataAnnotations
    }

    public EConnectDbContext(DbContextOptions<EConnectDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<Property> Properties { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-DDGFN4K\\SQL2022;Database=EConnect;User Id=sa;Password=sql2022;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => new { e.PropertyId, e.ContactId }).HasName("PK_Contact_Pid_CId");

            entity.Property(e => e.ContactId).ValueGeneratedOnAdd();
            entity.Property(e => e.IsProcessed)
                .HasDefaultValue("INC")
                .IsFixedLength();
            entity.Property(e => e.Status).IsFixedLength();

            entity.HasOne(d => d.Property).WithMany(p => p.Contacts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contact_Property");
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.HasKey(e => new { e.LoginId, e.PropertyId }).HasName("PK_Login_LoginID_PropertID");

            entity.Property(e => e.LoginId).ValueGeneratedOnAdd();
            entity.Property(e => e.IsProcessed)
                .HasDefaultValue("INC")
                .IsFixedLength();

            entity.HasOne(d => d.Property).WithMany(p => p.Logins)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Login_Property");
        });

        modelBuilder.Entity<Property>(entity =>
        {
            entity.HasKey(e => e.PropertyId).HasName("pk_Property_PropertyID");

            entity.Property(e => e.IsProcessed).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
