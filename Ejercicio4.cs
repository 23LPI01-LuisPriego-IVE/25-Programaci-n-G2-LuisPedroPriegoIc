internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Menú");
        Console.WriteLine("1. Hamburguesa");
        Console.WriteLine("2. Pizza");
        Console.WriteLine("3. Pollo frito");
        Console.WriteLine("4. Ensalada");
        Console.WriteLine("Elija una opción 1-4:");

        int op = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Usted ha pedido:");

        switch (op)
        {
            case 1: Console.WriteLine("Una Hamburguesa"); break;
            case 2: Console.WriteLine("Una Pizza"); break;
            case 3: Console.WriteLine("Un Pollo frito"); break;
            case 4: Console.WriteLine("Una Ensalada"); break;
            default: Console.WriteLine("Opción no válida elija un número del 1 al 4."); break;
        }
    }
}