public class Consulta
{
    //public List<Paciente> Pacientes {get; set;}
    //public List<Medico> Medicos {get; set;}
    public List<DetalleConsulta> ListaDetalleConsulta { get; set; }
    public int Id { get; set; }

    public string Codigo {get; set;}
    public string Descripciones {get ; set;}
    public string Comentarios   {get; set;}
    public string Diagnostico {get; set;}
    public bool Activo {get; set;}
    public Medico Medico {get; set;}
    public Paciente Paciente {get; set;}
    public DateTime FechaConsulta {get; set;}
    
    
    public Consulta(int id, string codigo,string descripcion, string comentarios, string diagnostico,bool activo, DateTime fechaconsulta, Paciente paciente, Medico medico)
    {
        Id = id;
        Codigo = codigo;
        Descripciones = descripcion;
        Comentarios = comentarios;
        Diagnostico = diagnostico;
        Activo = activo;
        FechaConsulta = fechaconsulta;
        ListaDetalleConsulta = new List<DetalleConsulta>();
        Paciente = paciente;
        Medico = medico;
    }
    public void AgregarConsulta(Cita cita)
    {
        int nuevoCodigo = ListaDetalleConsulta.Count + 1;

        DetalleConsulta o = new DetalleConsulta(nuevoCodigo, 1, cita);
        ListaDetalleConsulta.Add(o);

    }

    public void InactivarConsulta()
    {   
        Activo = false;
    }


}