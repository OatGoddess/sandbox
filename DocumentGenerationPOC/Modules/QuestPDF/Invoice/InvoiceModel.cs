public class InvoiceModel
{
    public int InvoiceNumber { get; init; }
    public DateTime IssueDate { get; init; }
    public DateTime DueDate { get; init; }

    public Address SellerAddress { get; init; }
    public Address CustomerAddress { get; init; }

    public List<OrderItem> Items { get; init; }
    public string Comments { get; init; }
}

public class OrderItem
{
    public string Name { get; init; }
    public decimal Price { get; init; }
    public int Quantity { get; init; }
}

public class Address
{
    public string CompanyName { get; init; }
    public string Street { get; init; }
    public string City { get; init; }
    public string State { get; init; }
    public object Email { get; init; }
    public string Phone { get; init; }
}