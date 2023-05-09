namespace BackEnd;

public class Hour
{
    public int? Id { get; set; }

    // Check TimeSpan.
    public TimeSpan? Time { get; set; }

    public Hour(int Id, TimeSpan Time)
    {
        this.Id = Id;
        this.Time = Time;
    }
}
