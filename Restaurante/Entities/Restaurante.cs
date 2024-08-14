using System;

namespace Restaurante;

public class Restaurante : Estabelecimento
{
    private int count=0;
    public List<Prato> cardapio = new List<Prato>();

    public Restaurante(string nome, string endereco, string telefone) : base(nome, endereco, telefone)
    {
        count++;
    }

    public void AdicionaPrato(string nome, int preco, bool veg)
    {
        Prato novoPrato = new Prato(nome, preco, veg);
        cardapio.Add(novoPrato);
        Console.WriteLine($"Prato: {novoPrato} adicionado com sucesso!");
    }

    public void RemovePrato(string nome, int preco)
    {
        cardapio.Find(new cardapio() { Nome=nome, Preco=preco});
        Console.WriteLine($"Prato: {nome} removido com sucesso!")
    }

}