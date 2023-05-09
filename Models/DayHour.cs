namespace BackEnd;

public class DayHour
{
    public int? Id { get; set; }
    public int? IdDay { get; set; }
    public int? IdHour { get; set; }

    public DayHour(int Id, int IdDay, int IdHour)
    {
        this.Id = Id;
        this.IdDay = IdDay;
        this.IdHour = IdHour;
    }
}
