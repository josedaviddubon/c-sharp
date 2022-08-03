public class Mamifero : Mamiferos
{
    public bool Patas {get; set;}

    public int NumeroPatas { get; set; }

    public Mamifero()
    {
        Patas = true;
    }

    public Mamifero(bool patas)
    {
        Patas = patas;
    }

    public void AnimalesMamiferos()
    {
        
        Patas = true;
        Perro();
        Gato();
        Mono();
        if(Patas == true)
        {
            Console.WriteLine("Estos Mamiferos: ");
            Caminar();
            Dormir();
            Comer();
        }

    }

    public void Perro()
    {   
        Nombre = "Perro";
        Console.WriteLine(Nombre);
        Ladrar();
        NumeroPatas = 4;
        Console.WriteLine("Numero de Patas: " + " " + NumeroPatas);
        Console.WriteLine("--");
    }

    public void Gato()
    {
        Nombre = "Gato";
        Console.WriteLine(Nombre);
        Maullar();
        NumeroPatas = 4;
        Console.WriteLine("Numero de Patas: " + " " + NumeroPatas);
        Console.WriteLine("--");
    }

    public void Mono()
    {
        Nombre = "Mono";
        Console.WriteLine(Nombre);
        Maullar();
        NumeroPatas = 2;
        Console.WriteLine("Numero de Patas: " + " " + NumeroPatas);
        Console.WriteLine("--");

    }
}