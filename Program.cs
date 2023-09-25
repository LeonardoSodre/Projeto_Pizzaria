using System;
using System.Linq;



 List<Pizza> listaPizzas = new List<Pizza>();
 List<Pedido> listaPedidos = new List<Pedido>();
 
 

    Console.WriteLine("********************************");
    Console.WriteLine(" BEM VINDO AO PROJETO PIZZARIA");
    Console.WriteLine(" ESCOLHA UMA OPÇÃO\n\n");

        while (true)
        {
    
            Console.WriteLine("1 - Adicionar Pizza \n2 - Listar Pizza  \n3 - Criar Novo Pedido \n4 - Listar Pedidos \n5 - Sair \nDigite sua opção:");
            var opcao = int.Parse(Console.ReadLine());
 

            switch (opcao)
            {
                case 1:
                    addPizza();
                break;
                case 2:
                    listarPizza();
                break;
                case 3:
                    criarPedido();
                break;
                case 4:
                     Console.WriteLine("Entrou no 4");
                break;
                case 5:
                     Environment.Exit(0);
                break;
                default:
                    Console.WriteLine("Opção Invalida!! Execute novamente. ");
                    Environment.Exit(0); 
                break;
            }

        }


    void addPizza()
    {
         Console.WriteLine("**********************************");
         Console.WriteLine("Você escolheu adicionar uma pizza!! \n");
        
            Console.WriteLine("Digite o nome da Pizza: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite os sabores da Pizza separados por vírgula: ");
            var sabores = Console.ReadLine();

            Console.WriteLine("Digite o valor da pizza no formato 00,00 ");
            var valor = double.Parse(Console.ReadLine());

            var pizza = new Pizza(nome, sabores, valor);

            listaPizzas.Add(pizza);   
        
            Console.WriteLine("Pizza Criada!");
        
    }

   void listarPizza()
    {
         if (listaPizzas.Count == 0){
            Console.WriteLine("\nNenhuma Pizza adicionada!!\n");
            return;
         }else{
                 foreach (var i in listaPizzas)
                   {
            Console.WriteLine($"{i.Nome} - R${i.Valor}");
            }  
        }      

    }


   void criarPedido() 
    {
    /*    if (listaPizzas.Count == 0){
            Console.WriteLine("\nNenhuma Pizza adicionada!!\n");
            return;*/
        
    Console.WriteLine("Digite o nome do Cliente: ");
    var nome = Console.ReadLine();

    Console.WriteLine("Digite o telefone do Cliente: ");
    var telefone = Console.ReadLine();

    Pedido pedido = new Pedido(telefone);
    }
/*
    while(true){
        listarPizzas();
        Console.WriteLine("Digite o nome da pizza que deseja: (ou 0 para sair):  ");
        string pizzaEscolhida = Console.ReadLine();

        if(pizzaEscolhida == "0"){
            break;    
           
    }   

}

*/
    
 