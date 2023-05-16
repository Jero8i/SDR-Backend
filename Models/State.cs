namespace BackEnd;

public class State
{
    public int? Id { get; set; } // Check if id is needed.
    public string? Name { get; set; }

    public State(int Id, string Name)
    {
        this.Id = Id;
        this.Name = Name;
    }
}