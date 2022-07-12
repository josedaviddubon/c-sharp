using System;

namespace Funciones  // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno a  = new Alumno(1, "Juan", "Perez"); 
            Console.WriteLine(a.nombreCompleto());
        }
    }
}