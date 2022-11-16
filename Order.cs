public class Order
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int Amount { get; set; }
    public bool Status { get; set; }

    //relazione 1 a molti con customer
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    //relazione 1 a molti con employee
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }

    //relazione 1 a molti con payments
    public List<Payment> Payments { get; set; }

    //relazione 1 a molti con products
    public List<Product> Products { get; set; }
}


