using System;
using System.Collections.Generic;

public class Mamiferos : Animal
{
    public void Ladrar()
    {
      Sonido();
    }

    public void Maullar()
    {
      Console.WriteLine("Maulla"); 
    }

    private void Sonido()
    {
      Console.WriteLine("Ladra"); 
    }


    public void Caminar()
    {
        Console.WriteLine("Caminan");
    }

}