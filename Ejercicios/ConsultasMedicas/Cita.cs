public class Cita 

{
    public int Codigo { get; set; }

    public string Descripcion {get; set;}

    public bool Estado {get; set;}
    public double Costo { get; set; }

    public Cita(int codigo, string descripcion, double costo, bool estado)
    {
     
        Codigo = codigo;
        Descripcion = descripcion;
        Costo = costo;
        Estado = estado;

    }
    

}