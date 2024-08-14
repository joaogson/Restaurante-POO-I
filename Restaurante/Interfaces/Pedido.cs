using System;

namespace Restaurante;

public abstract class Pedido
{
    public string NumeroPedido { get; private set; }
    List <Prato> pratos = new List<Pratos>();

    public virtual CalcularTotal()
    {
    
    } 
}