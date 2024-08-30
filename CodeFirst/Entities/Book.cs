namespace CodeFirst.Entities;

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int PageCount { get; set; }

    //Foreign key
    public ICollection<Student> Students { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; }

    public int BookTypeId { get; set; }
    public BookType BookType { get; set; }
}
