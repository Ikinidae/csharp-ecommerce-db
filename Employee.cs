public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    //relazione 1 a molti con payments
    public List<Order> Orders { get; set; }
}


