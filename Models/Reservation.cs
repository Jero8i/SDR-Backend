namespace BackEnd;

public class Reservation
{
    public int? Id { get; set; }
    public int? IdCustomer { get; set; }
    public int? IdService { get; set; }

    // Check property name.
    public int? IdDayHour { get; set; }
    public int? IdState { get; set; }
    public int? NumberDiners { get; set; }
    public string? Note { get; set; }

    public Reservation(int Id, int IdCustomer, int IdService, int IdDayHour, int IdState, int NumberDiners, string Note)
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