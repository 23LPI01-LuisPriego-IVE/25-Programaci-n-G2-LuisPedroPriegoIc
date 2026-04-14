internal class Program
{
    private static void Main(string[] args)
    {
        char op;
        double val;

        Console.WriteLine("Seleccione la unidad a convertir:");
        Console.WriteLine("a) Metros");
        Console.WriteLine("b) Pies");
        Console.WriteLine("c) Centimetros");
        Console.WriteLine("d) Pulgadas");
        op = char.Parse(Console.ReadLine().ToLower());

        Console.Write("Ingrese el valor: ");
        val = double.Parse(Console.ReadLine());

        switch (op)
        {
            case 'a':
                Console.WriteLine("Metros a otras unidades:");
                Console.WriteLine("Pies: " + (val * 3.281));
                Console.WriteLine("Centimetros: " + (val * 100));
                Console.WriteLine("Pulgadas: " + (val * 39.37));
                break;

            case 'b':
                Console.WriteLine("Pies a otras unidades:");
                Console.WriteLine("Metros: " + (val / 3.281));
                Console.WriteLine("Centimetros: " + (val * 30.48));
                Console.WriteLine("Pulgadas: " + (val * 12));
                break;

            case 'c':
                Console.WriteLine("Centimetros a otras unidades:");
                Console.WriteLine("Metros: " + (val / 100));
                Console.WriteLine("Pies: " + (val / 30.48));
                Console.WriteLine("Pulgadas: " + (val / 2.54));
                break;

            case 'd':
                Console.WriteLine("Pulgadas a otras unidades:");
                Console.WriteLine("Metros: " + (val / 39.37));
                Console.WriteLine("Pies: " + (val / 12));
                Console.WriteLine("Centimetros: " + (val * 2.54));
                break;

            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}