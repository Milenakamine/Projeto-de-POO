using System;

namespace Primeiro_POO
{
    class Program
    {
        static void Main(string[] args)
        {
           Personagem riri = new Personagem();
           riri.armadura= "Iron Heart";

           Console.WriteLine(riri.nome);

           Console.WriteLine(riri.armadura);

           Console.WriteLine(riri.Atacar());
        }
    }
}
