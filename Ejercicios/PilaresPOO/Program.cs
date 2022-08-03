using System;

namespace PilaresPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POO en Animales");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Mamiferos");
            Console.WriteLine("---------");
            Console.WriteLine("");

            Mamifero mamifero = new Mamifero();
            mamifero.AnimalesMamiferos();

            Console.WriteLine("Aves");
            Console.WriteLine("---------");

            Ave ave = new Ave();
            ave.AnimalesAves();
            
            Console.WriteLine("Peces");
            Console.WriteLine("---------");

            Pez pez = new Pez();
            pez.AnimalPeces();
        }
    }

}