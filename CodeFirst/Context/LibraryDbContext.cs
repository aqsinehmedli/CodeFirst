using CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Context;

public class LibraryDbContext:DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookType> BookTypes { get; set; }
    public DbSet<GenderEnum> Gender { get; set; }
    public DbSet<Operation> Operations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-0MV3INK;Initial Catalog = LibraryCodeFirst;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>()
            .HasMany(s=>s.Books)
            .WithMany(b=>b.Students)
            .UsingEntity<Dictionary<string, object>>(
                "StudentBook",
                j => j.HasOne<Book>().WithMany().HasForeignKey("BookId"), // BookId foreign key
                j => j.HasOne<Student>().WithMany().HasForeignKey("StudentId") // StudentId foreign key
            );
        modelBuilder.Entity<Author>()
           .HasMany(a => a.Books)
           .WithOne(b => b.Author)
           .HasForeignKey(b => b.AuthorId);
        modelBuilder.Entity<BookType>()
            .HasMany(bt => bt.Books)
            .WithOne(b => b.BookType)
            .HasForeignKey(b => b.BookTypeId);

        base.OnModelCreating(modelBuilder);

       
    }
}
