namespace CodeFirst.Entities;

public class BookType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Book> Books { get; set; }                       
}
