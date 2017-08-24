using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NetCoreUseSQL.Models
{
    public partial class MallContext : DbContext
    {
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Captcha> Captcha { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Option> Option { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<Publisher> Publisher { get; set; }
        public virtual DbSet<SensitiveWord> SensitiveWord { get; set; }
        public virtual DbSet<User> User { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=Mall;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasIndex(e => e.Isbn)
                    .HasName("IX_Books_ISBN")
                    .IsUnique();

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Isbn)
                    .IsRequired()
                    .HasColumnName("ISBN")
                    .HasMaxLength(50);

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Toc).HasColumnName("TOC");

                entity.Property(e => e.UnitPrice).HasColumnType("money");
            });

            modelBuilder.Entity<Captcha>(entity =>
            {
                entity.Property(e => e.Expired).HasColumnType("datetime");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_Categories_Name")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.Created).HasColumnType("datetime");
            });

            modelBuilder.Entity<Option>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasMaxLength(50);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.PostAddress).HasMaxLength(255);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("OrderID")
                    .HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal");
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_Publishers_Name")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<SensitiveWord>(entity =>
            {
                entity.Property(e => e.Original)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Replace)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("IX_Users_Mail");

                entity.HasIndex(e => e.Login)
                    .HasName("IX_Users_LoginId")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nickname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}