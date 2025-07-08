using System;
using Animais;

class Program
{
    static void Main(string[] args)
    {
        Cachorro cachorro = new Cachorro("Brucy", "Labrador");
        Gato gato = new Gato("Luna");

        cachorro.Comer();
        cachorro.Latir();

        gato.Comer();
        gato.Miar();

        List<Animal> animais = new List<Animal>()
        {
            new Cachorro;
            new Gato;
        };

        foreach (Animal animal in animais)
        {
            animal.FazerSom();
        }
    }
}