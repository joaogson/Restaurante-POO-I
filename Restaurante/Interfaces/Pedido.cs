using System;
using System.Reflection.Emit;

namespace Restaurante;

public abstract class Pedido : Gerenciador
{
    protected string NumeroPedido { get; set; }
    protected List<Prato> Pedidos { get; set; }

    protected virtual void FazerPedido()
    {
        Console.WriteLine("Informe o Restaurante");
        string restauranteNome = Console.ReadLine();

        bool continuar = true;

        while (continuar)
        {
            Restaurante restaurante = restaurantes.FirstOrDefault(x => x.Nome.Equals(restauranteNome, StringComparison.OrdinalIgnoreCase));

            if (restaurante == null)
            {
                throw new ArgumentException("O restaurante não existe", nameof(restauranteNome));
            }
            else
            {

                Console.WriteLine("Informe o prato");
                string pratoNome = Console.ReadLine();

                Prato prato = restaurante.cardapio.FirstOrDefault(x => x.Nome.Equals(pratoNome, StringComparison.OrdinalIgnoreCase));

                Pedidos.Add(prato);
                Console.WriteLine($"Prato: {prato.Nome} adicionado ao pedido!");
                Console.ReadKey();
            }

            Console.WriteLine("Deseja Continuar?");
            string opcao = "";
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

    protected virtual double CalcularTotal()
    {
        double total = 0;

        foreach (var prato in Pedidos)
            total += prato.Preco;


        return total;
    }
}