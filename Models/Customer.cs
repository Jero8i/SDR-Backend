namespace BackEnd;

public class Customer
{
    public int? Id { get; set; } // Check if id is needed.
    public string? Name { get; set; }
    public string? Lastname { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public Classification? Classification { get; set; }

    public Customer(int Id, string Name, string Lastname, string Email, string PhoneNumber, Classification Classification)
    {
        this.Id = Id;
        this.Name = Name;
        this.Lastname = Lastname;
        this.Email = Email;
        this.PhoneNumber = PhoneNumber;
        this.Classification = Classification;
    }
}
