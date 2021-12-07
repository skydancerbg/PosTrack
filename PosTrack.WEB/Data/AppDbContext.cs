using Microsoft.EntityFrameworkCore;
using PosTrack.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PosTrack.Data
{
    public class AppDbContext : DbContext
    {
        //public DbSet<UserAudit> UserAuditEvents { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //public DbSet<Trolley> Trolleys { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            //modelBuilder.Entity<Trolley>()
            //.HasRequired(a => a.BillingAddress)
            //.WithMany()
            //.HasForeignKey(u => u.BillingAddressId);

            //modelBuilder.Entity<Trolley>()
            //    .HasOne
            //.HasRequired(a => a.BillingAddress)
            //.WithMany()
            //.HasForeignKey(u => u.BillingAddressId);

            //        modelBuilder.Entity<Tag>()
            //.HasOne(b => b.Trolley).WithMany(i => i.Tag)
            //.HasForeignKey<Trolley>(b => b.LeftTagId);


            //        modelBuilder.Entity<Blog>()
            //.HasOne(b => b.BlogImage)
            //.WithOne(i => i.Blog)
            //.HasForeignKey<BlogImage>(b => b.BlogForeignKey);


            //        modelBuilder.Entity<Tag>()
            //.HasOne(b => b.Trolley)
            //.WithOne(i => i.Tag)
            //.HasForeignKey<Trolley>(b => b.LeftTagId);

            //        modelBuilder.Entity<Tag>()
            //     .HasOne(b => b.Trolley)
            //     .WithOne(i => i.Tag)
            //     .HasForeignKey<Trolley>(b => b.RightTagId);


        }



        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Use Fluent API to configure  

        //    // Map entities to tables  
        //    modelBuilder.Entity<UserGroup>().ToTable("UserGroups");
        //    modelBuilder.Entity<User>().ToTable("Users");

        //    // Configure Primary Keys  
        //    modelBuilder.Entity<UserGroup>().HasKey(ug => ug.Id).HasName("PK_UserGroups");
        //    modelBuilder.Entity<User>().HasKey(u => u.Id).HasName("PK_Users");

        //    // Configure indexes  
        //    modelBuilder.Entity<UserGroup>().HasIndex(p => p.Name).IsUnique().HasDatabaseName("Idx_Name");
        //    modelBuilder.Entity<User>().HasIndex(u => u.FirstName).HasDatabaseName("Idx_FirstName");
        //    modelBuilder.Entity<User>().HasIndex(u => u.LastName).HasDatabaseName("Idx_LastName");

        //    // Configure columns  
        //    modelBuilder.Entity<UserGroup>().Property(ug => ug.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
        //    modelBuilder.Entity<UserGroup>().Property(ug => ug.Name).HasColumnType("nvarchar(100)").IsRequired();
        //    modelBuilder.Entity<UserGroup>().Property(ug => ug.CreationDateTime).HasColumnType("datetime").IsRequired();
        //    modelBuilder.Entity<UserGroup>().Property(ug => ug.LastUpdateDateTime).HasColumnType("datetime").IsRequired(false);

        //    modelBuilder.Entity<User>().Property(u => u.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
        //    modelBuilder.Entity<User>().Property(u => u.FirstName).HasColumnType("nvarchar(50)").IsRequired();
        //    modelBuilder.Entity<User>().Property(u => u.LastName).HasColumnType("nvarchar(50)").IsRequired();
        //    modelBuilder.Entity<User>().Property(u => u.UserGroupId).HasColumnType("int").IsRequired();
        //    modelBuilder.Entity<User>().Property(u => u.CreationDateTime).HasColumnType("datetime").IsRequired();
        //    modelBuilder.Entity<User>().Property(u => u.LastUpdateDateTime).HasColumnType("datetime").IsRequired(false);

        //    // Configure relationships  
        //    modelBuilder.Entity<User>().HasOne<UserGroup>().WithMany().HasPrincipalKey(ug => ug.Id).HasForeignKey(u => u.UserGroupId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Users_UserGroups");
        //}
    }
}
