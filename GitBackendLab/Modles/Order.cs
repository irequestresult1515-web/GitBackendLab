namespace GitBackendLab.Models;

public class Order
{
    public int Id { get; set; }

    public decimal Total { get; set; }

    public string Status { get; set; } = "Pending";
}