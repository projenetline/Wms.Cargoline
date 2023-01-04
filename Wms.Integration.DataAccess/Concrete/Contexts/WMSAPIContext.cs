using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wms.Integration.Core.Entities.Concrete;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.DataAccess.Concrete.Contexts
{
    public partial class WMSAPIContext : DbContext
    {
        public WMSAPIContext()
        {
        }
        public WMSAPIContext(DbContextOptions<WMSAPIContext> options)
            : base(options)
        {
        }
        public virtual DbSet<OperationClaim> OperationClaims { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public virtual DbSet<LabelHeader> LabelHeaders { get; set; }
        public virtual DbSet<LabelBody> LabelBodies { get; set; }

        public virtual DbSet<HttpLogger> HttpLoggers { get; set; }
        public virtual DbSet<Logger> Loggers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=192.168.7.252;Database=WMSAPI;user id=sa;password=net_123");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Logger>(entity =>
            {
                entity.ToTable("Logger");
                entity.Property(s => s.Id)
                      .IsRequired()
                      .HasColumnType(SqlDbType.UniqueIdentifier.ToString());
                entity.HasKey(s => s.Id);
                entity.Property(s => s.MethodName)
                      .HasColumnType(SqlDbType.NVarChar.ToString())
                      .HasMaxLength(250);
                entity.Property(s => s.CreatedDate)
                      .IsRequired()
                      .HasColumnType(SqlDbType.DateTime.ToString());
                entity.Property(s => s.ProjectName)
                      .HasColumnType(SqlDbType.NVarChar.ToString())
                      .HasMaxLength(250);
                entity.Property(s => s.Message1)
                 .HasColumnType(SqlDbType.NVarChar.ToString())
                 .HasMaxLength(250);
                entity.Property(s => s.Message2)
                 .HasColumnType(SqlDbType.NVarChar.ToString())
                 .HasMaxLength(250);
                entity.Property(s => s.Statu)
                 .HasColumnType(SqlDbType.NVarChar.ToString())
                 .HasMaxLength(250);
            });

            modelBuilder.Entity<LabelHeader>(entity =>
            {
                entity.ToTable("LabelHeader");
                entity.Property(s => s.Id)
               .IsRequired()
               .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

                entity.HasKey(s => s.Id);
            });
            modelBuilder.Entity<LabelBody>(entity =>
            {
                entity.ToTable("LabelBody");
                entity.Property(s => s.Id)
               .IsRequired()
               .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

                entity.HasKey(s => s.Id);
            });
            modelBuilder.Entity<HttpLogger>(entity =>
            {
                entity.ToTable("HttpLogger");
                entity.Property(s => s.Id)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

                entity.Property(s => s.FullUrl)
                .HasColumnType(SqlDbType.NVarChar.ToString() + "(max)");
                entity.Property(s => s.Body)
                       .HasColumnType(SqlDbType.NVarChar.ToString() + "(max)");
                entity.Property(s => s.LocalIp)
                       .HasColumnType(SqlDbType.NVarChar.ToString() + "(max)");
                entity.Property(s => s.RemoteIp)
                       .HasColumnType(SqlDbType.NVarChar.ToString() + "(max)");
                entity.Property(s => s.LocalPort)
                       .HasColumnType(SqlDbType.Int.ToString());
                entity.Property(s => s.RemotePort)
                        .HasColumnType(SqlDbType.Int.ToString());
                entity.Property(s => s.ResponseStatu)
                        .HasColumnType(SqlDbType.Int.ToString());
                entity.Property(s => s.Response)
                      .HasColumnType(SqlDbType.NVarChar.ToString() + "(max)");

                entity.HasKey(s => s.Id);
            });
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");
                entity.Property(s => s.Status)
                      .HasColumnType(SqlDbType.Bit.ToString());

                entity.Property(s => s.FirstName)
                      .HasColumnType(SqlDbType.NVarChar.ToString());

                entity.Property(s => s.UserName)
                      .HasColumnType(SqlDbType.NVarChar.ToString());

                entity.Property(s => s.LastName)
                      .HasColumnType(SqlDbType.NVarChar.ToString());

                entity.Property(s => s.Id)
                      .HasColumnType(SqlDbType.Int.ToString());

                entity.Property(s => s.PasswordSalt)
                      .HasColumnType(SqlDbType.VarBinary.ToString());

                entity.Property(s => s.PasswordHash)
                     .HasColumnType(SqlDbType.VarBinary.ToString());

                entity.HasKey(s => s.Id);
            });

            modelBuilder.Entity<OperationClaim>(entity =>
            {
                entity.ToTable("OperationClaims");

                entity.Property(s => s.Id)
                    .HasColumnType(SqlDbType.Int.ToString());

                entity.HasKey(s => s.Id);

                entity.Property(s => s.Name)
                      .HasColumnType(SqlDbType.NVarChar.ToString());
            });

            modelBuilder.Entity<UserOperationClaim>(entity =>
            {
                entity.ToTable("UserOperationClaims");

                entity.Property(s => s.Id)
                      .HasColumnType(SqlDbType.Int.ToString());

                entity.Property(s => s.UserId)
                      .HasColumnType(SqlDbType.Int.ToString());

                entity.Property(s => s.OperationClaimId)
                      .HasColumnType(SqlDbType.Int.ToString());

                entity.HasOne(s => s.User)
                      .WithMany(s => s.OperationClaims)
                      .HasForeignKey(s => s.UserId);

                entity.HasOne(s => s.OperationClaim)
                      .WithMany(s => s.UserOperationClaims)
                      .HasForeignKey(s => s.OperationClaimId);
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
