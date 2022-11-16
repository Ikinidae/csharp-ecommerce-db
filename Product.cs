public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }

    //relazione 1 a molti con orders
    public List<Order> Orders { get; set; }
}


