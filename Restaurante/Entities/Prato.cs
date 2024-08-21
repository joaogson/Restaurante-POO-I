using System;

namespace Restaurante;


public class Prato
{

    public string Nome { get; set; }
    public double Preco { get; set; }
    public bool Vegetariano;

    public Prato(string nome, double preco, bool vegetariano)
    {
        Nome = nome;
        Preco = preco;
        Vegetariano = vegetariano;
    }

    public void AtualizaPreco(int preco)
    {
        if(preco<0)
            throw new ArgumentException("O preço deve ser positivo", nameof(preco));

        this.Preco = preco;
    }

    public double ObterPreco()
    {
        return Preco;
    }

}