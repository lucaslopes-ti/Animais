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
    }
}