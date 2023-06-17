using Backend;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers;

[ApiController]
[Route("[controller]")]
public class ReservationsController : ControllerBase
{
    private readonly ILogger<ServicesController> _logger;
    public ReservationsController(ILogger<ServicesController> logger)
    {
        _logger = logger;
    }

    [EnableCors("_myAllowSpecificOrigins")]
    [HttpPost("")]
    public IActionResult CreateReservation([FromBody] Reservation? reservation)
    {
        ReservationMocks rm = new ReservationMocks(new CustomerMocks(), new ServiceMocks());
        try
        {
            if (ReservationValidations.IsNull(reservation))
            {
                return BadRequest("Reserva NULA.");
            }

            if (ReservationValidations.IsNewReservation(reservation))
            {
                if (ReservationValidations.IsValid(reservation))
                {
                    // Database.save(reservation)
                    return Ok("Reserva creada con éxito!");
                }
                else
                {
                    return BadRequest("Reserva no válida.");
                }
            }
            else
            {
                if (ReservationValidations.IsPresent(rm.Reservations, (int)reservation.Id))
                {
                    Reservation aux = ReservationValidations.GetReservation(rm.Reservations, (int)reservation.Id);
                    aux.Customer = reservation.Customer;
                    aux.Service = reservation.Service;
                    aux.Time = reservation.Time;
                    aux.NumberDiners = reservation.NumberDiners;
                    aux.Note = reservation.Note;

                    // Database.update(reservation)
                    return Ok("Reserva con id " + reservation.Id + " actualizada con éxito!");
                }
                else
                {
                    return BadRequest("No se encontró la reserva solicitada.");
                }
            }
        }
        catch (System.Exception)
        {
            throw;
            // Handle error related with DB (?).
        }
    }
}
