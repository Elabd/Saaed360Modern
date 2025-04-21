using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Infrastructure.Persistence.Entities.Auth;

namespace Infrastructure.Persistence.Contexts
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<aspnet_Membership> aspnet_Membership { get; set; }
        public virtual DbSet<aspnet_Role> aspnet_Role { get; set; }
        public virtual DbSet<aspnet_User> aspnet_User { get; set; }
        public virtual DbSet<aspnet_UsersInRole> aspnet_UsersInRole { get; set; }
        public virtual DbSet<OrganizationPerson> OrganizationPerson { get; set; }
        public virtual DbSet<PersonArea> PersonArea { get; set; }
        public virtual DbSet<PersonAspnetUser> PersonAspnetUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Connection string will be provided through configuration
                optionsBuilder.UseSqlServer();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<aspnet_Membership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_M__1788CC4D1B81B621");

                entity.ToTable("aspnet_Membership");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobilePIN).HasMaxLength(16);

                entity.Property(e => e.Password).HasMaxLength(128);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.PasswordSalt).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithOne(p => p.aspnet_Membership)
                    .HasForeignKey<aspnet_Membership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__UserI__7B71F792");
            });

            modelBuilder.Entity<aspnet_Role>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__aspnet_R__8AFACE1A1B81B621");

                entity.ToTable("aspnet_Roles");

                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName).HasMaxLength(256);

                entity.Property(e => e.RoleName).HasMaxLength(256);
            });

            modelBuilder.Entity<aspnet_User>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_U__1788CC4D1B81B621");

                entity.ToTable("aspnet_Users");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<aspnet_UsersInRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK__aspnet_U__AF2760AD1B81B621");

                entity.ToTable("aspnet_UsersInRoles");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.aspnet_UsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__RoleI__7B71F792");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.aspnet_UsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__UserI__7B71F792");
            });

            modelBuilder.Entity<OrganizationPerson>(entity =>
            {
                entity.ToTable("OrganizationPerson");

                entity.Property(e => e.OrganizationPersonId).HasColumnName("OrganizationPersonId");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreateDateTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDateTimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<PersonArea>(entity =>
            {
                entity.ToTable("PersonArea");

                entity.Property(e => e.personAreaId).HasColumnName("personAreaId");
            });

            modelBuilder.Entity<PersonAspnetUser>(entity =>
            {
                entity.ToTable("PersonAspnetUser");

                entity.Property(e => e.ID).HasColumnName("ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PersonAspnetUsers)
                    .HasForeignKey(d => d.UserID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonAspnetUser_aspnet_Users");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
