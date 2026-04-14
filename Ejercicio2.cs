internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Calculadora");

        Console.WriteLine("Digite el primer valor:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite el segundo valor:");
        double b = Convert.ToDouble(Console.ReadLine());

        double s = a + b;
        double r = a - b;
        double m = a * b;
        double d = a / b;

        Console.WriteLine("¿Qué operación desea realizar?");
        Console.WriteLine("1: Suma");
        Console.WriteLine("2: Resta");
        Console.WriteLine("3: Multiplicación");
        Console.WriteLine("4: División");
        int op = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case 1: Console.WriteLine("Resultado de la Suma: " + s); break;
            case 2: Console.WriteLine("Resultado de la Resta: " + r); break;
            case 3: Console.WriteLine("Resultado de la Multiplicación: " + m); break;
            case 4: Console.WriteLine("Resultado de la División:"+d); break;
            default: Console.WriteLine("Opción Incorrecta"); break;
        }
    }
}