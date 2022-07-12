using System;
using System.Collections.Generic;
public class Inventario
{
    public List<Producto> ListaProductos {get; set;}

    public Inventario()
    {
        ListaProductos = new List<Producto>();
        
        Producto a = new Producto("001", "Iphone x", 0);
        Producto b = new Producto("002", "Laptop Dell", 5);
        Producto c = new Producto("003", "Monitor Samsung", 0);
        Producto d = new Producto("003", "Mouse", 100);
        Producto e = new Producto("005", "Headset", 25);

        ListaProductos.Add(a);
        ListaProductos.Add(b);
        ListaProductos.Add(c);
        ListaProductos.Add(d);
        ListaProductos.Add(e);
    }

    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Listado de Productos");
        Console.WriteLine("********************");
        Console.WriteLine("Codigo, Descripcion, Existencia");

        foreach (var prod in ListaProductos)
        {
            Console.WriteLine(prod.Codigo + "|" + prod.Descripcion + "|" + prod.Existencia.ToString());
        }

        Console.ReadLine();

    }


     private void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) {

            foreach (var producto in ListaProductos)
            {
                if (producto.Codigo == codigo) {
                    if (tipoMovimiento == "+") {
                        producto.Existencia = (producto.Existencia + cantidad);
                    } else {
                        producto.Existencia = (producto.Existencia - cantidad);
                    }
                }  
            }
        }

        public void ingresoDeInventario() {
            string codigo = "";
            string cantidad = "";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Ingreso de Productos al Inventario");
            Console.WriteLine("**********************************");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();

            movimientoInventario(codigo, Int32.Parse(cantidad), "+");
        }
        public void SalidaDeInventario() {
            string codigo = "";
            string cantidad = "";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Salida de Productos al Inventario");
            Console.WriteLine("**********************************");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();

            movimientoInventario(codigo, Int32.Parse(cantidad), "-");
        }

        public void AjustePositivo() {
            string codigo = "";
            string cantidad = "";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Ajuste Positivo al Inventario");
            Console.WriteLine("**********************************");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();

            movimientoInventario(codigo, Int32.Parse(cantidad), "+");
        }

        public void AjusteNegativo() {
            string codigo = "";
            string cantidad = "";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Ajuste Negativo al Inventario");
            Console.WriteLine("**********************************");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();

            movimientoInventario(codigo, Int32.Parse(cantidad), "-");
        }

}