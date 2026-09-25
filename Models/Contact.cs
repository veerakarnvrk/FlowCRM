namespace FlowCRM.Models;
public class contact
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public DateTime CreatedAt { get; set; }
}