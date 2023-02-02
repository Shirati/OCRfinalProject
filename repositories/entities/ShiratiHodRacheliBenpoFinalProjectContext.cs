using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


namespace repositories.entities;

public partial class ShiratiHodRacheliBenpoFinalProjectContext : DbContext, IContext
{
    public ShiratiHodRacheliBenpoFinalProjectContext()
    {
    }

    public ShiratiHodRacheliBenpoFinalProjectContext(DbContextOptions<ShiratiHodRacheliBenpoFinalProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Action> Actions { get; set; }

    public virtual DbSet<ActionType> ActionTypes { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<Picture> Pictures { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=sqlsrv;Initial Catalog=\"----------------------- shiratiHodRacheliBenpoFinalProject\";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Action>(entity =>
        {
            entity.Property(e => e.ActionId).HasColumnName("actionId");
            entity.Property(e => e.ActionTypeId).HasColumnName("actionTypeId");
            entity.Property(e => e.IsSucceeded).HasColumnName("isSucceeded");
            entity.Property(e => e.PaymentId).HasColumnName("paymentID");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.ActionType).WithMany(p => p.Actions)
                .HasForeignKey(d => d.ActionTypeId)
                .HasConstraintName("FK_Actions_ActionType");

            entity.HasOne(d => d.User).WithMany(p => p.Actions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Actions_Users");
        });

        modelBuilder.Entity<ActionType>(entity =>
        {
            entity.HasKey(e => e.ActionTypeId).HasName("PK_Action");

            entity.ToTable("ActionType");

            entity.Property(e => e.ActionTypeId).HasColumnName("actionTypeId");
            entity.Property(e => e.ActionTypeName)
                .HasMaxLength(20)
                .HasColumnName("actionTypeName");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.ToTable("Permission");

            entity.Property(e => e.PremissionName).HasMaxLength(30);
        });

        modelBuilder.Entity<Picture>(entity =>
        {
            entity.ToTable("Picture");

            entity.Property(e => e.PictureId).HasColumnName("pictureId");
            entity.Property(e => e.ActionId).HasColumnName("actionId");
            entity.Property(e => e.ResultFileUrl)
                .HasMaxLength(200)
                .HasColumnName("resultFileUrl");
            entity.Property(e => e.SourceFileUrl)
                .HasMaxLength(200)
                .HasColumnName("sourceFileUrl");

            entity.HasOne(d => d.Action).WithMany(p => p.Pictures)
                .HasForeignKey(d => d.ActionId)
                .HasConstraintName("FK_Picture_Actions");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.AccountId).HasColumnName("accountId");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .HasColumnName("firstName");
            entity.Property(e => e.Ip)
                .HasMaxLength(30)
                .HasColumnName("IP");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .HasColumnName("lastName");
            entity.Property(e => e.NumFreeTries).HasColumnName("numFreeTries");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .HasColumnName("password");
            entity.Property(e => e.PermissionId).HasColumnName("permissionId");

            entity.HasOne(d => d.Permission).WithMany(p => p.Users)
                .HasForeignKey(d => d.PermissionId)
                .HasConstraintName("FK_Users_Permission");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
