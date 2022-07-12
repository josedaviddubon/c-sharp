using System;

namespace Funciones  // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno a  = new Alumno(1, "Juan", "Perez"); 
            Alumno b  = new Alumno(2, "Maria", "Martinez");

            a.inactivarAlumno();

            Console.WriteLine(a.nombreCompleto());
            Console.WriteLine(b.nombreCompleto());

            Console.WriteLine("");

            a.activarAlumno();
            Console.WriteLine(a.nombreCompleto());
            Console.WriteLine(b.nombreCompleto());

        }
    }
}