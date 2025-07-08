using System;

namespace Animais;

public class Animal
{
    public string Nome { get; set; }

    public Animal(string nome)
    {
        Nome = nome;
    }

    public virtual void Comer() // virtual representa que o metodo pode ser sobrescrito. Pelas classes que herdam da classe animal
    {
        Console.WriteLine($"{Nome} está comendo");
    }

    public virtual void FazerSom()
    {
        Console.WriteLine("Animal fez um som");
    }
}
