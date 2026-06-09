namespace TemplateForT2.DTOs;

public class RegistrationsDTO
{
    public DateTime RegisteredAt { get; set; }
    public string SeatNumber  { get; set; }
    public AttendeesDTO Attendee { get; set; }
}