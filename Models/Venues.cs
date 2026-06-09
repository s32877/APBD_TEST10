namespace TemplateForT2.Models;

public class Venues
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Address { get; set; } = null!;
    public int Capacity { get; set; }
    public string Phone { get; set; } = null!;
    public ICollection<Events> Events { get; set; } = new List<Events>();
}