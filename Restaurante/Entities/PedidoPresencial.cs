using System;

namespace Restaurante;

public class PedidoPresencial : Pedido
{

    public override CalcularTotal()
    {
        int total = pratos.Sum(Prato => Prato.Preco);
        Console.WriteLine($"O pedido deu: {total}");
    }

}