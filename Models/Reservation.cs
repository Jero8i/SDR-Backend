namespace BackEnd;

public class Reservation
{
    public int? Id { get; set; } // Check if id is needed.
    public Customer? Customer { get; set; }
    public Service? Service { get; set; }
    public Schedule? Schedule { get; set; }
    public State? State { get; set; }
    public int? NumberDiners { get; set; }
    public string? Note { get; set; }

    public Reservation(int Id, Customer Customer, Service Service, Schedule Schedule, State State, int NumberDiners, string Note)
    {
        this.Id = Id;
        this.Customer = Customer;
        this.Service = Service;
        this.Schedule = Schedule;
        this.State = State;
        this.NumberDiners = NumberDiners;
        this.Note = Note;
    }
}