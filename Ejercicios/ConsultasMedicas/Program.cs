namespace ConsultasMedicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos datos = new Datos();
            string opcion = "";

            while (true)
            {
                Console.WriteLine("Consola Consultas Medicas - Proyecto Final L2\r");
                Console.WriteLine("------------------------\n");
                Console.WriteLine("Elige una opcion de la Siguiente lista:");
                Console.WriteLine("\t1 - Lista de Consultas");
                Console.WriteLine("\t2 - Lista de Medicos");
                Console.WriteLine("\t3 - Listado de Pacientes");
                Console.WriteLine("\t4 - Ingresar Consulta");
                Console.WriteLine("\t0 - Salir");
                Console.Write("Cual es tu Opcion? ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                    datos.ListarConsulta();
                        break;
                    case "2":
                    datos.ListarMedicos();
                        break;
                    case "3":
                        datos.ListarPacientes();
                        break;
                    case "4":
                        datos.CrearConsulta();
                        break;      
                    case "5":
                        //datos.ListarOrdenes();
                        break;                                          
                    default:
                        break;
                }

                if (opcion == "0") {
                    break;
                }
            }
        }
    }
}