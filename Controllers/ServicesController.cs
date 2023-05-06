using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers;

[ApiController]
[Route("[controller]")]
public class ServicesController : ControllerBase
{

    public Service Visita_Guiada = new Service(
        "Visita Guiada", 
        new DateTime(2023, 1, 1),
        new DateTime(2023, 12, 1),
        true,
        5,
        new Day_Hour()
    );

    public Service Visita_Guiada_Almuerzo = new Service(
        "Visita Guiada con Almuerzo", 
        new DateTime(2023, 1, 1),
        new DateTime(2023, 12, 1),
        true,
        5,
        new Day_Hour()
    );

    public Service Almuerzo = new Service(
        "Almuerzo", 
        new DateTime(2023, 3, 1),
        new DateTime(2023, 9, 1),
        true,
        8,
        new Day_Hour()
    );

    public Service Cena = new Service(
        "Cena", 
        new DateTime(2023, 9, 1),
        new DateTime(2023, 3, 1),
        true,
        8,
        new Day_Hour()
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
        List<Service> Available_Services = new List<Service>();
        Available_Services.Add(Visita_Guiada);
        Available_Services.Add(Visita_Guiada_Almuerzo);
        Available_Services.Add(Almuerzo);
        Available_Services.Add(Cena);
        return Available_Services;
    }
}
