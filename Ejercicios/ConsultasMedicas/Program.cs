using System;

namespace ConsultasMedicas // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Opciones opciones = new Opciones();
            string opcion = "";
            
            while(true)
            {
                Console.WriteLine("Consola Consultas Medicas - Proyecto Final L2\r");
                Console.WriteLine("------------------------\n");
                Console.WriteLine("Elige una opcion de la Siguiente lista:");
                Console.WriteLine("\ta - Lista de Medicos");
                Console.WriteLine("\tb - Consultas");
                Console.WriteLine("\tc - Listado de Pacientes");
                Console.WriteLine("\td - Revisar Consultas");
                Console.Write("Cual es tu Opcion? ");
                Console.Write("Cual es tu Opcion? ");
                opcion = Console.ReadLine();

            switch(opcion)
            {
                case "a":
                //opciones.ListaConsulta();
                    break;
                case "b":
                //opciones.ListaMedicos();
                
                    break;
                case "c":
                
                //opciones.ListaPacientes();
                    break;
                default:
                    break;

            }
            if (opcion == "0")
                break;
            }

        }
    }
}