namespace TemplateForT2.Models;

public class Registrations
{
    public int AttendeeId { get; set; }
    public Attendees Attendee { get; set; } = null!;
    
    public int EventId { get; set; }
    public Events Event { get; set; } = null!;
    
    public DateTime RegisteredAt { get; set; }
    public int? SeatNumber { get; set; }
}