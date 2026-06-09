namespace TemplateForT2.Models;

public class Events
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime EventDate { get; set; }
    public decimal TicketPrice { get; set; }
    public string Status { get; set; } = null!;
    
    public int VenueId { get; set; }
    public Venues Venue { get; set; } = null!;
    
    public ICollection<Registrations> Registrations { get; set; } = new List<Registrations>();
}