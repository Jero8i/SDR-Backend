namespace BackEnd;

public class Classification
{
    public int? Id { get; set; }
    public string? Name { get; set; }

    public Classification(int Id, string Name)
    {
        this.Id = Id;
        this.Name = Name;
    }
}