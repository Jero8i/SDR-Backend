namespace BackEnd;

public class Schedule
{
    public Dictionary<DayOfWeek, List<ScheduleTime>> schedule { get; set;}

    public Schedule()
    {
        schedule = new Dictionary<DayOfWeek, List<ScheduleTime>>();
    }

    public void AddSchedule(DayOfWeek DayOfWeek, List<ScheduleTime> scheduleTimes)
    {
        schedule[DayOfWeek] = scheduleTimes;
    }
    
    public List<ScheduleTime> GetSchedule(DayOfWeek DayOfWeek)
    {
        return schedule[DayOfWeek];
    }
}
