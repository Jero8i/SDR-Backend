using System.Globalization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers;

[ApiController]
[Route("[controller]")]
public class ServicesController : ControllerBase
{
    private readonly ILogger<ServicesController> _logger;
    public ServicesController(ILogger<ServicesController> logger)
    {
        _logger = logger;
    }

    [EnableCors("_myAllowSpecificOrigins")]
    [HttpGet(Name = "GetAvailableServices")]
    public List<Service>? GetAvailableServices(DateTime Date)
    {
        try
        {
            CultureInfo culture = new CultureInfo("es-ES");
            DayOfWeek Day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), culture.DateTimeFormat.GetDayName(Date.DayOfWeek));

            List<Service> Response = new List<Service>();
            ServiceMocks serviceMocks = new ServiceMocks();

            foreach (var service in serviceMocks.AvailableServices)
            {
                bool IsInRange = (Date >= service.StartDate) && (Date <= service.EndDate);
                bool IsValid = service.Schedule.schedule.ContainsKey(Day);

                if (service.IsActive != null)
                {
                    if ((bool)service.IsActive && IsInRange && IsValid)
                    {
                        Response.Add(service);
                    }
                }

            }

            return Response;

        }
        catch (System.Exception)
        {
            // TODO define the format of the response to an error.
            throw;
        }
    }

    /*

    I tried to do the validations in these separate methods but it gave error for ambiguous http request 
    (ask Jero about how does the endpoint works in C#).

    public bool IsInRange(DateTime Date, Service Service)
    {
        return (Date >= Service.StartDate) && (Date <= Service.EndDate);
    }

    public bool IsValid(DateTime Date, Service Service)
    {
        // There must be a better way ...
        Dictionary<System.DayOfWeek, DayOfWeek> Equivalencies = new Dictionary<System.DayOfWeek, DayOfWeek> {
            {System.DayOfWeek.Monday, DayOfWeek.Lunes},
            {System.DayOfWeek.Tuesday, DayOfWeek.Martes},
            {System.DayOfWeek.Wednesday, DayOfWeek.Miercoles},
            {System.DayOfWeek.Thursday, DayOfWeek.Jueves},
            {System.DayOfWeek.Friday, DayOfWeek.Viernes},
            {System.DayOfWeek.Saturday, DayOfWeek.Sabado},
            {System.DayOfWeek.Sunday, DayOfWeek.Domingo}
        };

        return Service.Schedule.schedule.ContainsKey(Equivalencies[Date.DayOfWeek]);
    }

    */

}
