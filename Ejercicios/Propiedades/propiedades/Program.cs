using System;

namespace propiedades
{
    class Program
    {
        static void Main(string [] args){

            Alumno a = new Alumno();

            a.PrimerNombre = "Juan";
            a.SegundoNombre = "Jose";

            Alumno b = new Alumno();
            b.id = 2;
            b.PrimerNombre = "Maria";
            b.SegundoNombre = "Castellanos";

            Alumno c = new Alumno(3);
            c.PrimerNombre = "Silvia";


            Alumno d = new Alumno("Cesar", "Fuentes");

            Console.WriteLine(a.id);
            Console.WriteLine(b.id);
            Console.WriteLine(c.id);
            Console.WriteLine(a.PrimerNombre);
            Console.WriteLine(b.PrimerNombre);
            Console.WriteLine(c.PrimerNombre);
            Console.WriteLine(d.PrimerNombre + " " + d.SegundoNombre);
            

        }
    }
}