using System;

namespace Animais;

public class Cachorro : Animal // Classe filha : Classe Pai
{
    public string Raca { get; set; }

    public Cachorro(string nome, string raca) : base(nome)
    {
        Raca = raca;
    }

    public void Latir()
    {
        Console.WriteLine($"{Nome} - {Raca} está latindo: Au-Au");
    }
}
