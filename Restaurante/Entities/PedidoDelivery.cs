using System;

namespace Restaurante;

public class PedidoDelivery : Pedido
{

public override CalcularTotal(double frete)
{
    int total = pratos.Sum(Prato => Prato.Preco);
    int Pedido = total + frete;

    Console.WriteLine($"Pedido deu: {Pedido}");
}

}