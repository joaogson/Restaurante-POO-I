using System;

namespace Restaurante;

public abstract class Estabelecimento
{
    public string Nome { get; private set; }
    public string Endereco { get; private set; }
    public string Telefone { get; private set; }

    public Estabelecimento(string nome, string endereco, string telefone)
    {
        if(nome == null)
            throw new ArgumentNullException("O estabelecimento deve possuir um nome", nameof(nome));
        
        if(endereco == null)
            throw new ArgumentNullException("O estabelecimento deve possuir um endereço", nameof(endereco));

        Nome = nome;
        Endereco = endereco;
        Telefone = telefone;
        
        ;
    }
}