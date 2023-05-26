namespace BackEnd;

public class ServiceMocks
{
    public List<Hour> DayTime { get; set; }
    public List<Hour> NightTime { get; set; }
    public Schedule DaySchedule { get; set; }
    public Schedule NightSchedule { get; set; }
    public List<Service> AvailableServices { get; set; }

    public ServiceMocks()
    {
        this.DayTime = new List<Hour>()
        {
            new Hour(13, 00),
            new Hour(13, 30),
            new Hour(14, 00),
            new Hour(14, 30),
            new Hour(15, 00),
            new Hour(15, 30),
            new Hour(16, 00),

        };

        this.NightTime = new List<Hour>()
        {
            new Hour(19, 00),
            new Hour(19, 30),
            new Hour(20, 00),
            new Hour(20, 30),
            new Hour(21, 00),
            new Hour(21, 30),
            new Hour(22, 00),
        };

        this.DaySchedule = new Schedule();
        DaySchedule.AddSchedule(DayOfWeek.Sabado, DayTime);
        DaySchedule.AddSchedule(DayOfWeek.Domingo, DayTime);

        this.NightSchedule = new Schedule();
        NightSchedule.AddSchedule(DayOfWeek.Viernes, NightTime);
        NightSchedule.AddSchedule(DayOfWeek.Sabado, NightTime);
        NightSchedule.AddSchedule(DayOfWeek.Domingo, NightTime);

        Service Visita_Guiada = new Service(
            "Visita Guiada",
            new DateTime(2023, 1, 1),
            new DateTime(2023, 12, 1),
            true,
            5,
            DaySchedule
        );

        Service Visita_Guiada_Almuerzo = new Service(
            "Visita Guiada con Almuerzo",
            new DateTime(2023, 1, 1),
            new DateTime(2023, 12, 1),
            true,
            5,
            DaySchedule
        );

        Service Almuerzo = new Service(
           "Almuerzo",
           new DateTime(2023, 3, 1),
           new DateTime(2023, 9, 1),
           true,
           8,
           DaySchedule
        );

        Service Cena = new Service(
           "Cena",
           new DateTime(2023, 9, 1),
           new DateTime(2023, 3, 1),
           false,
           8,
           NightSchedule
        );

        this.AvailableServices = new List<Service>(){
            Visita_Guiada,
            Visita_Guiada_Almuerzo,
            Almuerzo,
            Cena
        };
    }
}