using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers;

[ApiController]
[Route("[controller]")]
public class ServicesController : ControllerBase
{

    public static List<Day> Days = new List<Day>() 
    { 
        new Day(1, "Jueves"), 
        new Day(2, "Viernes"), 
        new Day(3, "Sábado"),
        new Day(4, "Domingo") 
    };
    
    public static List<Hour> Hours = new List<Hour>()
    {
        // Day time:
        new Hour(1, new TimeSpan(13, 0, 0)),
        new Hour(2, new TimeSpan(14, 0, 0)),
        new Hour(3, new TimeSpan(15, 0, 0)),
        new Hour(4, new TimeSpan(16, 0, 0)),
        new Hour(5, new TimeSpan(17, 0, 0)),

        // Night time:
        new Hour(6, new TimeSpan(19, 0, 0)),
        new Hour(7, new TimeSpan(20, 0, 0)),
        new Hour(8, new TimeSpan(21, 0, 0)),
        new Hour(9, new TimeSpan(22, 0, 0))
    };

    public Service Visita_Guiada = new Service(
        "Visita Guiada",
        new DateTime(2023, 1, 1),
        new DateTime(2023, 12, 1),
        true,
        5,
        new DayHour(1, Days[2], Hours[0])
    );

    public Service Visita_Guiada_Almuerzo = new Service(
        "Visita Guiada con Almuerzo",
        new DateTime(2023, 1, 1),
        new DateTime(2023, 12, 1),
        true,
        5,
        new DayHour(2, Days[2], Hours[0])
    );

    public Service Almuerzo = new Service(
        "Almuerzo",
        new DateTime(2023, 3, 1),
        new DateTime(2023, 9, 1),
        true,
        8,
        new DayHour(3, Days[2], Hours[0])
    );

    public Service Cena = new Service(
        "Cena",
        new DateTime(2023, 9, 1),
        new DateTime(2023, 3, 1),
        true,
        8,
        new DayHour(4, Days[2], Hours[5])
    );

    private readonly ILogger<ServicesController> _logger;

    public ServicesController(ILogger<ServicesController> logger)
    {
        _logger = logger;
    }

    [EnableCors("_myAllowSpecificOrigins")]
    [HttpGet(Name = "GetAvailableServices")]
    public List<Service> GetAvailableServices()
    {
        var Available_Services = new List<Service>(){
            Visita_Guiada,
            Visita_Guiada_Almuerzo,
            Almuerzo,
            Cena
        };
        return Available_Services;
    }
}
