namespace CodeFirst.Entities;

public enum Gender:int
{
    Male = 1,
    Female = 2
}
public class GenderEnum
{
    public int Id { get; set; }
    public Gender GenderType { get; set; }
}