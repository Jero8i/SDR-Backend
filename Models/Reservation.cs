namespace BackEnd;

public class Reservation
{
    public int? Id { get; set; }
    public Customer? IdCustomer { get; set; }
    public Service? IdService { get; set; }

    // Check property name.
    public DayHour? IdDayHour { get; set; }
    public State? IdState { get; set; }
    public int? NumberDiners { get; set; }
    public string? Note { get; set; }

    public Reservation(int Id, Customer IdCustomer, Service IdService, DayHour IdDayHour, State IdState, int NumberDiners, string Note)
    {
        this.Id = Id;
        this.IdCustomer = IdCustomer;
        this.IdService = IdService;
        this.IdDayHour = IdDayHour;
        this.IdState = IdState;
        this.NumberDiners = NumberDiners;
        this.Note = Note;
    }
}