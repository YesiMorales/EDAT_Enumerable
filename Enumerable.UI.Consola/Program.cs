using Enumerable.UI.Consola;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=======================");
        Console.WriteLine("Enumerable");
        Console.WriteLine("=======================");
        Console.WriteLine("\n");
        Console.WriteLine("**Lista**    list<T>");

        #region Lista
        var lista = new List<Alumnos>
        {
            new Alumnos {Matricula = 1, Nombre = "Juan", Precio = 24.459M},
            new Alumnos {Matricula = 2, Nombre = "Jose", Precio = 22.999M},
            new Alumnos {Matricula = 3, Nombre = "Lis", Precio = 18.980M},
            new Alumnos {Matricula = 4, Nombre = "Ileny", Precio = 17.345M},
            new Alumnos {Matricula = 5, Nombre = "Karla", Precio = 20.234M},
            new Alumnos {Matricula = 6, Nombre = "Casco", Precio = 19.675M},
            new Alumnos {Matricula = 7, Nombre = "Mitzi", Precio = 21.999M},
            new Alumnos {Matricula = 8, Nombre = "Isabel", Precio = 15.342M},
            new Alumnos {Matricula = 9, Nombre = "Zuri", Precio = 14.999m},

        };
        // Forma  de mostrar una lista 
        //foreach (var nombre in lista)
        //{
        //    Console.WriteLine(nombre);
        //}

        //para borrar una lista 
        //lista.Clear();

        //Para ordenar en orden alfabetico
        //lista.Sort();
        lista = lista.OrderBy(x => x.Precio).ToList();

        //segunda forma de mostrar una lista
        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }

        #endregion

        Console.WriteLine("===============================================");
        Console.ReadKey();
    }
}