using System;

namespace inventario
{
    class Program
    {


        //////////////////////////////////////////////////////////////////////////////////
//  *\
//     public void Perro()
//     {
//       Mamiferos mamiferos = new Mamiferos();
//       mamiferos.Nombre = "Oso";
//       Comer();
//       Dormir();
//       Caminar();
//       Ladrar();
//     }


//     public void Gato()
//     {
//       mamiferos.Nombre = "Miller";
//       Comer();
//       Dormir();
//       Caminar();
//       Maullar();
//     }



//     public void Mono()
//     {
//       mamiferos.Nombre = "Botas";
//       Comer();
//       Dormir();
//       Caminar();
//       Maullar();
//     }

// \*
        static void main(string[] args)
        {
            int opcion = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Inventario");
                Console.WriteLine("*********************");
                Console.WriteLine("*********************");
                Console.WriteLine("");
                Console.WriteLine("1- Productos");
                Console.WriteLine("2- Ingreso de Inventario");
                Console.WriteLine("3- Salida de Inventario");
                Console.WriteLine("0- Salidar");
                opcion = Console.Read();

                switch (opcion)
                {
                    case 1:
                    Console.WriteLine("Productos!");
                    Console.ReadLine();
                    break;

                    default:
                    break;
                }

                if (opcion == 0)
                {
                    break;
                }
            }
  
        }
    }
}