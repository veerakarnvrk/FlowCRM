namespace FlowCRM.Models;

public class Activity
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int CustomerId { get; set; }

    public int? DealId { get; set; }

    public string Type { get; set; }

    public string Subject { get; set; }

    public string Description { get; set; }

    public DateTime CreatedAt { get; set; }
}