namespace BackEnd;

public class Hour
{
    // Named the property "hour" instead of "Hour" because I can't repeat the class name.
    public int? hour { get; set; }

    public int? minute { get; set; }

    public Hour(int hour, int minute)
    {
        this.hour = hour;
        this.minute = minute;
    }

    public override string ToString()
    {
        return $"{hour:D2}:{minute:D2}";
    }
}
