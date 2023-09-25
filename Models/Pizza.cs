public class Pizza
{
    public string Nome {get; set;}
    public string Sabores {get; set;}
    public double Valor {get; set;}

/*public string detalhes(){
    return $"{Nome}:  {Sabores} - ${Valor}";*/



  public Pizza(string nome, string sabores, double valor){
        Nome = nome;
        Sabores = sabores;
        Valor = valor;
       // Console.WriteLine('Pizza criada');
    }
    
     

}