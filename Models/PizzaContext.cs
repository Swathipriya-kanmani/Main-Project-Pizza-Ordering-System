using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PizzaProject.Models
{
    public partial class PizzaContext : DbContext
    {
        public PizzaContext()
        {
        }

        public PizzaContext(DbContextOptions<PizzaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<OrderTab> OrderTabs { get; set; } = null!;
        public virtual DbSet<PaymentTab> PaymentTabs { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-M4928R4;Database=Pizza;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created Date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderTab>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("OrderTab");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.OrderDateTime).HasColumnType("datetime");

                entity.Property(e => e.PizzaId).HasColumnName("PizzaID");

                entity.Property(e => e.Prize).HasColumnType("money");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Pizza)
                    .WithMany(p => p.OrderTabs)
                    .HasForeignKey(d => d.PizzaId)
                    .HasConstraintName("FK_OrderTab_Product");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrderTabs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_OrderTab_Users");
            });

            modelBuilder.Entity<PaymentTab>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PaymentTab");

                entity.Property(e => e.CreditCardNumber)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Credit Card Number");

                entity.Property(e => e.Cvv).HasColumnName("CVV");

                entity.Property(e => e.ExpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Exp Date");

                entity.Property(e => e.NameOnCard)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Name On Card");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.PizzaId);

                entity.ToTable("Product");

                entity.Property(e => e.PizzaId).HasColumnName("PizzaID");

                entity.Property(e => e.NoOfPizzas).HasColumnName("No.Of Pizzas");

                entity.Property(e => e.NoOfSlices).HasColumnName("No.Of Slices");

                entity.Property(e => e.PizzaCrust)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pizza Crust");

                entity.Property(e => e.PizzaName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pizza Name");

                entity.Property(e => e.Prize).HasColumnType("money");

                entity.Property(e => e.Toppings)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
