public class DetalleConsulta
{
    public int Codigo {get; set;}

    public double Costo {get; set;}

    public Cita Cita {get; set;}

    public bool Estado {get; set;}

    public DetalleConsulta(int codigo, double costo, Cita cita, bool estado)
    {
        Codigo = codigo;
        Costo = costo;
        Estado = estado;
        Cita = cita;
        
    }
    
}