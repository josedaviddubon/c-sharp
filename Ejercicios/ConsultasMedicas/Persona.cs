public class Persona {

    //public int Id {get; set;}

    public int Codigo {get; set;}
    public int NumeroIdentidad { get; set; }
    public string? PrimerNombre { get; set; }
    public string? SegundoNombre { get; set; }
    public string? PrimerApellido { get; set; }
    public string? SegundoApellido { get; set; }
    public char Sexo { get; set; }
    public int Edad { get; set; }
    public double Peso { get; set; }
    public double Altura { get; set; }
    public string? Nacionalidad {get; set;}
    public bool Disponibilidad {get; set;}

    public void NombreCompleto()
    {
        var NombreCompleto = (PrimerNombre + " " + SegundoNombre + " " + PrimerApellido + " " + SegundoApellido);
    }
}

