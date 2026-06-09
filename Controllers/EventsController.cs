using Microsoft.AspNetCore.Mvc;
using PrepT2.Data;
using TemplateForT2.DTOs;
using Microsoft.EntityFrameworkCore;

namespace TemplateForT2.Controllers;


[ApiController]
[Route("api/events/")]
public class EventsController : ControllerBase
{
    private readonly AppDbContext _context;

    public EventsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetEvent(int id)
    {
        var events = await _context.Events
            .Include(e=>e.Venue)
            .ThenInclude(v=>v.VenueDetails)
            .Where(e => e.Id == id)
            .Select(s => new EventsDTO
            {
                EventId = s.Id,
                Name = s.Name,
                EventDate = s.EventDate,
                TicketPrice = s.TicketPrice,
                Status = s.Status,
                Venue = new VenuesDTO
                {
                    Name = s.Venue.Name,
                    Address = s.Venue.Address,
                    Capacity = s.Venue.Capacity,
                    Phone = s.Venue.Phone,
                    Details = new VenueDetailsDTO
                    {
                        ParkingSpaces = s.Venue.VenueDetails!.ParkingSapces,
                        AccessibilityInfo = s.Venue.VenueDetails!.AccessibilityInfo,
                        WebsiteUrl = s.Venue.VenueDetails!.WebsiteUrl!
                    }
                },
                Registrations = s.Registrations.Select(r => new RegistrationsDTO
                {
                    RegisteredAt = r.RegisteredAt,
                    SeatNumber = r.SeatNumber,
                    Attendee = new AttendeesDTO
                    {
                        FirstName = r.Attendee.FirstName,
                        LastName = r.Attendee.LastName,
                        Email = r.Attendee.Email,
                        Phone = r.Attendee.Phone,
                    }
                }).ToList() 
            })
            .FirstOrDefaultAsync();
        
        if (events is null)
        {
            return NotFound();
        }
        return Ok(events);
    }

    [HttpPost("{id}/registrations")]
    public async Task<IActionResult> PostEvent(int id)
    {
        return CreatedAtAction(nameof(GetEvent), new { id = id }, await _context.Events.FindAsync(id));
    }
}