public class Alumno 
{
    public int Id { get; set; }

    public string PrimerNombre { get; set; }

    public string SegundoNombre { get; set; }

    public bool Activo { get; set; }

    public Alumno(int id, string primerNombre, string segungoNombre)
    {
        Id = id;
        PrimerNombre = primerNombre;
        SegundoNombre = segungoNombre;
        Activo = true;

    }

    public string nombreCompleto()
    {
        if(Activo == true){
        return PrimerNombre + " " + SegundoNombre;
        }
        return "Alumno Inactivo";
    }


    public void inactivarAlumno()
    {
        Activo = false;
    }

    
    public void activarAlumno()
    {
        Activo = true;
    }
}