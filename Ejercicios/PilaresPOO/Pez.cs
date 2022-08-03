public class Pez : Peces
{
    public int Aletas { get; set; }

    public void AnimalPeces()
    {
      
      PezGlobo();
      Console.WriteLine("Estos peces: ");
      Nadar();
      Dormir();
      Comer();
    }

    public void PezGlobo()
    {
        Nombre = "Pez Globo";
        Console.WriteLine(Nombre);
        Inflar();
        Aletas = 4;
        Console.WriteLine("Numero de Aletas: " + " " + Aletas);
        Console.WriteLine("--");

    }
}