
//status potrebbe essere un boolean
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    
    //relazione 1 a molti con ordini
    public List<Order> Orders { get; set; }
}


