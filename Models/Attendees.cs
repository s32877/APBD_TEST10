namespace TemplateForT2.Models;

public class Attendees
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public ICollection<Registrations> Registrations { get; set; } = new List<Registrations>();
}