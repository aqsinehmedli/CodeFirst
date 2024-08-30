namespace CodeFirst.Entities;

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    //Foreign key
    public ICollection<Book> Books { get; set; }
}
