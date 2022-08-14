public class Medico : Persona
{

    public double Salario { get; set; }

        public Medico(int codigo, string nombre, bool disponible )
    {
        Codigo = codigo;
        PrimerNombre = nombre;
        Disponibilidad = disponible;
    }
}