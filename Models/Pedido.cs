
public class Pedido{
   
   public string Nome {get; set;}
   public string Telefone {get; set;}
   public List<Pizza> Pizzas { get; set; }
   public double Total { get; private set; }

  
     public Pedido(string telefoneCliente)
     {
        Telefone = telefoneCliente;
        Pizzas = new List<Pizza>();
        Total = 0.0;

    }

    public void AdicionarPizza(Pizza pizza)
    {
        Pizzas.Add(pizza);
        Total += pizza.Valor;
    }


   
   public double calcularTotal()
   {
        double total=0; 
        
        foreach(var pizza in Pizzas){
            total += pizza.Valor;
        }
        return total;
    }


    public void mostrarDetalhes()
    {
        Console.WriteLine($"Telefone do cliente: {Telefone}");
        Console.WriteLine("Pizzas do Pedido: ");
        foreach(var pizza in Pizzas){
            Console.WriteLine($"{pizza.Nome} - R${pizza.Valor}");
        }
        Console.WriteLine($"Total do Pedido: R${calcularTotal()}");
    }

}