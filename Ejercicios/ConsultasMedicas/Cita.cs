public class Cita 

{
    public int Codigo { get; set; }

    public string Descripcion {get; set;}
    public double Costo { get; set; }

    public Cita(int codigo, string descripcion, double costo)
    {
     
        Codigo = codigo;
        Descripcion = descripcion;
        Costo = costo;
    }
    

}