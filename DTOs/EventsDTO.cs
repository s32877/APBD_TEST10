namespace TemplateForT2.DTOs;

public class EventsDTO
{
    public int EventId { get; set; }
    public string Name { get; set; }
    public DateTime EventDate { get; set; }
    public decimal TicketPrice  { get; set; }
    public string Status { get; set; }
    public VenuesDTO Venue { get; set; }
    public List<RegistrationsDTO> Registrations { get; set; }
}