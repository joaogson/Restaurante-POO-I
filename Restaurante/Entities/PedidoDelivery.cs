using System;

namespace Restaurante;

public class PedidoDelivery : Pedido
{

    private double taxaEntrega = 10; 

    public override void FazerPedido()
    {
        base.FazerPedido();
        Console.WriteLine($"Valor do pedido: {CalcularTotal()}");
        Console.ReadLine();
    }

    public override double CalcularTotal()
    {
    
        double totalDelivery = base.CalcularTotal() + taxaEntrega;
        return CalcularTotal();
    }

}