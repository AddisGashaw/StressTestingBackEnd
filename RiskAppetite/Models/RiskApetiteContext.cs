using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RiskAppetite.Models;

public partial class RiskApetiteContext : DbContext
{
    public RiskApetiteContext()
    {
    }

    public RiskApetiteContext(DbContextOptions<RiskApetiteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Credit> Credits { get; set; }

    public virtual DbSet<Liquidity> Liquidities { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<UserProfile> UserProfiles { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Credit>(entity =>
        {
            entity.ToTable("credit");

            entity.Property(e => e.Approvalstatus).HasColumnName("approvalstatus");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("approvedDate");
            entity.Property(e => e.ApproverUserId).HasColumnName("approverUserId");
            entity.Property(e => e.Param1)
                .HasMaxLength(250)
                .HasColumnName("param1");
            entity.Property(e => e.Param2)
                .HasMaxLength(250)
                .HasColumnName("param2");
            entity.Property(e => e.Param3)
                .HasMaxLength(250)
                .HasColumnName("param3");
            entity.Property(e => e.UploadedDate)
                .HasColumnType("datetime")
                .HasColumnName("uploadedDate");
            entity.Property(e => e.UploaderUserId).HasColumnName("uploaderUserId");

            entity.HasOne(d => d.ApproverUser).WithMany(p => p.CreditApproverUsers)
                .HasForeignKey(d => d.ApproverUserId)
                .HasConstraintName("FK_credit_UserProfile1");

            entity.HasOne(d => d.UploaderUser).WithMany(p => p.CreditUploaderUsers)
                .HasForeignKey(d => d.UploaderUserId)
                .HasConstraintName("FK_credit_UserProfile");
        });

        modelBuilder.Entity<Liquidity>(entity =>
        {
            entity.ToTable("liquidity");

            entity.Property(e => e.Param1)
                .HasMaxLength(150)
                .HasColumnName("param1");
            entity.Property(e => e.Param2)
                .HasMaxLength(150)
                .HasColumnName("param2");
            entity.Property(e => e.Param3)
                .HasMaxLength(150)
                .HasColumnName("param3");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Role");

            entity.Property(e => e.CreatedBy).HasMaxLength(150);
            entity.Property(e => e.Description).HasMaxLength(350);
            entity.Property(e => e.RoleName).HasMaxLength(250);
            entity.Property(e => e.UpdatedBy).HasMaxLength(150);
        });

        modelBuilder.Entity<UserProfile>(entity =>
        {
            entity.ToTable("UserProfile");

            entity.Property(e => e.EmployeeId).HasMaxLength(150);
            entity.Property(e => e.UserEmail).HasMaxLength(150);

            entity.HasOne(d => d.UserRole).WithMany(p => p.UserProfiles)
                .HasForeignKey(d => d.UserRoleId)
                .HasConstraintName("FK_UserProfile_Role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
