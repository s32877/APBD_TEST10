namespace TemplateForT2.DTOs;

public class VenuesDTO
{
    public string Name { get; set; }
    public string Address { get; set; }
    public int Capacity { get; set; }
    public string Phone { get; set; }
    public VenueDetailsDTO Details { get; set; }
}