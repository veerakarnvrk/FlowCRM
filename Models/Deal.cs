namespace FlowCRM.Models;

public class Deal
{
    public int Id { get; set; }

    public string DealCode { get; set; }

    public int CustomerId { get; set; }

    public int OwnerId { get; set; }

    public string Title { get; set; }

    public decimal Amount { get; set; }

    public string Stage { get; set; }

    public DateTime ExpectedCloseDate { get; set; }

    public string Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}