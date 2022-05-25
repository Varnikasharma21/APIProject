using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AssignmentConnect.Models
{
    public partial class BOOKSContext : DbContext
    {
        public BOOKSContext()
        {
        }

        public BOOKSContext(DbContextOptions<BOOKSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Details> Details { get; set; }

        // Unable to generate entity type for table 'dbo.Table_1Sample'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=BOOKS;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Details>(entity =>
            {
                entity.HasKey(e => e.BookId);

                entity.HasIndex(e => e.BookCode)
                    .HasName("UQ__Details__BC2BA8A62F5512F6")
                    .IsUnique();

                entity.Property(e => e.BookId).HasColumnName("Book_id");

                entity.Property(e => e.BookAuthor)
                    .HasColumnName("Book_Author")
                    .HasMaxLength(30);

                entity.Property(e => e.BookCode).HasColumnName("Book_code");

                entity.Property(e => e.BookName)
                    .HasColumnName("Book_name")
                    .HasMaxLength(60);

                entity.Property(e => e.BookPrice)
                    .HasColumnName("Book_price")
                    .HasMaxLength(10);

                entity.Property(e => e.BookSeller)
                    .HasColumnName("Book_seller")
                    .HasMaxLength(30);

                entity.Property(e => e.TotalPages).HasColumnName("Total_pages");
            });
        }
    }
}
