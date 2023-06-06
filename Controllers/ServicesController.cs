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

                if (service.IsActive && IsInRange && IsValid)
                {
                    Response.Add(service);
                }
            }

            return Response;
        }
        catch (System.Exception)
        {
            throw;
        }
    }
}
