using System;
using System.Collections.Generic;

public class Opciones 
{ 
    public List<Medico> ListaMedicos {get; set;}
    public List<Paciente> ListaPacientes { get;  set; }
    public List<Consulta> ListaConsulta { get; set; }

    public Opciones()
    {
        ListaMedicos = new List<Medico>();
        CargarMedicos();

        ListaPacientes = new List<Paciente>();
        CargarPacientes();

        ListaConsulta = new List<Consulta>();
        CargarConsulta();

    }

    private void CargarConsulta()
    {
        Console.WriteLine("\ts - Consultas");
    }

    private void CargarPacientes()
    {
       Console.WriteLine("\ts - Pacientes");
    }

    private void CargarMedicos()
    {
        Console.WriteLine("\ts - Medicos");
    }

}
