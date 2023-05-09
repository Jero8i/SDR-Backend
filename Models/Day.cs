namespace BackEnd;

public class Day
{
    public int? Id { get; set; }

    // Check property name.
    public string? Name { get; set; }

    public Day(int Id, string Name)
    {
        this.Id = Id;
        this.Name = Name;
    }
}
