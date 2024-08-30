namespace CodeFirst.Entities;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname{ get; set; }
    public int SchoolNumber { get; set; }
    public Gender Gender { get; set; }
    public DateTime Birthday { get; set; }
    public string PhoneNumber { get; set; }
    public ICollection<Book> Books { get; set; }
}
