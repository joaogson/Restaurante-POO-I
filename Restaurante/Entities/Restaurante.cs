using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurante;

public class Restaurante : Estabelecimento
{
    private int count = 0;
    private int Id = 0;
    public List<Prato> cardapio;

    public Restaurante(string nome, string endereco, string telefone) : base(nome, endereco, telefone)
    {
        Id = count;
        count++;
        cardapio = new List<Prato>();

    }

    public void RemovePrato(string nome)
    {
        Prato pratoParaRemover = cardapio.FirstOrDefault(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

        if (pratoParaRemover == null)
        {
            Console.WriteLine($"Nenhum prato igual a {pratoParaRemover} encontrado!");
        }
        else
        {
            cardapio.Remove(pratoParaRemover);
            Console.WriteLine($"prato {pratoParaRemover} removido com sucesso do cardápio!");

        }

    }

}