namespace BackEnd;

public class Classification
{
    public int? Id { get; set; } // Check if id is needed.
    public string? Name { get; set; }

    public Classification(int Id, string Name)
    {
        this.Id = Id;
        this.Name = Name;
    }
}
