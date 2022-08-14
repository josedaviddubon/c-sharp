public class DetalleConsulta
{
    public int Codigo {get; set;}

    public double Costo {get; set;}

    public Cita Cita {get; set;}

    public DetalleConsulta(int codigo, double costo, Cita cita)
    {
        Codigo = codigo;
        Costo = costo;
        Cita = cita;
        
    }
    
}