public class Ave : Aves
{
    public string ColorPlumaje { get; set; }

    public void AnimalesAves()
    {
        Aguila();
        Loro();
        Console.WriteLine("Estas Aves: ");
        Dormir();
        Comer();
        

    }
    public void Aguila()
    {   
        Nombre = "Aguila";
        Console.WriteLine(Nombre);
        Volar();
        ColorPlumaje = "Negro";
        Console.WriteLine("Color de su Plumaje: " + " " + ColorPlumaje);
        Console.WriteLine("--");
    }

    public void Loro()
    {   
        Nombre = "Loro";
        Console.WriteLine(Nombre);
        Volar();
        ColorPlumaje = "Verde con muchas plumas de Color rojo o blanco";
        Console.WriteLine("Color de su Plumaje: " + " " + ColorPlumaje);
        Console.WriteLine("--");
    }
}