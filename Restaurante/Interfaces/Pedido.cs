using System;
using System.Reflection.Emit;

namespace Restaurante;

public abstract class Pedido : Gerenciador
{
    protected string NumeroPedido { get; set; }

    private static int count = 0;
    protected List<Prato> PedidoLista { get; set; }

    public Pedido()
    {
        NumeroPedido = Convert.ToString(count);
        PedidoLista = new List<Prato>();
        count++;

    }

    public virtual void FazerPedido()
    {
        bool continuar = true;

        while (continuar)
        {
            Restaurante restaurante = null;

            while (restaurante == null)
            {
                Console.WriteLine("Informe o Restaurante");
                string restauranteNome = Console.ReadLine();

                restaurante = restaurantes.FirstOrDefault(x => x.Nome.Equals(restauranteNome, StringComparison.OrdinalIgnoreCase));

                if (restaurante == null)
                    Console.WriteLine("Restaurante não existe, tente novamente");

            }

            Console.WriteLine("Informe o prato");
            string pratoNome = Console.ReadLine();

            Prato prato = restaurante.cardapio.FirstOrDefault(x => x.Nome.Equals(pratoNome, StringComparison.OrdinalIgnoreCase));

            PedidoLista.Add(prato);
            Console.WriteLine($"Prato: {prato.Nome} adicionado ao pedido!");
            Console.ReadKey();


            Console.WriteLine("Deseja Continuar?");
            string opcao = Console.ReadLine().ToLower();
            if (opcao == "sim" || opcao == "s")
            {
                continuar = true;
            }
            else if (opcao == "nao" || opcao == "n" || opcao == "não")
            {
                continuar = false;
            }


        }
    }

    public virtual double CalcularTotal()

    {
        double total = PedidoLista.Sum(prato => prato.Preco);

        return total;
    }

    public virtual void DetalhesPedido(string numeroPedido)
    {
        Pedido pedidoDetalhes = pedidos.FirstOrDefault(x => x.NumeroPedido.Equals(numeroPedido, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine($"Detalhes do pedido:\nNúmero do pedido: {pedidoDetalhes.NumeroPedido}");
        foreach(var prato in PedidoLista)
        {
            Console.WriteLine($"Prato: {prato.Nome}   Preço: {prato.Preco}");
        }
    }
}