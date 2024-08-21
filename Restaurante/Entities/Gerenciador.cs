using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurante;


public class Gerenciador
{

    protected List<Restaurante> restaurantes;

    public Gerenciador()
    {
        restaurantes = new List<Restaurante>();
    }

    //Gerencia Restaurante 
    public void CadastrarRestaurante()
    {
        string nome = "";
        string endereco = "";
        string telefone = "";

        Console.WriteLine("Insira o nome do Restaurante");
        nome = Console.ReadLine();

        Console.WriteLine("Insira o endereco do Restaurante");
        endereco = Console.ReadLine();

        Console.WriteLine("Insira o telefone do restaurante");
        telefone = Console.ReadLine();

        Restaurante novoRestaurante = new Restaurante(nome, endereco, telefone);


        restaurantes.Add(novoRestaurante);

        Console.WriteLine($"Restaurante {nome} com endereço {endereco} e telefone {telefone} adicionado com sucesso");
        Console.ReadKey();
    }

    public void ListarRestaurantes()
    {
        foreach (var restaurante in restaurantes)
        {
            Console.WriteLine($"Nome: {restaurante.Nome}   Endereço: {restaurante.Endereco}   Telefone: {restaurante.Telefone}");

        }
        Console.ReadKey();
    }
    //Gerencia Restaurante

    public void AdicionaPrato()
    {

        Console.WriteLine("Informe o nome do restaurante");
        string nomeRestaurante = Console.ReadLine();

        Restaurante restaurante = restaurantes.FirstOrDefault(p => p.Nome.Equals(nomeRestaurante, StringComparison.OrdinalIgnoreCase));

        if (restaurante == null)
        {
            Console.WriteLine("O restaurante não existe");
        }
        else
        {

            string nome = "";
            double preco = 0;
            bool veg;
            string vegetariano = "";

            Console.WriteLine("Insira o nome do prato");
            nome = Console.ReadLine();

            Console.WriteLine("Insira o preco do prato");
            preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("É um prato vegetariano?");
            vegetariano = Console.ReadLine();

            if (vegetariano == "sim")
            {
                veg = true;
            }
            else
            {
                veg = false;
            }

            Prato novoPrato = new Prato(nome, preco, veg);

            Console.WriteLine($"Prato: {novoPrato.Nome} adicionado com o preço de: {novoPrato.Preco}");
        }
        Console.ReadKey();
    }

    public void RemovePrato()
    {

        Console.WriteLine("Selecione um Restaurante");
        string restauranteNome = Console.ReadLine();

        Restaurante restaurante = restaurantes.FirstOrDefault(p => p.Nome.Equals(restauranteNome, StringComparison.OrdinalIgnoreCase));

        if (restaurante == null)
        {
            Console.WriteLine("Restaurante inválido");

        }
        else
        {
            string nomePrato = Console.ReadLine();

            Prato pratoParaRemover = restaurante.cardapio.FirstOrDefault(n => n.Nome.Equals(nomePrato, StringComparison.OrdinalIgnoreCase));



            restaurante.cardapio.Remove(pratoParaRemover);
            Console.WriteLine($"Prato {pratoParaRemover} Removido com Sucesso!");
            Console.ReadKey();
        }

    }

    public void ListarPratos()
    {

        Console.WriteLine("Informe o nome do restaurante");
        string nomeRestaurante = Console.ReadLine();

        Restaurante restauranteParaListar = restaurantes.FirstOrDefault(r => r.Nome.Equals(nomeRestaurante, StringComparison.OrdinalIgnoreCase));

        if (restauranteParaListar == null)
        {
            Console.WriteLine("Restaurante Inválido");
        }
        else
        {
            foreach (var Prato in restauranteParaListar.cardapio)
            {
                Console.WriteLine($"Nome do Prato: {Prato.Nome}   Preço: {Prato.Preco}   Vegetariano: {Prato.Vegetariano}");
            }

        }
        Console.ReadKey();
    }

}