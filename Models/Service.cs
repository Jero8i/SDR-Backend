namespace BackEnd;

public class Service
{
    public string? Name { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool? IsActive { get; set; }
    public int? MaxPeople { get; set; }
    public Schedule? Schedule { get; set; }

    public Service(string Name, DateTime StartDate, DateTime EndDate, bool IsActive, int MaxPeople, Schedule Schedule)
    {
        this.Name = Name;
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.IsActive = IsActive;
        this.MaxPeople = MaxPeople;
        this.Schedule = Schedule;
    }
}
