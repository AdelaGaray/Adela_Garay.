// See https://aka.ms/new-console-template for more information
// SuperPoder.cs
public class SuperPoder
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public int Nivel { get; set; }

    public SuperPoder(string nombre, string descripcion, int nivel)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        Nivel = nivel;
    }
}
// SuperHeroe.cs
public class SuperHeroe
{
    public string Nombre { get; set; }
    public string IdentidadSecreta { get; set; }
    public string Ciudad { get; set; }
    public bool PuedeVolar { get; set; }
    public SuperPoder SuperPoder { get; set; }

    public SuperHeroe(string nombre, string identidadSecreta, string ciudad, bool puedeVolar, SuperPoder superPoder)
    {
        Nombre = nombre;
        IdentidadSecreta = identidadSecreta;
        Ciudad = ciudad;
        PuedeVolar = puedeVolar;
        SuperPoder = superPoder;
    }
}
// Program.cs
 

class Program
{
    static void Main()
    {
        // Crear instancias de superpoderes
        SuperPoder superPoder1 = new SuperPoder("Fuerza sobrehumana", "Capaz de levantar objetos pesados", 5);
        SuperPoder superPoder2 = new SuperPoder("Visión de rayos X", "Puede ver a través de objetos sólidos", 4);
        SuperPoder superPoder3 = new SuperPoder("Telequinesis", "Mover objetos con la mente", 5);

        // Crear instancias de superhéroes
        SuperHeroe heroe1 = new SuperHeroe("Superman", "Clark Kent", "Metropolis", true, superPoder1);
        SuperHeroe heroe2 = new SuperHeroe("Wonder Woman", "Diana Prince", "Themyscira", true, superPoder2);
        SuperHeroe heroe3 = new SuperHeroe("Jean Grey", "Fénix", "Nueva York", false, superPoder3);

        // Mostrar información de los superhéroes
        Console.WriteLine("Información de los superhéroes:\n");

        MostrarSuperHeroe(heroe1);
        MostrarSuperHeroe(heroe2);
        MostrarSuperHeroe(heroe3);

        Console.ReadLine(); // Para mantener la consola abierta
    }

    static void MostrarSuperHeroe(SuperHeroe heroe)
    {
        Console.WriteLine($"Nombre: {heroe.Nombre}");
        Console.WriteLine($"Identidad Secreta: {heroe.IdentidadSecreta}");
        Console.WriteLine($"Ciudad: {heroe.Ciudad}");
        Console.WriteLine($"Puede Volar: {(heroe.PuedeVolar ? "Sí" : "No")}");
        Console.WriteLine($"Super Poder: {heroe.SuperPoder.Nombre}");
        Console.WriteLine($"Descripción del Poder: {heroe.SuperPoder.Descripcion}");
        Console.WriteLine($"Nivel del Poder: {heroe.SuperPoder.Nivel}\n");
    }
}

