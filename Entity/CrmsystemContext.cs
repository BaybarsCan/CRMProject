﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Entity
{
    public partial class CrmsystemContext : DbContext
    {
        public CrmsystemContext()
        {
        }

        public CrmsystemContext(DbContextOptions<CrmsystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Customer_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}