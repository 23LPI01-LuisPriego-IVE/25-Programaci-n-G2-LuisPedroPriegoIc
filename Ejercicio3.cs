internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Clasificacion de letra por rango");
        Console.WriteLine("Digite una letra");
        char letra = Convert.ToChar(Console.ReadLine().ToUpper());

        switch (letra)
        {
            case 'A': Console.WriteLine("Exelente"); break;
            case 'B': Console.WriteLine("Bueno"); break;
            case 'C': Console.WriteLine("Regular"); break;
            case 'D': Console.WriteLine("Deficiente"); break;
            case 'F': Console.WriteLine("Reprobado"); break;
            default: Console.WriteLine("Digite una letra valida ente A,B,C,D y F."); break;
        }
    }
}