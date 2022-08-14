public class Paciente: Persona
{
    public string? CondicionPago { get; set; }

        public Paciente(int codigo, string nombre, string primerApellido)
    {
        Codigo = codigo;
        PrimerNombre = nombre;
        PrimerApellido = primerApellido;
        
    }
    
}