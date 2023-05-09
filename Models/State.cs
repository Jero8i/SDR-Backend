namespace BackEnd;

public class State
{
    public int? Id { get; set; }
    public string? Name { get; set; }

    public State(int Id, string Name)
    {
        this.Id = Id;
        this.Name = Name;
    }
}