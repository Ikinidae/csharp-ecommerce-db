//Considerando che:
//ci sono clienti che effettuano ordini.
//Un ordine viene preparato da un dipendente.
//Un ordine ha associato uno o più pagamenti (considerando eventuali tentativi falliti)

//Realizzate le seguenti funzionalità
//inserite 10 prodotti all’avvio del programma (i prodotti non devono essere inseriti in caso si riavvi l’applicazione)
//quando l’applicazione si avvia chiede se l’utente è un dipendete o un cliente
//se è un dipendente potrà eseguire CRUD sugli ordini
//se è un cliente potrà acquistare degli ordini
//simulate randomicamente l’esito di un acquisto (status = ok | status = ko)
//Bonus
//Il dipendente deve poter spedire gli ordini acquistati per cui il pagamento è andato a buon fine.

using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

EcommerceDbContext db = new EcommerceDbContext();

List<Product> products = db.Products.ToList<Product>();


if (products.Count == 0)
{
    Product product1 = new Product() { Name = "telefono", Description = "molto bello e funzionale", Price = 699.99f };
    Product product2 = new Product() { Name = "borraccia", Description = "molto bello e funzionale", Price = 9.99f };
    Product product3 = new Product() { Name = "pianta", Description = "molto bello e funzionale", Price = 5.99f };
    Product product4 = new Product() { Name = "duck", Description = "molto bello e funzionale", Price = 19.99f };
    Product product5 = new Product() { Name = "libro", Description = "molto bello e funzionale", Price = 8.99f };
    Product product6 = new Product() { Name = "telefono2", Description = "molto bello e funzionale", Price = 499.99f };
    Product product7 = new Product() { Name = "webcam", Description = "molto bello e funzionale", Price = 19.99f };
    Product product8 = new Product() { Name = "giacca", Description = "molto bello e funzionale", Price = 49.99f };
    Product product9 = new Product() { Name = "monitor", Description = "molto bello e funzionale", Price = 299.99f };
    Product product10 = new Product() { Name = "divano", Description = "molto bello e funzionale", Price = 699.99f };

    db.Products.Add(product1);
    db.Products.Add(product2);
    db.Products.Add(product3);
    db.Products.Add(product4);
    db.Products.Add(product5);
    db.Products.Add(product6);
    db.Products.Add(product7);
    db.Products.Add(product8);
    db.Products.Add(product9);
    db.Products.Add(product10);

    db.SaveChanges();

    //funzione che chieda se si è dipendenti o cliente
    RichiestaRuolo();
}
else
{
    //funzione che chieda se si è dipendenti o cliente
    RichiestaRuolo();
}


void RichiestaRuolo ()
{
    Console.WriteLine("Sei un dipendente o un cliente?");
    string user = Console.ReadLine();
    if (user == "dipendente")
    {
        //si possono eseguire operazioni sugli ordini
    }
    else if (user == "cliente")
    {
        //READ vengono mostrati i prodotti
        Console.WriteLine("I prodotti presenti nel nostro ecommerce sono:");
        foreach (Product product in products)
        {
            Console.WriteLine("Nome: {0}\ndescrizione: {1}\nprezzo: {2} euro", product.Name, product.Description, product.Price);
            Console.WriteLine("--------------------------------");
        }

    }
    else
        Console.WriteLine("Inserire un'opzione valida");
}
