using System;

namespace Animais;

public class Gato : Animal 
{
    public Gato(string nome) : base(nome)
    {

    }

    public void Miar()
    {
        Console.WriteLine($"{Nome} está miando");
    }
}
