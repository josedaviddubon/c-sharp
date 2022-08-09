public class Consulta
{
    public int Id { get; set; }

    public string Descripciones {get ; set;}
    public string Comentarios   {get; set;}
    public string Diagnostico {get; set;}
    public bool Estado {get; set;}
    public DateTime FechaConsulta {get; set;}
    public List<Paciente> Pacientes {get; set;}
    public List<Medico> Medicos {get; set;}

}