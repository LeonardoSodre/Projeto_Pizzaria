public class Pedido{
   
   public string Nome {get; set;}
   public string Telefone {get; set;}
   public List<Pizza> Pizzas { get; set; }

  
     public Pedido(){
        Pizzas = new List<Pizza>();
    }

   
    public decimal calcularTotal(){
        decimal total=0;
        
        foreach(var pizza in Pizzas){
            total += pizza.Valor;
        }
        return total;
    }


    public void mostrarDetalhes(){
        Console.WriteLine($"Telefone do cliente: {Telefone}");
        Console.WriteLine("Pizzas do Pedido: ");
        foreach(var pizza in Pizzas){
            Console.WriteLine($"pizza");
        }
        Console.WriteLine($"Total do Pedido: R${calcularTotal()}");
    }

}