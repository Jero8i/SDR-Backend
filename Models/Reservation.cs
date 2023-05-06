namespace BackEnd;

public class Reservation 
{
    public int? Id { get; set; } // Private? (get / set)
    public int? Id_Customer { get; set; }
    public int? Id_Service { get; set; }
    public int? Id_Day_Hour { get; set; } // Check property names.
    public int? Id_State { get; set; }
    public int? Number_Diners { get; set; }
    public String? Note { get; set; }
}