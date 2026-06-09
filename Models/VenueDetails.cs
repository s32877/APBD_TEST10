namespace TemplateForT2.Models;

public class VenueDetails
{
    public int VenueId { get; set; }
    public Venues Venue { get; set; } = null!;
    
    public string AccessibilityInfo { get; set; } = null!;
    public int ParkingSapces { get; set; }
    public string? WebsiteUrl { get; set; } = null!;
}