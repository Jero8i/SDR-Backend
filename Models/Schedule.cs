namespace BackEnd;

public class Schedule
{
    // Changed the access modifier, otherwise the response is not displayed in JSON.
    public Dictionary<DayOfWeek, List<Hour>> schedule { get; set;}

    public Schedule()
    {
        schedule = new Dictionary<DayOfWeek, List<Hour>>();
    }

    public void AddSchedule(DayOfWeek dayOfWeek, List<Hour> hours)
    {
        schedule[dayOfWeek] = hours;
    }
    
    public List<Hour> GetSchedule(DayOfWeek dayOfWeek)
    {
        return schedule[dayOfWeek];
    }
}
