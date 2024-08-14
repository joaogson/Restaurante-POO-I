using System;

namespace Restaurante;


public class Prato
{

    public string Nome { get; private set; }
    public double Preco { get; private set; }
    public bool Vegetariano;

    public void AtualizaPreco(int preco)
    {
        if(preco<0)
            throw new ArgumentException("O preço deve ser positivo", nameof(preco));

        this.Preco = preco;
    }

    public int ObterPreco()
    {
        return Preco;
    }

}