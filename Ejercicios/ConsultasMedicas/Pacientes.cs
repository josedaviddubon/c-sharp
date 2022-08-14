public class Paciente: Persona
{
    public string? CondicionPago { get; set; }

        public Paciente(int codigo, string nombre, string codigoPaciente)
    {
        Codigo = codigo;
        PrimerNombre = nombre;
        
    }
    
}