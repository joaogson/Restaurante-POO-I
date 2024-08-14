namespace Restaurante;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {

        Console.WriteLine("Selecione uma opção");
        Console.WriteLine("1- Cadastrar Restaurantes e Pratos");
        Console.WriteLine("2- Gerenciar Pratos");
        Console.WriteLine("3- Gerenciar Pedidos");
        Console.WriteLine("4- Exibir Pedidos");
        Console.WriteLine("5- Sair");
        
        switch (Console.ReadLine())
        {
            
            case "1":

                Clear();
                Console.WriteLine("1- Cadastrar Restaurante");
                Console.WriteLine("2- Cadastrar Prato");
                

                if(Console.ReadLine() == "1")
                    {
                    string nome;
                    string endereco;
                    string telefone;
                    Restaurante.Restaurante(nome, endereco, telefone);
                    }
                else
                {
                    string nomePrato;
                    string preco;
                    string veg;
                    bool vegetariano;
                    if(ver == 's')
                        vegetariano = true;
                    else
                        vegetariano = false;

                    Restaurante.AdicionaPrato(nomePrato, preco, vegetariano);
                }
            break;

            case "2":

            Clear();
            Console.WriteLine("1- Adicionar Prat");

            case "3":

            case "4":

            case "5":
        }

        }
       


    }
}
