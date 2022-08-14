public class Datos
{
     public List<Medico> ListaMedicos {get; set;}
     public List<Cita> ListaCita {get; set;}
    public List<Paciente> ListaPacientes { get;  set; }
    public List<Consulta> ListaConsulta { get; set; }

    public Datos()
    {
     
        ListaConsulta = new List<Consulta>();
        

        ListaMedicos = new List<Medico>();
        cargarMedico();

        ListaPacientes = new List<Paciente>();
        cargarPacientes();

        ListaCita = new List<Cita>();
        cargarCita();
    }
    /*
    private void CargarConsulta()
    {
    
        
        Consulta c1 = new Consulta(1, "001", "Consulta General" , "Gripe y Tos", "Influencia", true, DateTime.Now );
        ListaConsulta.Add(c1);

        Consulta c2 = new Consulta(2,  "002", "Emergencia", "Fractura y posible Trauma", "Intervencion", true, DateTime.Now);
        ListaConsulta.Add(c2);

        Consulta c3 = new Consulta(3, "003", "Chequeo Medico", "Revision de Examenes", "Sin Comentarios", true, DateTime.Now);
        ListaConsulta.Add(c3);
    }
    */

    public void ListarConsulta()
    {
        Console.Clear();
        Console.WriteLine("Lista de Consultas");
        Console.WriteLine("==================");
        Console.WriteLine("Codigo | Descripcion |  Estado | Comentarios | Diagnostico | Fecha |");
        Console.WriteLine("Paciente | Medico");
        Console.WriteLine("======================");
        Console.WriteLine("");  

        foreach (var consulta in ListaConsulta)
        {
           
           if(consulta.Activo == true)
           {
                var activo = "Abierta";
                Console.WriteLine(consulta.Id + " |" + consulta.Descripciones + " |" + activo + " | " +" | " + consulta.Comentarios + " | " + consulta.Diagnostico + " |" + consulta.FechaConsulta);
                 Console.WriteLine(consulta.Paciente.PrimerNombre + " | " + consulta.Paciente.PrimerApellido);
                 Console.WriteLine(consulta.Medico.PrimerNombre + " | " + consulta.Medico.PrimerApellido);
           }
           else
           {
            var terminada = "Terminada";
            Console.WriteLine(consulta.Id + " |" + consulta.Descripciones +     " |" + terminada +  " | " + consulta.Comentarios + " | " + consulta.Diagnostico + " |" + consulta.FechaConsulta);
            Console.WriteLine(consulta.Paciente.PrimerNombre + " | " + consulta.Paciente.PrimerApellido);
            Console.WriteLine(consulta.Medico.PrimerNombre + " | " + consulta.Medico.PrimerApellido);
           }
           foreach (var detalle in consulta.ListaDetalleConsulta)
           {
                Console.WriteLine("Descripcion |  Costo |");
                Console.WriteLine(" " + detalle.Cita.Descripcion + " | " + detalle.Cita.Costo);
           }
        }


        Console.ReadLine();
    }
    public void ListarMedicos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Medicos");
        Console.WriteLine("===================");
        Console.WriteLine("");
        
        foreach (var medico in ListaMedicos)
        {
            Console.WriteLine(medico.Codigo + " | " + medico.PrimerNombre + " | " + medico.Disponibilidad);
        }

        Console.ReadLine();
    }
        public void ListarPacientes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Pacientes");
        Console.WriteLine("=================");
        Console.WriteLine("");
        
        foreach (var paciente in ListaPacientes)
        {
            Console.WriteLine(paciente.Codigo + " | " + paciente.PrimerNombre + " | " + paciente.PrimerApellido);
        }

        Console.ReadLine();
    }

    private void cargarCita()
    {
        Cita c1 = new Cita(1, "Consulta General", 150, true);
        ListaCita.Add(c1);

        Cita c2 = new Cita(2, "Emergencia", 200, true);
        ListaCita.Add(c2);

        Cita c3 = new Cita(3, "Chequeo Rutinario", 100, true);
        ListaCita.Add(c3);
    }
    
    private void cargarMedico()
    {

        Medico m1 = new Medico(1, "Dr. Jose Angel", true);
        ListaMedicos.Add(m1);

        Medico m2 = new Medico(2, "Dr. Ana Sabillon", true);
        ListaMedicos.Add(m2);

        Medico m3 = new Medico(3, "Dr.Erza Miller", false);
        ListaMedicos.Add(m3);
    }

    private void cargarPacientes()
    {
        Paciente p1 = new Paciente(1, "Pablo", "Way");
        ListaPacientes.Add(p1);

        Paciente p2 = new Paciente(2, "Fernando", "Herrera");
        ListaPacientes.Add(p2);
    }

    public void CrearConsulta()
    {
        Console.WriteLine("Creando Consulta");
        Console.WriteLine("=============");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del Paciente: ");
        string codigoPaciente = Console.ReadLine();

        Paciente paciente = ListaPacientes.Find(c => c.Codigo.ToString() == codigoPaciente);
        if(paciente ==null)
        {
            Console.WriteLine("Paciente no encontrado");
            Console.ReadLine();
            return;
        }else
        {
            Console.WriteLine("Paciente: " + paciente.PrimerNombre + "" + paciente.PrimerApellido);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el codigo del Medico: ");
        string codigoMedico = Console.ReadLine();

        Medico medico = ListaMedicos.Find(v => v.Codigo.ToString() == codigoMedico);
        if (medico == null) 
        {
            Console.WriteLine(" Medico no encontrado");
            Console.ReadLine();
            return;
        } 
        else if (medico.Disponibilidad == false)
        {
            Console.WriteLine(" Medico no Disponible");
            Console.ReadLine();
            return;
            
        }
        else {
            Console.WriteLine("Medcico: " + medico.PrimerNombre + " " + medico.PrimerApellido);
            Console.WriteLine("");
        }
        int nuevoCodigo = ListaConsulta.Count + 1;

        Console.WriteLine("Ingrese Codigo: ");
        string codigo = Console.ReadLine();

        Console.WriteLine("Ingrese Descripcion: ");
        string NuevaDescripcion = Console.ReadLine();

        Console.WriteLine("Ingrese Comentario: ");
        string NuevoComentario = Console.ReadLine();

        Console.WriteLine("Ingrese Diagnostico Preliminar: ");
        string nuevoDiagnostico = Console.ReadLine();

        Consulta nuevaConsulta = new Consulta(nuevoCodigo, codigo, NuevaDescripcion, NuevoComentario, nuevoDiagnostico, true, DateTime.Now, paciente, medico );
        ListaConsulta.Add(nuevaConsulta);

        while(true)
        {
            Console.WriteLine("Asigne La Cita: ");
            string codigoCita   = Console.ReadLine();
            Cita cita = ListaCita.Find(p => p.Codigo.ToString() == codigoCita);        
            if (cita == null)
            {
                Console.WriteLine("Tipo de Cita no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Cita Agregada: " + cita.Codigo);
                nuevaConsulta.AgregarConsulta(cita);
            }
             break;
        }


    }

     public void EstadoConsulta()
    {
        Console.WriteLine("Estado Consulta");
        Console.WriteLine("=============");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del Paciente: ");
        string codigoPaciente = Console.ReadLine();

        Paciente paciente = ListaPacientes.Find(c => c.Codigo.ToString() == codigoPaciente);
        if(paciente ==null)
        {
            Console.WriteLine("Paciente no encontrado");
            Console.ReadLine();
            return;
        }else
        {
            Console.WriteLine("Paciente: " + paciente.PrimerNombre + "" + paciente.SegundoNombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el codigo del Medico: ");
        string codigoMedico = Console.ReadLine();

        Medico medico = ListaMedicos.Find(v => v.Codigo.ToString() == codigoMedico);
        if (medico == null) 
        {
            Console.WriteLine(" Medico no encontrado");
            Console.ReadLine();
            return;
        } 
        else if (medico.Disponibilidad == false)
        {
            Console.WriteLine(" Medico no Disponible");
            Console.ReadLine();
            return;
            
        }
        else {
            Console.WriteLine("Medcico: " + medico.PrimerNombre + " " + medico.PrimerApellido);
            Console.WriteLine("");
        }
        int nuevoCodigo = ListaConsulta.Count + 1;

        Console.WriteLine("Ingrese Codigo: ");
        string codigo = Console.ReadLine();

        Console.WriteLine("Ingrese Descripcion: ");
        string NuevaDescripcion = Console.ReadLine();

        Console.WriteLine("Ingrese Comentario: ");
        string NuevoComentario = Console.ReadLine();

        Console.WriteLine("Ingrese Diagnostico Preliminar: ");
        string nuevoDiagnostico = Console.ReadLine();


        Consulta EstadoConsulta = new Consulta(nuevoCodigo, codigo, NuevaDescripcion, NuevoComentario, nuevoDiagnostico, false, DateTime.Now, paciente, medico );
        ListaConsulta.Add(EstadoConsulta);

        while(true)
        {
            Console.WriteLine("Asigne La Cita: ");
            string codigoCita   = Console.ReadLine();
            Cita cita = ListaCita.Find(p => p.Codigo.ToString() == codigoCita);   

            Console.WriteLine("Desea Desactivar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }   
            if (cita == null)
            {
                Console.WriteLine("Tipo de Cita no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Consulta Desactivda: " + cita.Codigo);
                EstadoConsulta.InactivarConsulta(cita);
            }
            break;

        }


    }



    #region 
    /*
    public void IngresoConsulta()
    {
            string Descripcion = "";
            string Comentarios = "";
            int idConsulta = 0;
            string IdPaciente = "";
            string IdMedico  = "";

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Ingreso de Consulta");
            Console.WriteLine("**********************************");

            Console.Write("Ingrese Id Consulta: ");
            //idConsulta = Console.ReadLine(0);

            Console.Write("Ingrese Descripcion: ");
            Descripcion = Console.ReadLine();

            Console.Write("Ingrese Comentario: ");
            Comentarios = Console.ReadLine();

            Console.Write("Ingrese Id Paciente: ");
            
            IdPaciente = Console.ReadLine();

            Console.Write("Ingrese Id Medico: ");
            
            IdMedico = Console.ReadLine();

            EstadoConsulta(idConsulta, Int32.Parse(IdPaciente),Int32.Parse(IdMedico), true, Descripcion, Comentarios );


    }
    */
    #endregion
}