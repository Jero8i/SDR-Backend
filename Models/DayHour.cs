namespace BackEnd;

public class DayHour
{
    public int? Id { get; set; }
    public Day? IdDay { get; set; }
    public Hour? IdHour { get; set; }

    public DayHour(int Id, Day IdDay, Hour IdHour)
    {
        this.Id = Id;
        this.IdDay = IdDay;
        this.IdHour = IdHour;
    }
}
