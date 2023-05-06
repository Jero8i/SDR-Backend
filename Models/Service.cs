namespace BackEnd;

public class Service
{
    public string? Name { get; set; }
    public DateTime? Start_Date { get; set; }
    public DateTime? End_Date { get; set; }
    public bool? IsActive { get; set; }
    public int? Max_People { get; set; }
    public Day_Hour? Day_Hour { get; set; }

    public Service(string Name, DateTime Start_Date, DateTime End_Date, bool IsActive, int Max_People, Day_Hour Day_Hour) {
        this.Name = Name;
        this.Start_Date = Start_Date;
        this.End_Date = End_Date;
        this.IsActive = IsActive;
        this.Max_People = Max_People;
        this.Day_Hour = Day_Hour;
    }
}
