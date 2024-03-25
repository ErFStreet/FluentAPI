namespace Domain.Entities;

public class Category : object
{
    public Category() : base()
    {
    }

    public int Id { get; set; }

    public required string CategoryName { get; set; }
}
